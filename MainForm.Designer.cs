
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
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.currentFileLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentFileTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.inputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EnInputContainer = new System.Windows.Forms.TableLayoutPanel();
            this.EnLoadTxt = new System.Windows.Forms.TextBox();
            this.EnLoadBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.navMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.inputContainer.SuspendLayout();
            this.EnInputContainer.SuspendLayout();
            this.topPanel.SuspendLayout();
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
            this.navMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitItem});
            this.fileItem.Name = "fileItem";
            resources.ApplyResources(this.fileItem, "fileItem");
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            resources.ApplyResources(this.exitItem, "exitItem");
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
            this.currentFileTxt});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // inputContainer
            // 
            resources.ApplyResources(this.inputContainer, "inputContainer");
            this.inputContainer.Controls.Add(this.EnInputContainer, 0, 0);
            this.inputContainer.Name = "inputContainer";
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
            resources.ApplyResources(this.EnLoadTxt, "EnLoadTxt");
            this.EnLoadTxt.Name = "EnLoadTxt";
            this.EnLoadTxt.ReadOnly = true;
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.EnInputContainer.ResumeLayout(false);
            this.EnInputContainer.PerformLayout();
            this.topPanel.ResumeLayout(false);
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
    }
}

