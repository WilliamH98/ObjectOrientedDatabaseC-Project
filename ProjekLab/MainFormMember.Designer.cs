namespace ProjekLab
{
    partial class MainFormMember
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
            this.logoutStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buyWatchStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryStrMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutStrMenu
            // 
            this.logoutStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutStrMenu.Name = "logoutStrMenu";
            this.logoutStrMenu.Size = new System.Drawing.Size(183, 22);
            this.logoutStrMenu.Text = "Log Out";
            this.logoutStrMenu.Click += new System.EventHandler(this.logoutStrMenu_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStrMenu
            // 
            this.fileStrMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePassStrMenu,
            this.logoutStrMenu,
            this.exitStrMenu,
            this.buyWatchStrMenu,
            this.viewHistoryStrMenu});
            this.fileStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileStrMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileStrMenu.Name = "fileStrMenu";
            this.fileStrMenu.Size = new System.Drawing.Size(41, 21);
            this.fileStrMenu.Text = "File";
            // 
            // changePassStrMenu
            // 
            this.changePassStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassStrMenu.Name = "changePassStrMenu";
            this.changePassStrMenu.Size = new System.Drawing.Size(183, 22);
            this.changePassStrMenu.Text = "Change Password";
            this.changePassStrMenu.Click += new System.EventHandler(this.changePassStrMenu_Click);
            // 
            // exitStrMenu
            // 
            this.exitStrMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitStrMenu.Name = "exitStrMenu";
            this.exitStrMenu.Size = new System.Drawing.Size(183, 22);
            this.exitStrMenu.Text = "Exit";
            this.exitStrMenu.Click += new System.EventHandler(this.exitStrMenu_Click);
            // 
            // buyWatchStrMenu
            // 
            this.buyWatchStrMenu.Name = "buyWatchStrMenu";
            this.buyWatchStrMenu.Size = new System.Drawing.Size(183, 22);
            this.buyWatchStrMenu.Text = "Buy Watch ";
            this.buyWatchStrMenu.Click += new System.EventHandler(this.buyWatchStrMenu_Click);
            // 
            // viewHistoryStrMenu
            // 
            this.viewHistoryStrMenu.Name = "viewHistoryStrMenu";
            this.viewHistoryStrMenu.Size = new System.Drawing.Size(183, 22);
            this.viewHistoryStrMenu.Text = "View History";
            this.viewHistoryStrMenu.Click += new System.EventHandler(this.viewHistoryStrMenu_Click);
            // 
            // MainFormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjekLab.Properties.Resources._7e51ca78b0fba82425a4aa1d21972c97;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 447);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainFormMember";
            this.Text = "MainFormMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem logoutStrMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStrMenu;
        private System.Windows.Forms.ToolStripMenuItem changePassStrMenu;
        private System.Windows.Forms.ToolStripMenuItem exitStrMenu;
        private System.Windows.Forms.ToolStripMenuItem buyWatchStrMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryStrMenu;
    }
}