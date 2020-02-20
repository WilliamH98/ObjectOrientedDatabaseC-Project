namespace ProjekLab
{
    partial class Master_Watch_Form
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
            this.masterWatchLbl = new System.Windows.Forms.Label();
            this.watchDgv = new System.Windows.Forms.DataGridView();
            this.watchDetailGb = new System.Windows.Forms.GroupBox();
            this.watchTypeCb = new System.Windows.Forms.ComboBox();
            this.stockNud = new System.Windows.Forms.NumericUpDown();
            this.watchPriceTxt = new System.Windows.Forms.TextBox();
            this.watchNameTxt = new System.Windows.Forms.TextBox();
            this.watchIdTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.watchPriceLbl = new System.Windows.Forms.Label();
            this.watchTypeLbl = new System.Windows.Forms.Label();
            this.watchNameLbl = new System.Windows.Forms.Label();
            this.watchIdLbl = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.watchDgv)).BeginInit();
            this.watchDetailGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNud)).BeginInit();
            this.SuspendLayout();
            // 
            // masterWatchLbl
            // 
            this.masterWatchLbl.AutoSize = true;
            this.masterWatchLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterWatchLbl.Location = new System.Drawing.Point(165, 9);
            this.masterWatchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.masterWatchLbl.Name = "masterWatchLbl";
            this.masterWatchLbl.Size = new System.Drawing.Size(208, 36);
            this.masterWatchLbl.TabIndex = 1;
            this.masterWatchLbl.Text = "Master Watch";
            // 
            // watchDgv
            // 
            this.watchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchDgv.Location = new System.Drawing.Point(12, 63);
            this.watchDgv.Name = "watchDgv";
            this.watchDgv.Size = new System.Drawing.Size(524, 149);
            this.watchDgv.TabIndex = 2;
            this.watchDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.watchDgv_CellClick);
            // 
            // watchDetailGb
            // 
            this.watchDetailGb.Controls.Add(this.watchTypeCb);
            this.watchDetailGb.Controls.Add(this.stockNud);
            this.watchDetailGb.Controls.Add(this.watchPriceTxt);
            this.watchDetailGb.Controls.Add(this.watchNameTxt);
            this.watchDetailGb.Controls.Add(this.watchIdTxt);
            this.watchDetailGb.Controls.Add(this.stockLbl);
            this.watchDetailGb.Controls.Add(this.watchPriceLbl);
            this.watchDetailGb.Controls.Add(this.watchTypeLbl);
            this.watchDetailGb.Controls.Add(this.watchNameLbl);
            this.watchDetailGb.Controls.Add(this.watchIdLbl);
            this.watchDetailGb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDetailGb.Location = new System.Drawing.Point(13, 219);
            this.watchDetailGb.Name = "watchDetailGb";
            this.watchDetailGb.Size = new System.Drawing.Size(523, 215);
            this.watchDetailGb.TabIndex = 3;
            this.watchDetailGb.TabStop = false;
            this.watchDetailGb.Text = "Watch Detail ";
            this.watchDetailGb.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // watchTypeCb
            // 
            this.watchTypeCb.Enabled = false;
            this.watchTypeCb.FormattingEnabled = true;
            this.watchTypeCb.Location = new System.Drawing.Point(241, 111);
            this.watchTypeCb.Name = "watchTypeCb";
            this.watchTypeCb.Size = new System.Drawing.Size(276, 27);
            this.watchTypeCb.TabIndex = 11;
            // 
            // stockNud
            // 
            this.stockNud.AccessibleName = "stockNud";
            this.stockNud.Enabled = false;
            this.stockNud.Location = new System.Drawing.Point(241, 181);
            this.stockNud.Name = "stockNud";
            this.stockNud.Size = new System.Drawing.Size(276, 26);
            this.stockNud.TabIndex = 10;
            // 
            // watchPriceTxt
            // 
            this.watchPriceTxt.Enabled = false;
            this.watchPriceTxt.Location = new System.Drawing.Point(241, 147);
            this.watchPriceTxt.Name = "watchPriceTxt";
            this.watchPriceTxt.Size = new System.Drawing.Size(276, 26);
            this.watchPriceTxt.TabIndex = 8;
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
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(7, 183);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(45, 19);
            this.stockLbl.TabIndex = 4;
            this.stockLbl.Text = "Stock";
            // 
            // watchPriceLbl
            // 
            this.watchPriceLbl.AutoSize = true;
            this.watchPriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchPriceLbl.Location = new System.Drawing.Point(7, 150);
            this.watchPriceLbl.Name = "watchPriceLbl";
            this.watchPriceLbl.Size = new System.Drawing.Size(83, 19);
            this.watchPriceLbl.TabIndex = 3;
            this.watchPriceLbl.Text = "Watch Price";
            // 
            // watchTypeLbl
            // 
            this.watchTypeLbl.AutoSize = true;
            this.watchTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchTypeLbl.Location = new System.Drawing.Point(7, 114);
            this.watchTypeLbl.Name = "watchTypeLbl";
            this.watchTypeLbl.Size = new System.Drawing.Size(82, 19);
            this.watchTypeLbl.TabIndex = 2;
            this.watchTypeLbl.Text = "Watch Type";
            // 
            // watchNameLbl
            // 
            this.watchNameLbl.AutoSize = true;
            this.watchNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchNameLbl.Location = new System.Drawing.Point(7, 80);
            this.watchNameLbl.Name = "watchNameLbl";
            this.watchNameLbl.Size = new System.Drawing.Size(89, 19);
            this.watchNameLbl.TabIndex = 1;
            this.watchNameLbl.Text = "Watch Name";
            this.watchNameLbl.Click += new System.EventHandler(this.watchNameLbl_Click);
            // 
            // watchIdLbl
            // 
            this.watchIdLbl.AutoSize = true;
            this.watchIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchIdLbl.Location = new System.Drawing.Point(7, 47);
            this.watchIdLbl.Name = "watchIdLbl";
            this.watchIdLbl.Size = new System.Drawing.Size(65, 19);
            this.watchIdLbl.TabIndex = 0;
            this.watchIdLbl.Text = "Watch Id";
            this.watchIdLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(33, 440);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 27);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(114, 440);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 27);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(195, 440);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.submitBtn.Location = new System.Drawing.Point(380, 440);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 27);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelBtn.Location = new System.Drawing.Point(461, 440);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 27);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 35);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(370, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 35);
            this.panel2.TabIndex = 20;
            // 
            // Master_Watch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(548, 475);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.watchDetailGb);
            this.Controls.Add(this.watchDgv);
            this.Controls.Add(this.masterWatchLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Master_Watch_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterWatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.watchDgv)).EndInit();
            this.watchDetailGb.ResumeLayout(false);
            this.watchDetailGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masterWatchLbl;
        private System.Windows.Forms.DataGridView watchDgv;
        private System.Windows.Forms.GroupBox watchDetailGb;
        private System.Windows.Forms.Label watchIdLbl;
        private System.Windows.Forms.TextBox watchNameTxt;
        private System.Windows.Forms.TextBox watchIdTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label watchPriceLbl;
        private System.Windows.Forms.Label watchTypeLbl;
        private System.Windows.Forms.Label watchNameLbl;
        private System.Windows.Forms.TextBox watchPriceTxt;
        private System.Windows.Forms.NumericUpDown stockNud;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox watchTypeCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}