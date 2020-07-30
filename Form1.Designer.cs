namespace FastAudioExtractor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_analyze = new System.Windows.Forms.Button();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.audioType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_extract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_dir
            // 
            this.tb_dir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_dir.Location = new System.Drawing.Point(84, 12);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(735, 20);
            this.tb_dir.TabIndex = 1;
            this.tb_dir.Text = "D:\\tmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video Folder";
            // 
            // btn_analyze
            // 
            this.btn_analyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_analyze.BackgroundImage = global::FastAudioExtractor.Properties.Resources.Crystal_Clear_app_kfind;
            this.btn_analyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_analyze.Location = new System.Drawing.Point(861, 6);
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.Size = new System.Drawing.Size(30, 30);
            this.btn_analyze.TabIndex = 4;
            this.btn_analyze.UseVisualStyleBackColor = true;
            this.btn_analyze.Click += new System.EventHandler(this.btn_analyze_Click);
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectFolder.BackgroundImage = global::FastAudioExtractor.Properties.Resources._128px_Human_folder_svg;
            this.btn_selectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_selectFolder.Location = new System.Drawing.Point(825, 6);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(30, 30);
            this.btn_selectFolder.TabIndex = 2;
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.audioType});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 38);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(879, 499);
            this.lv.TabIndex = 5;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 500;
            // 
            // audioType
            // 
            this.audioType.Text = "Audio Type";
            this.audioType.Width = 200;
            // 
            // btn_extract
            // 
            this.btn_extract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extract.Enabled = false;
            this.btn_extract.Location = new System.Drawing.Point(783, 543);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(108, 33);
            this.btn_extract.TabIndex = 6;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 588);
            this.Controls.Add(this.btn_extract);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.btn_analyze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectFolder);
            this.Controls.Add(this.tb_dir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader audioType;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_extract;
    }
}

