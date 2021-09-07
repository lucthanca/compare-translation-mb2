namespace CompareTranslatorXml
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsTabPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.SavingGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoSaveTypeSettingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AutoSaveTypeLabel = new System.Windows.Forms.Label();
            this.AutoSaveTypeCb = new System.Windows.Forms.ComboBox();
            this.IdleTimePanel = new System.Windows.Forms.TableLayoutPanel();
            this.IdleTimeTxt = new System.Windows.Forms.TextBox();
            this.TimeSecondLbl = new System.Windows.Forms.Label();
            this.IdleInLabel = new System.Windows.Forms.Label();
            this.AutoSaveChk = new System.Windows.Forms.CheckBox();
            this.SelectLanguageSettingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectLangCb = new System.Windows.Forms.ComboBox();
            this.SelectLangLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SettingsTabPanel.SuspendLayout();
            this.SettingsTabControl.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.SavingGroupBox.SuspendLayout();
            this.AutoSaveTypeSettingPanel.SuspendLayout();
            this.IdleTimePanel.SuspendLayout();
            this.SelectLanguageSettingPanel.SuspendLayout();
            this.ActionLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTabPanel
            // 
            this.SettingsTabPanel.AutoSize = true;
            this.SettingsTabPanel.Controls.Add(this.SettingsTabControl);
            this.SettingsTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTabPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsTabPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsTabPanel.Name = "SettingsTabPanel";
            this.SettingsTabPanel.Size = new System.Drawing.Size(400, 232);
            this.SettingsTabPanel.TabIndex = 0;
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.TabGeneral);
            this.SettingsTabControl.Controls.Add(this.tabPage2);
            this.SettingsTabControl.Location = new System.Drawing.Point(5, 10);
            this.SettingsTabControl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
            this.SettingsTabControl.Multiline = true;
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(390, 219);
            this.SettingsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.SettingsTabControl.TabIndex = 0;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.SavingGroupBox);
            this.TabGeneral.Controls.Add(this.SelectLanguageSettingPanel);
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(382, 193);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "General";
            this.TabGeneral.UseVisualStyleBackColor = true;
            // 
            // SavingGroupBox
            // 
            this.SavingGroupBox.Controls.Add(this.AutoSaveTypeSettingPanel);
            this.SavingGroupBox.Controls.Add(this.AutoSaveChk);
            this.SavingGroupBox.Location = new System.Drawing.Point(6, 46);
            this.SavingGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.SavingGroupBox.Name = "SavingGroupBox";
            this.SavingGroupBox.Size = new System.Drawing.Size(370, 83);
            this.SavingGroupBox.TabIndex = 0;
            this.SavingGroupBox.TabStop = false;
            this.SavingGroupBox.Text = "Saving";
            // 
            // AutoSaveTypeSettingPanel
            // 
            this.AutoSaveTypeSettingPanel.AutoSize = true;
            this.AutoSaveTypeSettingPanel.ColumnCount = 3;
            this.AutoSaveTypeSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AutoSaveTypeSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AutoSaveTypeSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AutoSaveTypeSettingPanel.Controls.Add(this.AutoSaveTypeLabel, 0, 0);
            this.AutoSaveTypeSettingPanel.Controls.Add(this.AutoSaveTypeCb, 1, 0);
            this.AutoSaveTypeSettingPanel.Controls.Add(this.IdleTimePanel, 2, 0);
            this.AutoSaveTypeSettingPanel.Location = new System.Drawing.Point(6, 34);
            this.AutoSaveTypeSettingPanel.Name = "AutoSaveTypeSettingPanel";
            this.AutoSaveTypeSettingPanel.RowCount = 1;
            this.AutoSaveTypeSettingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AutoSaveTypeSettingPanel.Size = new System.Drawing.Size(358, 29);
            this.AutoSaveTypeSettingPanel.TabIndex = 2;
            // 
            // AutoSaveTypeLabel
            // 
            this.AutoSaveTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSaveTypeLabel.AutoSize = true;
            this.AutoSaveTypeLabel.Location = new System.Drawing.Point(0, 8);
            this.AutoSaveTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AutoSaveTypeLabel.Name = "AutoSaveTypeLabel";
            this.AutoSaveTypeLabel.Size = new System.Drawing.Size(89, 13);
            this.AutoSaveTypeLabel.TabIndex = 3;
            this.AutoSaveTypeLabel.Text = "Auto Save When";
            // 
            // AutoSaveTypeCb
            // 
            this.AutoSaveTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoSaveTypeCb.FormattingEnabled = true;
            this.AutoSaveTypeCb.Location = new System.Drawing.Point(92, 4);
            this.AutoSaveTypeCb.Name = "AutoSaveTypeCb";
            this.AutoSaveTypeCb.Size = new System.Drawing.Size(121, 21);
            this.AutoSaveTypeCb.TabIndex = 2;
            this.AutoSaveTypeCb.SelectedValueChanged += new System.EventHandler(this.AutoSaveSelectIdleTimeType);
            // 
            // IdleTimePanel
            // 
            this.IdleTimePanel.AutoSize = true;
            this.IdleTimePanel.ColumnCount = 3;
            this.IdleTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IdleTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IdleTimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IdleTimePanel.Controls.Add(this.IdleTimeTxt, 1, 0);
            this.IdleTimePanel.Controls.Add(this.TimeSecondLbl, 2, 0);
            this.IdleTimePanel.Controls.Add(this.IdleInLabel, 0, 0);
            this.IdleTimePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdleTimePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.IdleTimePanel.Location = new System.Drawing.Point(216, 0);
            this.IdleTimePanel.Margin = new System.Windows.Forms.Padding(0);
            this.IdleTimePanel.Name = "IdleTimePanel";
            this.IdleTimePanel.RowCount = 1;
            this.IdleTimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IdleTimePanel.Size = new System.Drawing.Size(142, 29);
            this.IdleTimePanel.TabIndex = 4;
            this.IdleTimePanel.Visible = false;
            // 
            // IdleTimeTxt
            // 
            this.IdleTimeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdleTimeTxt.Location = new System.Drawing.Point(25, 4);
            this.IdleTimeTxt.Name = "IdleTimeTxt";
            this.IdleTimeTxt.Size = new System.Drawing.Size(50, 20);
            this.IdleTimeTxt.TabIndex = 5;
            this.IdleTimeTxt.Text = "15";
            this.IdleTimeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.IdleTimeTxt_Validating);
            // 
            // TimeSecondLbl
            // 
            this.TimeSecondLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSecondLbl.AutoSize = true;
            this.TimeSecondLbl.Location = new System.Drawing.Point(81, 8);
            this.TimeSecondLbl.Name = "TimeSecondLbl";
            this.TimeSecondLbl.Size = new System.Drawing.Size(58, 13);
            this.TimeSecondLbl.TabIndex = 6;
            this.TimeSecondLbl.Text = "Giây";
            // 
            // IdleInLabel
            // 
            this.IdleInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdleInLabel.AutoSize = true;
            this.IdleInLabel.Location = new System.Drawing.Point(3, 8);
            this.IdleInLabel.Name = "IdleInLabel";
            this.IdleInLabel.Size = new System.Drawing.Size(16, 13);
            this.IdleInLabel.TabIndex = 4;
            this.IdleInLabel.Text = "In";
            // 
            // AutoSaveChk
            // 
            this.AutoSaveChk.AutoSize = true;
            this.AutoSaveChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoSaveChk.Checked = true;
            this.AutoSaveChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSaveChk.Location = new System.Drawing.Point(6, 19);
            this.AutoSaveChk.Name = "AutoSaveChk";
            this.AutoSaveChk.Size = new System.Drawing.Size(76, 17);
            this.AutoSaveChk.TabIndex = 1;
            this.AutoSaveChk.Text = "Auto Save";
            this.AutoSaveChk.UseVisualStyleBackColor = true;
            this.AutoSaveChk.CheckedChanged += new System.EventHandler(this.OnOffAutoSave);
            // 
            // SelectLanguageSettingPanel
            // 
            this.SelectLanguageSettingPanel.ColumnCount = 3;
            this.SelectLanguageSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.SelectLanguageSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SelectLanguageSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectLanguageSettingPanel.Controls.Add(this.SelectLangCb, 2, 0);
            this.SelectLanguageSettingPanel.Controls.Add(this.SelectLangLbl, 1, 0);
            this.SelectLanguageSettingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectLanguageSettingPanel.Location = new System.Drawing.Point(3, 3);
            this.SelectLanguageSettingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SelectLanguageSettingPanel.Name = "SelectLanguageSettingPanel";
            this.SelectLanguageSettingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.SelectLanguageSettingPanel.Size = new System.Drawing.Size(376, 31);
            this.SelectLanguageSettingPanel.TabIndex = 2;
            // 
            // SelectLangCb
            // 
            this.SelectLangCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectLangCb.FormattingEnabled = true;
            this.SelectLangCb.Location = new System.Drawing.Point(67, 5);
            this.SelectLangCb.Name = "SelectLangCb";
            this.SelectLangCb.Size = new System.Drawing.Size(121, 21);
            this.SelectLangCb.TabIndex = 2;
            this.SelectLangCb.SelectedValueChanged += new System.EventHandler(this.ChangeLanguage);
            // 
            // SelectLangLbl
            // 
            this.SelectLangLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLangLbl.AutoSize = true;
            this.SelectLangLbl.Location = new System.Drawing.Point(9, 9);
            this.SelectLangLbl.Margin = new System.Windows.Forms.Padding(0);
            this.SelectLangLbl.Name = "SelectLangLbl";
            this.SelectLangLbl.Size = new System.Drawing.Size(55, 13);
            this.SelectLangLbl.TabIndex = 1;
            this.SelectLangLbl.Text = "Language";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActionLayoutPanel
            // 
            this.ActionLayoutPanel.ColumnCount = 2;
            this.ActionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ActionLayoutPanel.Controls.Add(this.CancelBtn, 1, 0);
            this.ActionLayoutPanel.Controls.Add(this.OkBtn, 0, 0);
            this.ActionLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionLayoutPanel.Location = new System.Drawing.Point(0, 420);
            this.ActionLayoutPanel.Name = "ActionLayoutPanel";
            this.ActionLayoutPanel.RowCount = 1;
            this.ActionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ActionLayoutPanel.Size = new System.Drawing.Size(400, 30);
            this.ActionLayoutPanel.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.Location = new System.Drawing.Point(322, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 24);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OkBtn.AutoSize = true;
            this.OkBtn.Location = new System.Drawing.Point(241, 3);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 24);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.SaveSettings);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.ActionLayoutPanel);
            this.Controls.Add(this.SettingsTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.SettingsTabPanel.ResumeLayout(false);
            this.SettingsTabControl.ResumeLayout(false);
            this.TabGeneral.ResumeLayout(false);
            this.SavingGroupBox.ResumeLayout(false);
            this.SavingGroupBox.PerformLayout();
            this.AutoSaveTypeSettingPanel.ResumeLayout(false);
            this.AutoSaveTypeSettingPanel.PerformLayout();
            this.IdleTimePanel.ResumeLayout(false);
            this.IdleTimePanel.PerformLayout();
            this.SelectLanguageSettingPanel.ResumeLayout(false);
            this.SelectLanguageSettingPanel.PerformLayout();
            this.ActionLayoutPanel.ResumeLayout(false);
            this.ActionLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SettingsTabPanel;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel ActionLayoutPanel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.GroupBox SavingGroupBox;
        private System.Windows.Forms.CheckBox AutoSaveChk;
        private System.Windows.Forms.Label AutoSaveTypeLabel;
        private System.Windows.Forms.ComboBox AutoSaveTypeCb;
        private System.Windows.Forms.TextBox IdleTimeTxt;
        private System.Windows.Forms.Label IdleInLabel;
        private System.Windows.Forms.TableLayoutPanel AutoSaveTypeSettingPanel;
        private System.Windows.Forms.Label TimeSecondLbl;
        private System.Windows.Forms.TableLayoutPanel IdleTimePanel;
        private System.Windows.Forms.Label SelectLangLbl;
        private System.Windows.Forms.ComboBox SelectLangCb;
        private System.Windows.Forms.TableLayoutPanel SelectLanguageSettingPanel;
    }
}