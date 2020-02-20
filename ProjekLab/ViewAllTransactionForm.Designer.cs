namespace ProjekLab
{
    partial class ViewAllTransactionForm
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
            this.viewAllTransactionLbl = new System.Windows.Forms.Label();
            this.salesTransactionDgv = new System.Windows.Forms.DataGridView();
            this.salesTransDetailGb = new System.Windows.Forms.GroupBox();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.fullnameLbl = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.watchTypeTxt = new System.Windows.Forms.TextBox();
            this.watchPriceTxt = new System.Windows.Forms.TextBox();
            this.watchNameTxt = new System.Windows.Forms.TextBox();
            this.watchIdTxt = new System.Windows.Forms.TextBox();
            this.watchPriceLbl = new System.Windows.Forms.Label();
            this.watchTypeLbl = new System.Windows.Forms.Label();
            this.watchNameLbl = new System.Windows.Forms.Label();
            this.watchIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionDgv)).BeginInit();
            this.salesTransDetailGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewAllTransactionLbl
            // 
            this.viewAllTransactionLbl.AutoSize = true;
            this.viewAllTransactionLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllTransactionLbl.Location = new System.Drawing.Point(123, 9);
            this.viewAllTransactionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewAllTransactionLbl.Name = "viewAllTransactionLbl";
            this.viewAllTransactionLbl.Size = new System.Drawing.Size(300, 36);
            this.viewAllTransactionLbl.TabIndex = 23;
            this.viewAllTransactionLbl.Text = "View All Transaction";
            // 
            // salesTransactionDgv
            // 
            this.salesTransactionDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesTransactionDgv.Location = new System.Drawing.Point(12, 64);
            this.salesTransactionDgv.Name = "salesTransactionDgv";
            this.salesTransactionDgv.Size = new System.Drawing.Size(524, 149);
            this.salesTransactionDgv.TabIndex = 24;
            this.salesTransactionDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesTransactionDgv_CellClick);
            // 
            // salesTransDetailGb
            // 
            this.salesTransDetailGb.Controls.Add(this.fullnameTxt);
            this.salesTransDetailGb.Controls.Add(this.fullnameLbl);
            this.salesTransDetailGb.Controls.Add(this.quantityTxt);
            this.salesTransDetailGb.Controls.Add(this.stockLbl);
            this.salesTransDetailGb.Controls.Add(this.totalPriceTxt);
            this.salesTransDetailGb.Controls.Add(this.totalPriceLbl);
            this.salesTransDetailGb.Controls.Add(this.watchTypeTxt);
            this.salesTransDetailGb.Controls.Add(this.watchPriceTxt);
            this.salesTransDetailGb.Controls.Add(this.watchNameTxt);
            this.salesTransDetailGb.Controls.Add(this.watchIdTxt);
            this.salesTransDetailGb.Controls.Add(this.watchPriceLbl);
            this.salesTransDetailGb.Controls.Add(this.watchTypeLbl);
            this.salesTransDetailGb.Controls.Add(this.watchNameLbl);
            this.salesTransDetailGb.Controls.Add(this.watchIdLbl);
            this.salesTransDetailGb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTransDetailGb.Location = new System.Drawing.Point(13, 235);
            this.salesTransDetailGb.Name = "salesTransDetailGb";
            this.salesTransDetailGb.Size = new System.Drawing.Size(523, 278);
            this.salesTransDetailGb.TabIndex = 28;
            this.salesTransDetailGb.TabStop = false;
            this.salesTransDetailGb.Text = "Sales Transaction Detail";
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Enabled = false;
            this.fullnameTxt.Location = new System.Drawing.Point(241, 36);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(276, 26);
            this.fullnameTxt.TabIndex = 18;
            // 
            // fullnameLbl
            // 
            this.fullnameLbl.AutoSize = true;
            this.fullnameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLbl.Location = new System.Drawing.Point(7, 39);
            this.fullnameLbl.Name = "fullnameLbl";
            this.fullnameLbl.Size = new System.Drawing.Size(63, 19);
            this.fullnameLbl.TabIndex = 17;
            this.fullnameLbl.Text = "Fullname";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Location = new System.Drawing.Point(241, 170);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(276, 26);
            this.quantityTxt.TabIndex = 16;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(7, 173);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(60, 19);
            this.stockLbl.TabIndex = 15;
            this.stockLbl.Text = "Quantity";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.Enabled = false;
            this.totalPriceTxt.Location = new System.Drawing.Point(241, 240);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(276, 26);
            this.totalPriceTxt.TabIndex = 14;
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.Location = new System.Drawing.Point(7, 243);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(74, 19);
            this.totalPriceLbl.TabIndex = 13;
            this.totalPriceLbl.Text = "Total Price";
            // 
            // watchTypeTxt
            // 
            this.watchTypeTxt.Enabled = false;
            this.watchTypeTxt.Location = new System.Drawing.Point(241, 137);
            this.watchTypeTxt.Name = "watchTypeTxt";
            this.watchTypeTxt.Size = new System.Drawing.Size(276, 26);
            this.watchTypeTxt.TabIndex = 11;
            // 
            // watchPriceTxt
            // 
            this.watchPriceTxt.Enabled = false;
            this.watchPriceTxt.Location = new System.Drawing.Point(241, 205);
            this.watchPriceTxt.Name = "watchPriceTxt";
            this.watchPriceTxt.Size = new System.Drawing.Size(276, 26);
            this.watchPriceTxt.TabIndex = 8;
            // 
            // watchNameTxt
            // 
            this.watchNameTxt.Enabled = false;
            this.watchNameTxt.Location = new System.Drawing.Point(241, 103);
            this.watchNameTxt.Name = "watchNameTxt";
            this.watchNameTxt.Size = new System.Drawing.Size(276, 26);
            this.watchNameTxt.TabIndex = 6;
            // 
            // watchIdTxt
            // 
            this.watchIdTxt.Enabled = false;
            this.watchIdTxt.Location = new System.Drawing.Point(241, 70);
            this.watchIdTxt.Name = "watchIdTxt";
            this.watchIdTxt.Size = new System.Drawing.Size(276, 26);
            this.watchIdTxt.TabIndex = 5;
            // 
            // watchPriceLbl
            // 
            this.watchPriceLbl.AutoSize = true;
            this.watchPriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchPriceLbl.Location = new System.Drawing.Point(7, 208);
            this.watchPriceLbl.Name = "watchPriceLbl";
            this.watchPriceLbl.Size = new System.Drawing.Size(83, 19);
            this.watchPriceLbl.TabIndex = 3;
            this.watchPriceLbl.Text = "Watch Price";
            // 
            // watchTypeLbl
            // 
            this.watchTypeLbl.AutoSize = true;
            this.watchTypeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchTypeLbl.Location = new System.Drawing.Point(7, 140);
            this.watchTypeLbl.Name = "watchTypeLbl";
            this.watchTypeLbl.Size = new System.Drawing.Size(82, 19);
            this.watchTypeLbl.TabIndex = 2;
            this.watchTypeLbl.Text = "Watch Type";
            // 
            // watchNameLbl
            // 
            this.watchNameLbl.AutoSize = true;
            this.watchNameLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchNameLbl.Location = new System.Drawing.Point(7, 106);
            this.watchNameLbl.Name = "watchNameLbl";
            this.watchNameLbl.Size = new System.Drawing.Size(89, 19);
            this.watchNameLbl.TabIndex = 1;
            this.watchNameLbl.Text = "Watch Name";
            // 
            // watchIdLbl
            // 
            this.watchIdLbl.AutoSize = true;
            this.watchIdLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchIdLbl.Location = new System.Drawing.Point(7, 73);
            this.watchIdLbl.Name = "watchIdLbl";
            this.watchIdLbl.Size = new System.Drawing.Size(65, 19);
            this.watchIdLbl.TabIndex = 0;
            this.watchIdLbl.Text = "Watch Id";
            // 
            // ViewAllTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(548, 525);
            this.Controls.Add(this.salesTransDetailGb);
            this.Controls.Add(this.salesTransactionDgv);
            this.Controls.Add(this.viewAllTransactionLbl);
            this.Name = "ViewAllTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionDgv)).EndInit();
            this.salesTransDetailGb.ResumeLayout(false);
            this.salesTransDetailGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewAllTransactionLbl;
        private System.Windows.Forms.DataGridView salesTransactionDgv;
        private System.Windows.Forms.GroupBox salesTransDetailGb;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.Label fullnameLbl;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.TextBox watchTypeTxt;
        private System.Windows.Forms.TextBox watchPriceTxt;
        private System.Windows.Forms.TextBox watchNameTxt;
        private System.Windows.Forms.TextBox watchIdTxt;
        private System.Windows.Forms.Label watchPriceLbl;
        private System.Windows.Forms.Label watchTypeLbl;
        private System.Windows.Forms.Label watchNameLbl;
        private System.Windows.Forms.Label watchIdLbl;
    }
}