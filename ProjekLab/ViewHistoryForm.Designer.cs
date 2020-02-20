namespace ProjekLab
{
    partial class ViewHistoryForm
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
            this.viewHistoryLbl = new System.Windows.Forms.Label();
            this.watchIdLbl = new System.Windows.Forms.Label();
            this.watchNameLbl = new System.Windows.Forms.Label();
            this.watchTypeLbl = new System.Windows.Forms.Label();
            this.watchPriceLbl = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.watchIdTxt = new System.Windows.Forms.TextBox();
            this.watchNameTxt = new System.Windows.Forms.TextBox();
            this.watchPriceTxt = new System.Windows.Forms.TextBox();
            this.watchTypeTxt = new System.Windows.Forms.TextBox();
            this.purchaseDetailGb = new System.Windows.Forms.GroupBox();
            this.transactionDateLbl = new System.Windows.Forms.Label();
            this.transactionDateDP = new System.Windows.Forms.DateTimePicker();
            this.goBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.totalPriceTxt = new System.Windows.Forms.TextBox();
            this.dataGridHeader = new System.Windows.Forms.DataGridView();
            this.headerSalesLbl = new System.Windows.Forms.Label();
            this.detailSalesLbl = new System.Windows.Forms.Label();
            this.dataGridDetail = new System.Windows.Forms.DataGridView();
            this.purchaseDetailGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // viewHistoryLbl
            // 
            this.viewHistoryLbl.AutoSize = true;
            this.viewHistoryLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHistoryLbl.Location = new System.Drawing.Point(130, 9);
            this.viewHistoryLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewHistoryLbl.Name = "viewHistoryLbl";
            this.viewHistoryLbl.Size = new System.Drawing.Size(287, 36);
            this.viewHistoryLbl.TabIndex = 22;
            this.viewHistoryLbl.Text = "History Transaction";
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
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(7, 183);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(60, 19);
            this.stockLbl.TabIndex = 4;
            this.stockLbl.Text = "Quantity";
            // 
            // watchIdTxt
            // 
            this.watchIdTxt.Enabled = false;
            this.watchIdTxt.Location = new System.Drawing.Point(241, 44);
            this.watchIdTxt.Name = "watchIdTxt";
            this.watchIdTxt.Size = new System.Drawing.Size(276, 26);
            this.watchIdTxt.TabIndex = 5;
            // 
            // watchNameTxt
            // 
            this.watchNameTxt.Enabled = false;
            this.watchNameTxt.Location = new System.Drawing.Point(241, 77);
            this.watchNameTxt.Name = "watchNameTxt";
            this.watchNameTxt.Size = new System.Drawing.Size(276, 26);
            this.watchNameTxt.TabIndex = 6;
            // 
            // watchPriceTxt
            // 
            this.watchPriceTxt.Enabled = false;
            this.watchPriceTxt.Location = new System.Drawing.Point(241, 147);
            this.watchPriceTxt.Name = "watchPriceTxt";
            this.watchPriceTxt.Size = new System.Drawing.Size(276, 26);
            this.watchPriceTxt.TabIndex = 8;
            // 
            // watchTypeTxt
            // 
            this.watchTypeTxt.Enabled = false;
            this.watchTypeTxt.Location = new System.Drawing.Point(241, 111);
            this.watchTypeTxt.Name = "watchTypeTxt";
            this.watchTypeTxt.Size = new System.Drawing.Size(276, 26);
            this.watchTypeTxt.TabIndex = 11;
            // 
            // purchaseDetailGb
            // 
            this.purchaseDetailGb.Controls.Add(this.totalPriceTxt);
            this.purchaseDetailGb.Controls.Add(this.totalPriceLbl);
            this.purchaseDetailGb.Controls.Add(this.quantityTxt);
            this.purchaseDetailGb.Controls.Add(this.watchTypeTxt);
            this.purchaseDetailGb.Controls.Add(this.watchPriceTxt);
            this.purchaseDetailGb.Controls.Add(this.watchNameTxt);
            this.purchaseDetailGb.Controls.Add(this.watchIdTxt);
            this.purchaseDetailGb.Controls.Add(this.stockLbl);
            this.purchaseDetailGb.Controls.Add(this.watchPriceLbl);
            this.purchaseDetailGb.Controls.Add(this.watchTypeLbl);
            this.purchaseDetailGb.Controls.Add(this.watchNameLbl);
            this.purchaseDetailGb.Controls.Add(this.watchIdLbl);
            this.purchaseDetailGb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDetailGb.Location = new System.Drawing.Point(13, 443);
            this.purchaseDetailGb.Name = "purchaseDetailGb";
            this.purchaseDetailGb.Size = new System.Drawing.Size(523, 248);
            this.purchaseDetailGb.TabIndex = 27;
            this.purchaseDetailGb.TabStop = false;
            this.purchaseDetailGb.Text = "Purchase Transaction Detail ";
            // 
            // transactionDateLbl
            // 
            this.transactionDateLbl.AutoSize = true;
            this.transactionDateLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateLbl.Location = new System.Drawing.Point(20, 54);
            this.transactionDateLbl.Name = "transactionDateLbl";
            this.transactionDateLbl.Size = new System.Drawing.Size(111, 19);
            this.transactionDateLbl.TabIndex = 12;
            this.transactionDateLbl.Text = "Transaction Date";
            // 
            // transactionDateDP
            // 
            this.transactionDateDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDateDP.Location = new System.Drawing.Point(137, 52);
            this.transactionDateDP.Name = "transactionDateDP";
            this.transactionDateDP.Size = new System.Drawing.Size(259, 20);
            this.transactionDateDP.TabIndex = 29;
            // 
            // goBtn
            // 
            this.goBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(425, 52);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(69, 20);
            this.goBtn.TabIndex = 31;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Location = new System.Drawing.Point(241, 180);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(276, 26);
            this.quantityTxt.TabIndex = 12;
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLbl.Location = new System.Drawing.Point(7, 217);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(74, 19);
            this.totalPriceLbl.TabIndex = 13;
            this.totalPriceLbl.Text = "Total Price";
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.Enabled = false;
            this.totalPriceTxt.Location = new System.Drawing.Point(241, 214);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.Size = new System.Drawing.Size(276, 26);
            this.totalPriceTxt.TabIndex = 14;
            // 
            // dataGridHeader
            // 
            this.dataGridHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHeader.Location = new System.Drawing.Point(24, 98);
            this.dataGridHeader.Name = "dataGridHeader";
            this.dataGridHeader.Size = new System.Drawing.Size(506, 155);
            this.dataGridHeader.TabIndex = 32;
            this.dataGridHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHeader_CellClick);
            // 
            // headerSalesLbl
            // 
            this.headerSalesLbl.AutoSize = true;
            this.headerSalesLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerSalesLbl.Location = new System.Drawing.Point(20, 76);
            this.headerSalesLbl.Name = "headerSalesLbl";
            this.headerSalesLbl.Size = new System.Drawing.Size(163, 19);
            this.headerSalesLbl.TabIndex = 33;
            this.headerSalesLbl.Text = "Header Sales Transaction";
            // 
            // detailSalesLbl
            // 
            this.detailSalesLbl.AutoSize = true;
            this.detailSalesLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailSalesLbl.Location = new System.Drawing.Point(19, 260);
            this.detailSalesLbl.Name = "detailSalesLbl";
            this.detailSalesLbl.Size = new System.Drawing.Size(153, 19);
            this.detailSalesLbl.TabIndex = 35;
            this.detailSalesLbl.Text = "Detail Sales Transaction";
            // 
            // dataGridDetail
            // 
            this.dataGridDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetail.Location = new System.Drawing.Point(23, 282);
            this.dataGridDetail.Name = "dataGridDetail";
            this.dataGridDetail.Size = new System.Drawing.Size(506, 155);
            this.dataGridDetail.TabIndex = 34;
            this.dataGridDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDetail_CellClick);
            // 
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(548, 699);
            this.Controls.Add(this.detailSalesLbl);
            this.Controls.Add(this.dataGridDetail);
            this.Controls.Add(this.headerSalesLbl);
            this.Controls.Add(this.dataGridHeader);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.transactionDateDP);
            this.Controls.Add(this.transactionDateLbl);
            this.Controls.Add(this.purchaseDetailGb);
            this.Controls.Add(this.viewHistoryLbl);
            this.Name = "ViewHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHistoryForm";
            this.purchaseDetailGb.ResumeLayout(false);
            this.purchaseDetailGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewHistoryLbl;
        private System.Windows.Forms.Label watchIdLbl;
        private System.Windows.Forms.Label watchNameLbl;
        private System.Windows.Forms.Label watchTypeLbl;
        private System.Windows.Forms.Label watchPriceLbl;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.TextBox watchIdTxt;
        private System.Windows.Forms.TextBox watchNameTxt;
        private System.Windows.Forms.TextBox watchPriceTxt;
        private System.Windows.Forms.TextBox watchTypeTxt;
        private System.Windows.Forms.GroupBox purchaseDetailGb;
        private System.Windows.Forms.Label transactionDateLbl;
        private System.Windows.Forms.DateTimePicker transactionDateDP;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.TextBox totalPriceTxt;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.DataGridView dataGridHeader;
        private System.Windows.Forms.Label headerSalesLbl;
        private System.Windows.Forms.Label detailSalesLbl;
        private System.Windows.Forms.DataGridView dataGridDetail;
    }
}