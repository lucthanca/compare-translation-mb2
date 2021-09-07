
namespace CompareTranslatorXml
{
    partial class AboutAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutAuthorForm));
            this.ltcLogo = new System.Windows.Forms.PictureBox();
            this.AppName = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.logoNameVerContainer = new System.Windows.Forms.Panel();
            this.nameAndVerContainer = new System.Windows.Forms.Panel();
            this.VersionContainer = new System.Windows.Forms.Panel();
            this.checkUpdateBtn = new System.Windows.Forms.Button();
            this.NameContainer = new System.Windows.Forms.Panel();
            this.logoContainer = new System.Windows.Forms.Panel();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.FbLink = new System.Windows.Forms.LinkLabel();
            this.FacebookLabel = new System.Windows.Forms.Label();
            this.AuthName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ltcLogo)).BeginInit();
            this.logoNameVerContainer.SuspendLayout();
            this.nameAndVerContainer.SuspendLayout();
            this.VersionContainer.SuspendLayout();
            this.NameContainer.SuspendLayout();
            this.logoContainer.SuspendLayout();
            this.AuthorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltcLogo
            // 
            this.ltcLogo.Image = global::CompareTranslatorXml.Properties.Resources.Logo_Zen_Circle_LTC_64x64;
            this.ltcLogo.InitialImage = global::CompareTranslatorXml.Properties.Resources.Logo_Zen_Circle_LTC_64x64;
            this.ltcLogo.Location = new System.Drawing.Point(9, 9);
            this.ltcLogo.Margin = new System.Windows.Forms.Padding(0);
            this.ltcLogo.Name = "ltcLogo";
            this.ltcLogo.Size = new System.Drawing.Size(64, 64);
            this.ltcLogo.TabIndex = 0;
            this.ltcLogo.TabStop = false;
            // 
            // AppName
            // 
            this.AppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AppName.Location = new System.Drawing.Point(10, 3);
            this.AppName.Margin = new System.Windows.Forms.Padding(0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(267, 32);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "Compare Translator";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // version
            // 
            this.version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(82, 3);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(134, 17);
            this.version.TabIndex = 2;
            this.version.Text = "Version: 1.0.0";
            this.version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoNameVerContainer
            // 
            this.logoNameVerContainer.Controls.Add(this.nameAndVerContainer);
            this.logoNameVerContainer.Controls.Add(this.logoContainer);
            this.logoNameVerContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoNameVerContainer.Location = new System.Drawing.Point(0, 0);
            this.logoNameVerContainer.Name = "logoNameVerContainer";
            this.logoNameVerContainer.Size = new System.Drawing.Size(384, 82);
            this.logoNameVerContainer.TabIndex = 3;
            // 
            // nameAndVerContainer
            // 
            this.nameAndVerContainer.Controls.Add(this.VersionContainer);
            this.nameAndVerContainer.Controls.Add(this.NameContainer);
            this.nameAndVerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameAndVerContainer.Location = new System.Drawing.Point(86, 0);
            this.nameAndVerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.nameAndVerContainer.Name = "nameAndVerContainer";
            this.nameAndVerContainer.Size = new System.Drawing.Size(298, 82);
            this.nameAndVerContainer.TabIndex = 4;
            // 
            // VersionContainer
            // 
            this.VersionContainer.Controls.Add(this.checkUpdateBtn);
            this.VersionContainer.Controls.Add(this.version);
            this.VersionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionContainer.Location = new System.Drawing.Point(0, 35);
            this.VersionContainer.Margin = new System.Windows.Forms.Padding(0);
            this.VersionContainer.Name = "VersionContainer";
            this.VersionContainer.Size = new System.Drawing.Size(298, 47);
            this.VersionContainer.TabIndex = 1;
            // 
            // checkUpdateBtn
            // 
            this.checkUpdateBtn.AutoSize = true;
            this.checkUpdateBtn.Location = new System.Drawing.Point(64, 23);
            this.checkUpdateBtn.Name = "checkUpdateBtn";
            this.checkUpdateBtn.Size = new System.Drawing.Size(168, 23);
            this.checkUpdateBtn.TabIndex = 5;
            this.checkUpdateBtn.Text = "Check for update\r\n";
            this.checkUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // NameContainer
            // 
            this.NameContainer.Controls.Add(this.AppName);
            this.NameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameContainer.Location = new System.Drawing.Point(0, 0);
            this.NameContainer.Margin = new System.Windows.Forms.Padding(0);
            this.NameContainer.Name = "NameContainer";
            this.NameContainer.Size = new System.Drawing.Size(298, 35);
            this.NameContainer.TabIndex = 0;
            // 
            // logoContainer
            // 
            this.logoContainer.Controls.Add(this.ltcLogo);
            this.logoContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoContainer.Location = new System.Drawing.Point(0, 0);
            this.logoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.logoContainer.Name = "logoContainer";
            this.logoContainer.Size = new System.Drawing.Size(86, 82);
            this.logoContainer.TabIndex = 4;
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.FbLink);
            this.AuthorGroupBox.Controls.Add(this.FacebookLabel);
            this.AuthorGroupBox.Controls.Add(this.AuthName);
            this.AuthorGroupBox.Location = new System.Drawing.Point(20, 96);
            this.AuthorGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(343, 59);
            this.AuthorGroupBox.TabIndex = 4;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Author";
            // 
            // FbLink
            // 
            this.FbLink.AutoSize = true;
            this.FbLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FbLink.Location = new System.Drawing.Point(79, 33);
            this.FbLink.Name = "FbLink";
            this.FbLink.Size = new System.Drawing.Size(125, 13);
            this.FbLink.TabIndex = 2;
            this.FbLink.TabStop = true;
            this.FbLink.Text = "Facebook | Lục Thần Ca";
            this.FbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FbLink_LinkClicked);
            // 
            // FacebookLabel
            // 
            this.FacebookLabel.AutoSize = true;
            this.FacebookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacebookLabel.Location = new System.Drawing.Point(7, 33);
            this.FacebookLabel.Name = "FacebookLabel";
            this.FacebookLabel.Size = new System.Drawing.Size(67, 13);
            this.FacebookLabel.TabIndex = 1;
            this.FacebookLabel.Text = "Facebook:";
            // 
            // AuthName
            // 
            this.AuthName.AutoSize = true;
            this.AuthName.Location = new System.Drawing.Point(6, 16);
            this.AuthName.Name = "AuthName";
            this.AuthName.Size = new System.Drawing.Size(69, 13);
            this.AuthName.TabIndex = 0;
            this.AuthName.Text = "Lục Thần Ca";
            // 
            // AboutAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 173);
            this.Controls.Add(this.AuthorGroupBox);
            this.Controls.Add(this.logoNameVerContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Lục Thần Ca";
            ((System.ComponentModel.ISupportInitialize)(this.ltcLogo)).EndInit();
            this.logoNameVerContainer.ResumeLayout(false);
            this.nameAndVerContainer.ResumeLayout(false);
            this.VersionContainer.ResumeLayout(false);
            this.VersionContainer.PerformLayout();
            this.NameContainer.ResumeLayout(false);
            this.NameContainer.PerformLayout();
            this.logoContainer.ResumeLayout(false);
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ltcLogo;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Panel logoNameVerContainer;
        private System.Windows.Forms.Panel nameAndVerContainer;
        private System.Windows.Forms.Panel VersionContainer;
        private System.Windows.Forms.Panel NameContainer;
        private System.Windows.Forms.Panel logoContainer;
        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.Button checkUpdateBtn;
        private System.Windows.Forms.LinkLabel FbLink;
        private System.Windows.Forms.Label FacebookLabel;
        private System.Windows.Forms.Label AuthName;
    }
}