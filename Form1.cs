using FastAudioExtractor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;

namespace FastAudioExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_dir.Text = Settings.Default.LastFolder;
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_dir.Text = folderBrowserDialog1.SelectedPath;
                btn_analyze.PerformClick();
            }
        }

        private async void btn_analyze_Click(object sender, EventArgs e)
        {
            Settings.Default.LastFolder = tb_dir.Text;
            Settings.Default.Save();

            btn_extract.Enabled = false;

            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full);

            var extenssions = new List<string> { ".mov", "mp4" };

            var files = Directory.EnumerateFiles(tb_dir.Text)
                .Where(v => extenssions.Any(x => v.ToLower().EndsWith(x)));

            foreach (var file in files)
            {
                var audioStream = (await FFmpeg.GetMediaInfo(file))
                    .AudioStreams.FirstOrDefault();

                var codec = "Unknown";
                if (audioStream != null)
                {
                    codec = audioStream.Codec;
                }

                var lvi = new ListViewItem(new string[] { file, codec });
                lv.Items.Add(lvi);
            }

            btn_extract.Enabled = true;
        }

        private void btn_extract_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                var lvi = lv.Items[i];

                var inputFile = lvi.SubItems[0].Text;
                var codec = lvi.SubItems[1].Text;
                var outputFile = inputFile.Substring(0, inputFile.LastIndexOf('.') + 1) + codec;

                Extract(inputFile, outputFile);
            }

            MessageBox.Show("Done.");
        }

        private void Extract(string inputFile, string outputFile)
        {
            var p = new Process();
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;

            var args = $"-i \"{inputFile}\" -vn -acodec copy \"{outputFile}\"";

            Process.Start($"ffmpeg.exe", args).WaitForExit();
        }
    }
}
