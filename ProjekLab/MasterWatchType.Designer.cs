namespace ProjekLab
{
    partial class MasterWatchType
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.masterWatchTypeLbl = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.watchNameTxt = new System.Windows.Forms.TextBox();
            this.watchIdTxt = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.watchDetailGb = new System.Windows.Forms.GroupBox();
            this.descriptionRtxt = new System.Windows.Forms.RichTextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.watchTypeNameLbl = new System.Windows.Forms.Label();
            this.watchTypeIdLbl = new System.Windows.Forms.Label();
            this.watchTypeDgv = new System.Windows.Forms.DataGridView();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.watchDetailGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTypeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(123, 480);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 27);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // masterWatchTypeLbl
            // 
            this.masterWatchTypeLbl.AutoSize = true;
            this.masterWatchTypeLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterWatchTypeLbl.Location = new System.Drawing.Point(142, 9);
            this.masterWatchTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.masterWatchTypeLbl.Name = "masterWatchTypeLbl";
            this.masterWatchTypeLbl.Size = new System.Drawing.Size(281, 36);
            this.masterWatchTypeLbl.TabIndex = 9;
            this.masterWatchTypeLbl.Text = "Master Watch Type";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(204, 480);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Location = new System.Drawing.Point(389, 480);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 27);
            this.submitBtn.TabIndex = 15;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // watchNameTxt
            // 
            this.watchNameTxt.Enabled = false;
            this.watchNameTxt.Location = new System.Drawing.Point(241, 77);
            this.watchNameTxt.Name = "watchNameTxt";
            this.watchNameTxt.Size = new System.Drawing.Size(276, 26);
            this.watchNameTxt.TabIndex = 6;
            // 
            // watchIdTxt
            // 
            this.watchIdTxt.Enabled = false;
            this.watchIdTxt.Location = new System.Drawing.Point(241, 44);
            this.watchIdTxt.Name = "watchIdTxt";
            this.watchIdTxt.Size = new System.Drawing.Size(276, 26);
            this.watchIdTxt.TabIndex = 5;
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(42, 480);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 27);
            this.insertBtn.TabIndex = 12;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // watchDetailGb
            // 
            this.watchDetailGb.Controls.Add(this.descriptionRtxt);
            this.watchDetailGb.Controls.Add(this.watchNameTxt);
            this.watchDetailGb.Controls.Add(this.watchIdTxt);
            this.watchDetailGb.Controls.Add(this.descriptionLbl);
            this.watchDetailGb.Controls.Add(this.watchTypeNameLbl);
            this.watchDetailGb.Controls.Add(this.watchTypeIdLbl);
            this.watchDetailGb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDetailGb.Location = new System.Drawing.Point(22, 212);
            this.watchDetailGb.Name = "watchDetailGb";
            this.watchDetailGb.Size = new System.Drawing.Size(523, 246);
            this.watchDetailGb.TabIndex = 11;
            this.watchDetailGb.TabStop = false;
            this.watchDetailGb.Text = "Watch Detail ";
            // 
            // descriptionRtxt
            // 
            this.descriptionRtxt.Enabled = false;
            this.descriptionRtxt.Location = new System.Drawing.Point(241, 111);
            this.descriptionRtxt.Name = "descriptionRtxt";
            this.descriptionRtxt.Size = new System.Drawing.Size(276, 117);
            this.descriptionRtxt.TabIndex = 7;
            this.descriptionRtxt.Text = "";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(7, 114);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(78, 19);
            this.descriptionLbl.TabIndex = 3;
            this.descriptionLbl.Text = "Description";
            // 
            // watchTypeNameLbl
            // 
            this.watchTypeNameLbl.AutoSize = true;
            this.watchTypeNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchTypeNameLbl.Location = new System.Drawing.Point(7, 80);
            this.watchTypeNameLbl.Name = "watchTypeNameLbl";
            this.watchTypeNameLbl.Size = new System.Drawing.Size(123, 19);
            this.watchTypeNameLbl.TabIndex = 1;
            this.watchTypeNameLbl.Text = "Watch Type Name";
            // 
            // watchTypeIdLbl
            // 
            this.watchTypeIdLbl.AutoSize = true;
            this.watchTypeIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchTypeIdLbl.Location = new System.Drawing.Point(7, 47);
            this.watchTypeIdLbl.Name = "watchTypeIdLbl";
            this.watchTypeIdLbl.Size = new System.Drawing.Size(99, 19);
            this.watchTypeIdLbl.TabIndex = 0;
            this.watchTypeIdLbl.Text = "Watch Type Id";
            // 
            // watchTypeDgv
            // 
            this.watchTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchTypeDgv.Location = new System.Drawing.Point(21, 56);
            this.watchTypeDgv.Name = "watchTypeDgv";
            this.watchTypeDgv.Size = new System.Drawing.Size(524, 149);
            this.watchTypeDgv.TabIndex = 10;
            this.watchTypeDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.watchTypeDgv_CellClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelBtn.Location = new System.Drawing.Point(470, 480);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 27);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 35);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(379, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 35);
            this.panel2.TabIndex = 20;
            // 
            // MasterWatchType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(568, 519);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.masterWatchTypeLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.watchDetailGb);
            this.Controls.Add(this.watchTypeDgv);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MasterWatchType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterWatchType";
            this.watchDetailGb.ResumeLayout(false);
            this.watchDetailGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchTypeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label masterWatchTypeLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox watchNameTxt;
        private System.Windows.Forms.TextBox watchIdTxt;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.GroupBox watchDetailGb;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label watchTypeNameLbl;
        private System.Windows.Forms.Label watchTypeIdLbl;
        private System.Windows.Forms.DataGridView watchTypeDgv;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RichTextBox descriptionRtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}