namespace SandcastleBuilder.Gui.ContentEditors
{
    partial class SiteMapEditorWindow
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteMapEditorWindow));
            this.ehSiteMapEditorHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // ehSiteMapEditorHost
            // 
            this.ehSiteMapEditorHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ehSiteMapEditorHost.Location = new System.Drawing.Point(0, 0);
            this.ehSiteMapEditorHost.Name = "ehSiteMapEditorHost";
            this.ehSiteMapEditorHost.Size = new System.Drawing.Size(882, 555);
            this.ehSiteMapEditorHost.TabIndex = 0;
            this.ehSiteMapEditorHost.Child = null;
            // 
            // SiteMapEditorWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(882, 555);
            this.Controls.Add(this.ehSiteMapEditorHost);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiteMapEditorWindow";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SiteMapEditorWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost ehSiteMapEditorHost;
    }
}
