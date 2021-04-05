
namespace ytDownGUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.urlInput = new System.Windows.Forms.TextBox();
            this.resolutionSelection = new System.Windows.Forms.ComboBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.thumbnailImage = new System.Windows.Forms.PictureBox();
            this.loadingImage = new System.Windows.Forms.PictureBox();
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.videoAuthorLabel = new System.Windows.Forms.Label();
            this.setPathButton = new System.Windows.Forms.Button();
            this.openPathButton = new System.Windows.Forms.Button();
            this.videoSelectButton = new System.Windows.Forms.Button();
            this.audioSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // urlInput
            // 
            this.urlInput.Location = new System.Drawing.Point(12, 12);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(431, 20);
            this.urlInput.TabIndex = 0;
            this.urlInput.TextChanged += new System.EventHandler(this.urlInput_TextChanged);
            // 
            // resolutionSelection
            // 
            this.resolutionSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolutionSelection.FormattingEnabled = true;
            this.resolutionSelection.Location = new System.Drawing.Point(187, 119);
            this.resolutionSelection.Name = "resolutionSelection";
            this.resolutionSelection.Size = new System.Drawing.Size(170, 21);
            this.resolutionSelection.TabIndex = 1;
            this.resolutionSelection.Text = "Select Quality";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(187, 168);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(170, 31);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // thumbnailImage
            // 
            this.thumbnailImage.Location = new System.Drawing.Point(12, 47);
            this.thumbnailImage.Name = "thumbnailImage";
            this.thumbnailImage.Size = new System.Drawing.Size(169, 97);
            this.thumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnailImage.TabIndex = 4;
            this.thumbnailImage.TabStop = false;
            // 
            // loadingImage
            // 
            this.loadingImage.Location = new System.Drawing.Point(449, -1);
            this.loadingImage.Name = "loadingImage";
            this.loadingImage.Size = new System.Drawing.Size(75, 45);
            this.loadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingImage.TabIndex = 6;
            this.loadingImage.TabStop = false;
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.AutoSize = true;
            this.videoNameLabel.Location = new System.Drawing.Point(12, 147);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(16, 13);
            this.videoNameLabel.TabIndex = 7;
            this.videoNameLabel.Text = "...";
            // 
            // videoAuthorLabel
            // 
            this.videoAuthorLabel.AutoSize = true;
            this.videoAuthorLabel.Location = new System.Drawing.Point(12, 169);
            this.videoAuthorLabel.Name = "videoAuthorLabel";
            this.videoAuthorLabel.Size = new System.Drawing.Size(16, 13);
            this.videoAuthorLabel.TabIndex = 8;
            this.videoAuthorLabel.Text = "...";
            // 
            // setPathButton
            // 
            this.setPathButton.Location = new System.Drawing.Point(187, 83);
            this.setPathButton.Name = "setPathButton";
            this.setPathButton.Size = new System.Drawing.Size(140, 30);
            this.setPathButton.TabIndex = 9;
            this.setPathButton.Text = "Select Path";
            this.setPathButton.UseVisualStyleBackColor = true;
            this.setPathButton.Click += new System.EventHandler(this.setPathButton_Click);
            // 
            // openPathButton
            // 
            this.openPathButton.Location = new System.Drawing.Point(327, 83);
            this.openPathButton.Name = "openPathButton";
            this.openPathButton.Size = new System.Drawing.Size(30, 30);
            this.openPathButton.TabIndex = 14;
            this.openPathButton.Text = "O";
            this.openPathButton.UseVisualStyleBackColor = true;
            this.openPathButton.Click += new System.EventHandler(this.openPathButton_Click);
            // 
            // videoSelectButton
            // 
            this.videoSelectButton.Location = new System.Drawing.Point(187, 47);
            this.videoSelectButton.Name = "videoSelectButton";
            this.videoSelectButton.Size = new System.Drawing.Size(85, 30);
            this.videoSelectButton.TabIndex = 15;
            this.videoSelectButton.Text = "MP4";
            this.videoSelectButton.UseVisualStyleBackColor = true;
            this.videoSelectButton.Click += new System.EventHandler(this.videoSelectButton_Click);
            // 
            // audioSelectButton
            // 
            this.audioSelectButton.Location = new System.Drawing.Point(272, 47);
            this.audioSelectButton.Name = "audioSelectButton";
            this.audioSelectButton.Size = new System.Drawing.Size(85, 30);
            this.audioSelectButton.TabIndex = 16;
            this.audioSelectButton.Text = "MP3";
            this.audioSelectButton.UseVisualStyleBackColor = true;
            this.audioSelectButton.Click += new System.EventHandler(this.audioSelectButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.audioSelectButton);
            this.Controls.Add(this.videoSelectButton);
            this.Controls.Add(this.openPathButton);
            this.Controls.Add(this.setPathButton);
            this.Controls.Add(this.videoAuthorLabel);
            this.Controls.Add(this.videoNameLabel);
            this.Controls.Add(this.loadingImage);
            this.Controls.Add(this.thumbnailImage);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.resolutionSelection);
            this.Controls.Add(this.urlInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "YouTubeDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.ComboBox resolutionSelection;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.PictureBox thumbnailImage;
        private System.Windows.Forms.PictureBox loadingImage;
        private System.Windows.Forms.Label videoNameLabel;
        private System.Windows.Forms.Label videoAuthorLabel;
        private System.Windows.Forms.Button setPathButton;
        private System.Windows.Forms.Button openPathButton;
        private System.Windows.Forms.Button videoSelectButton;
        private System.Windows.Forms.Button audioSelectButton;
    }
}

