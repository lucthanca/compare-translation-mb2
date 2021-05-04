
namespace CompareTranslatorXml
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navMenu = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearData = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.currentFileLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentFileTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberCountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberCountTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.progressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.VnInputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.VnLoadTxt = new System.Windows.Forms.TextBox();
            this.VnLoadBtn = new System.Windows.Forms.Button();
            this.CnInputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CnLoadTxt = new System.Windows.Forms.TextBox();
            this.CnLoadBtn = new System.Windows.Forms.Button();
            this.EnInputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EnLoadTxt = new System.Windows.Forms.TextBox();
            this.EnLoadBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.reformatGridBtn = new System.Windows.Forms.Button();
            this.saveVnBtn = new System.Windows.Forms.Button();
            this.listTextGroup = new System.Windows.Forms.GroupBox();
            this.listTextGrid = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.En = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.navMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.inputContainer.SuspendLayout();
            this.VnInputContainer.SuspendLayout();
            this.CnInputContainer.SuspendLayout();
            this.EnInputContainer.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.listTextGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTextGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editItem,
            this.helpItem});
            resources.ApplyResources(this.navMenu, "navMenu");
            this.navMenu.Name = "navMenu";
            this.navMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearData,
            this.exitItem});
            this.fileItem.Name = "fileItem";
            resources.ApplyResources(this.fileItem, "fileItem");
            // 
            // clearData
            // 
            this.clearData.Name = "clearData";
            resources.ApplyResources(this.clearData, "clearData");
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            resources.ApplyResources(this.exitItem, "exitItem");
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsItem});
            this.editItem.Name = "editItem";
            resources.ApplyResources(this.editItem, "editItem");
            // 
            // optionsItem
            // 
            this.optionsItem.Name = "optionsItem";
            resources.ApplyResources(this.optionsItem, "optionsItem");
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.helpItem.Name = "helpItem";
            resources.ApplyResources(this.helpItem, "helpItem");
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            resources.ApplyResources(this.aboutItem, "aboutItem");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentFileLbl,
            this.currentFileTxt,
            this.NumberCountLbl,
            this.numberCountTxt,
            this.progressBar,
            this.progressStatus});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // currentFileLbl
            // 
            this.currentFileLbl.Name = "currentFileLbl";
            resources.ApplyResources(this.currentFileLbl, "currentFileLbl");
            // 
            // currentFileTxt
            // 
            this.currentFileTxt.Name = "currentFileTxt";
            resources.ApplyResources(this.currentFileTxt, "currentFileTxt");
            // 
            // NumberCountLbl
            // 
            this.NumberCountLbl.Name = "NumberCountLbl";
            resources.ApplyResources(this.NumberCountLbl, "NumberCountLbl");
            // 
            // numberCountTxt
            // 
            this.numberCountTxt.Name = "numberCountTxt";
            resources.ApplyResources(this.numberCountTxt, "numberCountTxt");
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Step = 1;
            // 
            // progressStatus
            // 
            this.progressStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressStatus.Name = "progressStatus";
            resources.ApplyResources(this.progressStatus, "progressStatus");
            // 
            // inputContainer
            // 
            resources.ApplyResources(this.inputContainer, "inputContainer");
            this.inputContainer.Controls.Add(this.VnInputContainer, 2, 0);
            this.inputContainer.Controls.Add(this.CnInputContainer, 1, 0);
            this.inputContainer.Controls.Add(this.EnInputContainer, 0, 0);
            this.inputContainer.Name = "inputContainer";
            // 
            // VnInputContainer
            // 
            resources.ApplyResources(this.VnInputContainer, "VnInputContainer");
            this.VnInputContainer.Controls.Add(this.VnLoadTxt, 0, 0);
            this.VnInputContainer.Controls.Add(this.VnLoadBtn, 1, 0);
            this.VnInputContainer.Name = "VnInputContainer";
            // 
            // VnLoadTxt
            // 
            this.VnLoadTxt.AllowDrop = true;
            resources.ApplyResources(this.VnLoadTxt, "VnLoadTxt");
            this.VnLoadTxt.Name = "VnLoadTxt";
            this.VnLoadTxt.ReadOnly = true;
            this.VnLoadTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.VnLoadTxt_DragDrop);
            this.VnLoadTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // VnLoadBtn
            // 
            resources.ApplyResources(this.VnLoadBtn, "VnLoadBtn");
            this.VnLoadBtn.Name = "VnLoadBtn";
            this.VnLoadBtn.UseVisualStyleBackColor = true;
            this.VnLoadBtn.Click += new System.EventHandler(this.VnLoadBtn_Click);
            // 
            // CnInputContainer
            // 
            resources.ApplyResources(this.CnInputContainer, "CnInputContainer");
            this.CnInputContainer.Controls.Add(this.CnLoadTxt, 0, 0);
            this.CnInputContainer.Controls.Add(this.CnLoadBtn, 1, 0);
            this.CnInputContainer.Name = "CnInputContainer";
            // 
            // CnLoadTxt
            // 
            this.CnLoadTxt.AllowDrop = true;
            resources.ApplyResources(this.CnLoadTxt, "CnLoadTxt");
            this.CnLoadTxt.Name = "CnLoadTxt";
            this.CnLoadTxt.ReadOnly = true;
            this.CnLoadTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.CnLoadTxt_DragDrop);
            this.CnLoadTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // CnLoadBtn
            // 
            resources.ApplyResources(this.CnLoadBtn, "CnLoadBtn");
            this.CnLoadBtn.Name = "CnLoadBtn";
            this.CnLoadBtn.UseVisualStyleBackColor = true;
            this.CnLoadBtn.Click += new System.EventHandler(this.CnLoadBtn_Click);
            // 
            // EnInputContainer
            // 
            resources.ApplyResources(this.EnInputContainer, "EnInputContainer");
            this.EnInputContainer.Controls.Add(this.EnLoadTxt, 0, 0);
            this.EnInputContainer.Controls.Add(this.EnLoadBtn, 1, 0);
            this.EnInputContainer.Name = "EnInputContainer";
            // 
            // EnLoadTxt
            // 
            this.EnLoadTxt.AllowDrop = true;
            resources.ApplyResources(this.EnLoadTxt, "EnLoadTxt");
            this.EnLoadTxt.Name = "EnLoadTxt";
            this.EnLoadTxt.ReadOnly = true;
            this.EnLoadTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.EnLoadTxt_DragDrop);
            this.EnLoadTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // EnLoadBtn
            // 
            resources.ApplyResources(this.EnLoadBtn, "EnLoadBtn");
            this.EnLoadBtn.Name = "EnLoadBtn";
            this.EnLoadBtn.UseVisualStyleBackColor = true;
            this.EnLoadBtn.Click += new System.EventHandler(this.EnLoadBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.inputContainer);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.reformatGridBtn);
            this.actionPanel.Controls.Add(this.saveVnBtn);
            resources.ApplyResources(this.actionPanel, "actionPanel");
            this.actionPanel.Name = "actionPanel";
            // 
            // reformatGridBtn
            // 
            resources.ApplyResources(this.reformatGridBtn, "reformatGridBtn");
            this.reformatGridBtn.Name = "reformatGridBtn";
            this.reformatGridBtn.UseVisualStyleBackColor = true;
            this.reformatGridBtn.Click += new System.EventHandler(this.reformatGridBtn_Click);
            // 
            // saveVnBtn
            // 
            resources.ApplyResources(this.saveVnBtn, "saveVnBtn");
            this.saveVnBtn.Name = "saveVnBtn";
            this.saveVnBtn.UseVisualStyleBackColor = true;
            this.saveVnBtn.Click += new System.EventHandler(this.saveVnBtn_Click);
            // 
            // listTextGroup
            // 
            resources.ApplyResources(this.listTextGroup, "listTextGroup");
            this.listTextGroup.Controls.Add(this.listTextGrid);
            this.listTextGroup.Name = "listTextGroup";
            this.listTextGroup.TabStop = false;
            // 
            // listTextGrid
            // 
            this.listTextGrid.AllowUserToAddRows = false;
            this.listTextGrid.AllowUserToDeleteRows = false;
            this.listTextGrid.AllowUserToOrderColumns = true;
            this.listTextGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listTextGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTextGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.En,
            this.Cn,
            this.Vn});
            resources.ApplyResources(this.listTextGrid, "listTextGrid");
            this.listTextGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listTextGrid.Name = "listTextGrid";
            this.listTextGrid.RowTemplate.Height = 25;
            this.listTextGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.listTextGrid_CellEndEdit);
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.FillWeight = 50.76143F;
            resources.ApplyResources(this.Index, "Index");
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 62.40456F;
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // En
            // 
            this.En.DataPropertyName = "En";
            this.En.FillWeight = 128.9447F;
            resources.ApplyResources(this.En, "En");
            this.En.Name = "En";
            this.En.ReadOnly = true;
            // 
            // Cn
            // 
            this.Cn.DataPropertyName = "Cn";
            this.Cn.FillWeight = 128.9447F;
            resources.ApplyResources(this.Cn, "Cn");
            this.Cn.Name = "Cn";
            this.Cn.ReadOnly = true;
            // 
            // Vn
            // 
            this.Vn.DataPropertyName = "Vn";
            this.Vn.FillWeight = 128.9447F;
            resources.ApplyResources(this.Vn, "Vn");
            this.Vn.Name = "Vn";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listTextGroup);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.navMenu);
            this.MainMenuStrip = this.navMenu;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navMenu.ResumeLayout(false);
            this.navMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.inputContainer.ResumeLayout(false);
            this.VnInputContainer.ResumeLayout(false);
            this.VnInputContainer.PerformLayout();
            this.CnInputContainer.ResumeLayout(false);
            this.CnInputContainer.PerformLayout();
            this.EnInputContainer.ResumeLayout(false);
            this.EnInputContainer.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.listTextGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listTextGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navMenu;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem optionsItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel currentFileLbl;
        private System.Windows.Forms.ToolStripStatusLabel currentFileTxt;
        private System.Windows.Forms.TableLayoutPanel inputContainer;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox EnLoadTxt;
        private System.Windows.Forms.TableLayoutPanel EnInputContainer;
        private System.Windows.Forms.Button EnLoadBtn;
        private System.Windows.Forms.TableLayoutPanel CnInputContainer;
        private System.Windows.Forms.TextBox CnLoadTxt;
        private System.Windows.Forms.Button CnLoadBtn;
        private System.Windows.Forms.TableLayoutPanel VnInputContainer;
        private System.Windows.Forms.TextBox VnLoadTxt;
        private System.Windows.Forms.Button VnLoadBtn;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button saveVnBtn;
        private System.Windows.Forms.GroupBox listTextGroup;
        private System.Windows.Forms.DataGridView listTextGrid;
        private System.Windows.Forms.ToolStripMenuItem clearData;
        private System.Windows.Forms.ToolStripStatusLabel NumberCountLbl;
        private System.Windows.Forms.ToolStripStatusLabel numberCountTxt;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel progressStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn En;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vn;
        private System.Windows.Forms.Button reformatGridBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

