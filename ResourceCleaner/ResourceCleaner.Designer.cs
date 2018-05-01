namespace ResourceCleaner
{
    partial class ResourceCleaner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceCleaner));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.openCleanResource = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.generateCleanResxButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseResourceButton = new System.Windows.Forms.Button();
            this.resourcePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseProjectButton = new System.Windows.Forms.Button();
            this.projectFolderTextBox = new System.Windows.Forms.TextBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.openCleanResource);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.generateCleanResxButton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.filterTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.browseResourceButton);
            this.splitContainer1.Panel1.Controls.Add(this.resourcePathTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.browseProjectButton);
            this.splitContainer1.Panel1.Controls.Add(this.projectFolderTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.outputRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(666, 380);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // openCleanResource
            // 
            this.openCleanResource.Enabled = false;
            this.openCleanResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openCleanResource.Location = new System.Drawing.Point(14, 206);
            this.openCleanResource.Name = "openCleanResource";
            this.openCleanResource.Size = new System.Drawing.Size(209, 23);
            this.openCleanResource.TabIndex = 2;
            this.openCleanResource.Text = "Open Clean .RESX Folder";
            this.openCleanResource.UseVisualStyleBackColor = true;
            this.openCleanResource.Click += new System.EventHandler(this.openCleanResource_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Read more:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "This makes the app cooler!";
            this.pictureBox1.Image = global::ResourceCleaner.Properties.Resources.trex_icon;
            this.pictureBox1.Location = new System.Drawing.Point(40, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(69, 355);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://dotjord.wordpress.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // generateCleanResxButton
            // 
            this.generateCleanResxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateCleanResxButton.Location = new System.Drawing.Point(14, 177);
            this.generateCleanResxButton.Name = "generateCleanResxButton";
            this.generateCleanResxButton.Size = new System.Drawing.Size(209, 23);
            this.generateCleanResxButton.TabIndex = 8;
            this.generateCleanResxButton.Text = "Generate Clean RESX";
            this.generateCleanResxButton.UseVisualStyleBackColor = true;
            this.generateCleanResxButton.Click += new System.EventHandler(this.generateCleanResxButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Look at these file types:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(13, 144);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(208, 20);
            this.filterTextBox.TabIndex = 6;
            this.filterTextBox.Text = "*.cs;*.cshtml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resource File:";
            // 
            // browseResourceButton
            // 
            this.browseResourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseResourceButton.Location = new System.Drawing.Point(146, 88);
            this.browseResourceButton.Name = "browseResourceButton";
            this.browseResourceButton.Size = new System.Drawing.Size(75, 23);
            this.browseResourceButton.TabIndex = 4;
            this.browseResourceButton.Text = "Browse";
            this.browseResourceButton.UseVisualStyleBackColor = true;
            this.browseResourceButton.Click += new System.EventHandler(this.browseResourceButton_Click);
            // 
            // resourcePathTextBox
            // 
            this.resourcePathTextBox.Location = new System.Drawing.Point(13, 88);
            this.resourcePathTextBox.Name = "resourcePathTextBox";
            this.resourcePathTextBox.Size = new System.Drawing.Size(129, 20);
            this.resourcePathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Folder:";
            // 
            // browseProjectButton
            // 
            this.browseProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseProjectButton.Location = new System.Drawing.Point(146, 37);
            this.browseProjectButton.Name = "browseProjectButton";
            this.browseProjectButton.Size = new System.Drawing.Size(75, 23);
            this.browseProjectButton.TabIndex = 1;
            this.browseProjectButton.Text = "Browse";
            this.browseProjectButton.UseVisualStyleBackColor = true;
            this.browseProjectButton.Click += new System.EventHandler(this.browseProjectButton_Click);
            // 
            // projectFolderTextBox
            // 
            this.projectFolderTextBox.Location = new System.Drawing.Point(13, 36);
            this.projectFolderTextBox.Name = "projectFolderTextBox";
            this.projectFolderTextBox.Size = new System.Drawing.Size(129, 20);
            this.projectFolderTextBox.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(4, 4);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 1;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(3, 4);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(428, 373);
            this.outputRichTextBox.TabIndex = 0;
            this.outputRichTextBox.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // ResourceCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(666, 380);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResourceCleaner";
            this.Text = "CLE-Rex";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseResourceButton;
        private System.Windows.Forms.TextBox resourcePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseProjectButton;
        private System.Windows.Forms.TextBox projectFolderTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button generateCleanResxButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button openCleanResource;
    }
}

