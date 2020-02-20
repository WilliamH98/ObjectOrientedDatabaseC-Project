namespace ProjekLab
{
    partial class ChangePasswordForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.oldPassTxt = new System.Windows.Forms.TextBox();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.oldPasswordLbl = new System.Windows.Forms.Label();
            this.changePassLbl = new System.Windows.Forms.Label();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.confirmNewPassLbl = new System.Windows.Forms.Label();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(223, 264);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(223, 228);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 12;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // oldPassTxt
            // 
            this.oldPassTxt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.oldPassTxt.Location = new System.Drawing.Point(177, 73);
            this.oldPassTxt.Name = "oldPassTxt";
            this.oldPassTxt.Size = new System.Drawing.Size(325, 20);
            this.oldPassTxt.TabIndex = 10;
            this.oldPassTxt.UseSystemPasswordChar = true;
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLbl.Location = new System.Drawing.Point(12, 122);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(103, 19);
            this.newPasswordLbl.TabIndex = 9;
            this.newPasswordLbl.Text = "New Password";
            // 
            // oldPasswordLbl
            // 
            this.oldPasswordLbl.AutoSize = true;
            this.oldPasswordLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLbl.Location = new System.Drawing.Point(12, 72);
            this.oldPasswordLbl.Name = "oldPasswordLbl";
            this.oldPasswordLbl.Size = new System.Drawing.Size(96, 19);
            this.oldPasswordLbl.TabIndex = 8;
            this.oldPasswordLbl.Text = "Old Password";
            // 
            // changePassLbl
            // 
            this.changePassLbl.AutoSize = true;
            this.changePassLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassLbl.Location = new System.Drawing.Point(129, 9);
            this.changePassLbl.Name = "changePassLbl";
            this.changePassLbl.Size = new System.Drawing.Size(259, 36);
            this.changePassLbl.TabIndex = 7;
            this.changePassLbl.Text = "Change Password";
            // 
            // newPassTxt
            // 
            this.newPassTxt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.newPassTxt.Location = new System.Drawing.Point(177, 123);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.Size = new System.Drawing.Size(325, 20);
            this.newPassTxt.TabIndex = 14;
            this.newPassTxt.UseSystemPasswordChar = true;
            // 
            // confirmNewPassLbl
            // 
            this.confirmNewPassLbl.AutoSize = true;
            this.confirmNewPassLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassLbl.Location = new System.Drawing.Point(12, 174);
            this.confirmNewPassLbl.Name = "confirmNewPassLbl";
            this.confirmNewPassLbl.Size = new System.Drawing.Size(156, 19);
            this.confirmNewPassLbl.TabIndex = 15;
            this.confirmNewPassLbl.Text = "Confirm New Password";
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.confirmPassTxt.Location = new System.Drawing.Point(177, 175);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.Size = new System.Drawing.Size(325, 20);
            this.confirmPassTxt.TabIndex = 16;
            this.confirmPassTxt.UseSystemPasswordChar = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(514, 298);
            this.Controls.Add(this.confirmPassTxt);
            this.Controls.Add(this.confirmNewPassLbl);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.oldPassTxt);
            this.Controls.Add(this.newPasswordLbl);
            this.Controls.Add(this.oldPasswordLbl);
            this.Controls.Add(this.changePassLbl);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox oldPassTxt;
        private System.Windows.Forms.Label newPasswordLbl;
        private System.Windows.Forms.Label oldPasswordLbl;
        private System.Windows.Forms.Label changePassLbl;
        private System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.Label confirmNewPassLbl;
        private System.Windows.Forms.TextBox confirmPassTxt;

    }
}