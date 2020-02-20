namespace ProjekLab
{
    partial class BuyWatchForm
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
            this.buyWatchLbl = new System.Windows.Forms.Label();
            this.quantityNud = new System.Windows.Forms.NumericUpDown();
            this.watchPriceTxt = new System.Windows.Forms.TextBox();
            this.watchNameTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.watchIdTxt = new System.Windows.Forms.TextBox();
            this.watchDetailGb = new System.Windows.Forms.GroupBox();
            this.watchPriceLbl = new System.Windows.Forms.Label();
            this.watchTypeLbl = new System.Windows.Forms.Label();
            this.watchNameLbl = new System.Windows.Forms.Label();
            this.watchIdLbl = new System.Windows.Forms.Label();
            this.watchDgv = new System.Windows.Forms.DataGridView();
            this.buyBtn = new System.Windows.Forms.Button();
            this.watchTypeTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNud)).BeginInit();
            this.watchDetailGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buyWatchLbl
            // 
            this.buyWatchLbl.AutoSize = true;
            this.buyWatchLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyWatchLbl.Location = new System.Drawing.Point(190, 9);
            this.buyWatchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyWatchLbl.Name = "buyWatchLbl";
            this.buyWatchLbl.Size = new System.Drawing.Size(166, 36);
            this.buyWatchLbl.TabIndex = 21;
            this.buyWatchLbl.Text = "Buy Watch";
            // 
            // quantityNud
            // 
            this.quantityNud.AccessibleName = "quantityNud";
            this.quantityNud.Enabled = false;
            this.quantityNud.Location = new System.Drawing.Point(241, 181);
            this.quantityNud.Name = "quantityNud";
            this.quantityNud.Size = new System.Drawing.Size(276, 26);
            this.quantityNud.TabIndex = 10;
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
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(7, 183);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(60, 19);
            this.quantityLbl.TabIndex = 4;
            this.quantityLbl.Text = "Quantity";
            // 
            // watchIdTxt
            // 
            this.watchIdTxt.Enabled = false;
            this.watchIdTxt.Location = new System.Drawing.Point(241, 44);
            this.watchIdTxt.Name = "watchIdTxt";
            this.watchIdTxt.Size = new System.Drawing.Size(276, 26);
            this.watchIdTxt.TabIndex = 5;
            // 
            // watchDetailGb
            // 
            this.watchDetailGb.Controls.Add(this.watchTypeTxt);
            this.watchDetailGb.Controls.Add(this.quantityNud);
            this.watchDetailGb.Controls.Add(this.watchPriceTxt);
            this.watchDetailGb.Controls.Add(this.watchNameTxt);
            this.watchDetailGb.Controls.Add(this.watchIdTxt);
            this.watchDetailGb.Controls.Add(this.quantityLbl);
            this.watchDetailGb.Controls.Add(this.watchPriceLbl);
            this.watchDetailGb.Controls.Add(this.watchTypeLbl);
            this.watchDetailGb.Controls.Add(this.watchNameLbl);
            this.watchDetailGb.Controls.Add(this.watchIdLbl);
            this.watchDetailGb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDetailGb.Location = new System.Drawing.Point(12, 216);
            this.watchDetailGb.Name = "watchDetailGb";
            this.watchDetailGb.Size = new System.Drawing.Size(523, 215);
            this.watchDetailGb.TabIndex = 23;
            this.watchDetailGb.TabStop = false;
            this.watchDetailGb.Text = "Watch Detail ";
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
            // watchDgv
            // 
            this.watchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchDgv.Location = new System.Drawing.Point(11, 60);
            this.watchDgv.Name = "watchDgv";
            this.watchDgv.Size = new System.Drawing.Size(524, 149);
            this.watchDgv.TabIndex = 22;
            this.watchDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.watchDgv_CellClick);
            // 
            // buyBtn
            // 
            this.buyBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Location = new System.Drawing.Point(219, 442);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(109, 27);
            this.buyBtn.TabIndex = 24;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // watchTypeTxt
            // 
            this.watchTypeTxt.Enabled = false;
            this.watchTypeTxt.Location = new System.Drawing.Point(241, 111);
            this.watchTypeTxt.Name = "watchTypeTxt";
            this.watchTypeTxt.Size = new System.Drawing.Size(276, 26);
            this.watchTypeTxt.TabIndex = 11;
            // 
            // BuyWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(548, 475);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.buyWatchLbl);
            this.Controls.Add(this.watchDetailGb);
            this.Controls.Add(this.watchDgv);
            this.Name = "BuyWatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyWatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNud)).EndInit();
            this.watchDetailGb.ResumeLayout(false);
            this.watchDetailGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buyWatchLbl;
        private System.Windows.Forms.NumericUpDown quantityNud;
        private System.Windows.Forms.TextBox watchPriceTxt;
        private System.Windows.Forms.TextBox watchNameTxt;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox watchIdTxt;
        private System.Windows.Forms.GroupBox watchDetailGb;
        private System.Windows.Forms.Label watchPriceLbl;
        private System.Windows.Forms.Label watchTypeLbl;
        private System.Windows.Forms.Label watchNameLbl;
        private System.Windows.Forms.Label watchIdLbl;
        private System.Windows.Forms.DataGridView watchDgv;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.TextBox watchTypeTxt;

    }
}