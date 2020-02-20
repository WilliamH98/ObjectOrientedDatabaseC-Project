namespace ProjekLab
{
    partial class MainFormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.masterWatchStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.masterWatchTypeStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.masterUserStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTransStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrMenu
            // 
            this.fileStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordStrMenu,
            this.logoutStrMenu,
            this.exitStrMenu,
            this.masterWatchStrMenu,
            this.masterWatchTypeStrMenu,
            this.masterUserStrMenu,
            this.viewAllTransStrMenu});
            this.fileStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileStrMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileStrMenu.Name = "fileStrMenu";
            this.fileStrMenu.Size = new System.Drawing.Size(41, 21);
            this.fileStrMenu.Text = "File";
            // 
            // changePasswordStrMenu
            // 
            this.changePasswordStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordStrMenu.Name = "changePasswordStrMenu";
            this.changePasswordStrMenu.Size = new System.Drawing.Size(199, 22);
            this.changePasswordStrMenu.Text = "Change Password";
            this.changePasswordStrMenu.Click += new System.EventHandler(this.changePasswordStrMenu_Click_1);
            // 
            // logoutStrMenu
            // 
            this.logoutStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutStrMenu.Name = "logoutStrMenu";
            this.logoutStrMenu.Size = new System.Drawing.Size(199, 22);
            this.logoutStrMenu.Text = "Log Out";
            this.logoutStrMenu.Click += new System.EventHandler(this.logoutStrMenu_Click_1);
            // 
            // exitStrMenu
            // 
            this.exitStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitStrMenu.Name = "exitStrMenu";
            this.exitStrMenu.Size = new System.Drawing.Size(199, 22);
            this.exitStrMenu.Text = "Exit";
            this.exitStrMenu.Click += new System.EventHandler(this.exitStrMenu_Click);
            // 
            // masterWatchStrMenu
            // 
            this.masterWatchStrMenu.Name = "masterWatchStrMenu";
            this.masterWatchStrMenu.Size = new System.Drawing.Size(199, 22);
            this.masterWatchStrMenu.Text = "Master Watch";
            this.masterWatchStrMenu.Click += new System.EventHandler(this.masterWatchStrMenu_Click_1);
            // 
            // masterWatchTypeStrMenu
            // 
            this.masterWatchTypeStrMenu.Name = "masterWatchTypeStrMenu";
            this.masterWatchTypeStrMenu.Size = new System.Drawing.Size(199, 22);
            this.masterWatchTypeStrMenu.Text = "Master Watch Type";
            this.masterWatchTypeStrMenu.Click += new System.EventHandler(this.masterWatchTypeStrMenu_Click);
            // 
            // masterUserStrMenu
            // 
            this.masterUserStrMenu.Name = "masterUserStrMenu";
            this.masterUserStrMenu.Size = new System.Drawing.Size(199, 22);
            this.masterUserStrMenu.Text = "Master User ";
            this.masterUserStrMenu.Click += new System.EventHandler(this.masterUserStrMenu_Click_1);
            // 
            // viewAllTransStrMenu
            // 
            this.viewAllTransStrMenu.Name = "viewAllTransStrMenu";
            this.viewAllTransStrMenu.Size = new System.Drawing.Size(199, 22);
            this.viewAllTransStrMenu.Text = "View All Transaction";
            this.viewAllTransStrMenu.Click += new System.EventHandler(this.viewAllTransStrMenu_Click);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekLab.Properties.Resources._7e51ca78b0fba82425a4aa1d21972c97;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 447);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFormAdmin";
            this.Text = "MainFormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordStrMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutStrMenu;
        private System.Windows.Forms.ToolStripMenuItem exitStrMenu;
        private System.Windows.Forms.ToolStripMenuItem masterWatchStrMenu;
        private System.Windows.Forms.ToolStripMenuItem masterWatchTypeStrMenu;
        private System.Windows.Forms.ToolStripMenuItem masterUserStrMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAllTransStrMenu;
    }
}