namespace Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds
{
    partial class Userform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdname1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.DataGridView();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2 = new System.Windows.Forms.DataGridView();
            this.PRODUCT_NAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComputechange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCategoryfilter = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnDeleteitem = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateitem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 100);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1134, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 62);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adding Stocks of Dry Goods in \r\n                Mcdonalds";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds.Properties.Resources.b76d5aa4_400c_4e09_b76f_b50707750314;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrice1
            // 
            this.txtPrice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPrice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice1.Location = new System.Drawing.Point(519, 196);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(104, 22);
            this.txtPrice1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "PRICE";
            // 
            // txtQty1
            // 
            this.txtQty1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty1.Location = new System.Drawing.Point(844, 196);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(177, 22);
            this.txtQty1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "QUANTITY";
            // 
            // txtProdname1
            // 
            this.txtProdname1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtProdname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdname1.Location = new System.Drawing.Point(217, 194);
            this.txtProdname1.Name = "txtProdname1";
            this.txtProdname1.Size = new System.Drawing.Size(185, 22);
            this.txtProdname1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCT_NAME";
            // 
            // d1
            // 
            this.d1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORY,
            this.PRODUCT_NAME,
            this.PRICE,
            this.QUANTITY});
            this.d1.Location = new System.Drawing.Point(12, 293);
            this.d1.Name = "d1";
            this.d1.RowHeadersWidth = 51;
            this.d1.RowTemplate.Height = 24;
            this.d1.Size = new System.Drawing.Size(486, 435);
            this.d1.TabIndex = 26;
            this.d1.SelectionChanged += new System.EventHandler(this.d1_SelectionChanged);
            // 
            // CATEGORY
            // 
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.MinimumWidth = 6;
            this.CATEGORY.Name = "CATEGORY";
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.HeaderText = "PROD_NAME";
            this.PRODUCT_NAME.MinimumWidth = 6;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.MinimumWidth = 6;
            this.QUANTITY.Name = "QUANTITY";
            // 
            // d2
            // 
            this.d2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.d2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_NAME1,
            this.PRICE1,
            this.QUANTITY1,
            this.TOTAL});
            this.d2.Location = new System.Drawing.Point(752, 293);
            this.d2.Name = "d2";
            this.d2.RowHeadersWidth = 51;
            this.d2.RowTemplate.Height = 24;
            this.d2.Size = new System.Drawing.Size(497, 247);
            this.d2.TabIndex = 27;
            this.d2.SelectionChanged += new System.EventHandler(this.d2_SelectionChanged);
            // 
            // PRODUCT_NAME1
            // 
            this.PRODUCT_NAME1.HeaderText = "PROD_NAME";
            this.PRODUCT_NAME1.MinimumWidth = 6;
            this.PRODUCT_NAME1.Name = "PRODUCT_NAME1";
            // 
            // PRICE1
            // 
            this.PRICE1.HeaderText = "PRICE";
            this.PRICE1.MinimumWidth = 6;
            this.PRICE1.Name = "PRICE1";
            // 
            // QUANTITY1
            // 
            this.QUANTITY1.HeaderText = "QUANTITY";
            this.QUANTITY1.MinimumWidth = 6;
            this.QUANTITY1.Name = "QUANTITY1";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(759, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "TOTAL";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(896, 613);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(104, 22);
            this.txtAmount.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Bill Amount";
            // 
            // btnComputechange
            // 
            this.btnComputechange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputechange.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputechange.Location = new System.Drawing.Point(1126, 567);
            this.btnComputechange.Name = "btnComputechange";
            this.btnComputechange.Size = new System.Drawing.Size(113, 67);
            this.btnComputechange.TabIndex = 32;
            this.btnComputechange.Text = "COMPUTE \r\nCHANGE";
            this.btnComputechange.UseVisualStyleBackColor = true;
            this.btnComputechange.Click += new System.EventHandler(this.btnComputechange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "CHANGE";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(892, 658);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(111, 22);
            this.lblChange.TabIndex = 34;
            this.lblChange.Text = "your change";
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(896, 713);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(92, 47);
            this.btnDone.TabIndex = 35;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1044, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 47);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCategoryfilter
            // 
            this.cmbCategoryfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmbCategoryfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategoryfilter.FormattingEnabled = true;
            this.cmbCategoryfilter.Items.AddRange(new object[] {
            "CUP",
            "CLAMSHELL",
            "WRAP",
            "CONTAINER",
            "BOX",
            "DISPOSABLE"});
            this.cmbCategoryfilter.Location = new System.Drawing.Point(272, 255);
            this.cmbCategoryfilter.Name = "cmbCategoryfilter";
            this.cmbCategoryfilter.Size = new System.Drawing.Size(226, 24);
            this.cmbCategoryfilter.TabIndex = 37;
            this.cmbCategoryfilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryfilter_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(892, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 22);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "your total";
            // 
            // btnTotal
            // 
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(1014, 568);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(113, 67);
            this.btnTotal.TabIndex = 39;
            this.btnTotal.Text = "COMPUTE \r\nTOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnDeleteitem
            // 
            this.btnDeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteitem.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteitem.Location = new System.Drawing.Point(574, 652);
            this.btnDeleteitem.Name = "btnDeleteitem";
            this.btnDeleteitem.Size = new System.Drawing.Size(115, 48);
            this.btnDeleteitem.TabIndex = 40;
            this.btnDeleteitem.Text = "DELETE";
            this.btnDeleteitem.UseVisualStyleBackColor = true;
            this.btnDeleteitem.Click += new System.EventHandler(this.btnDeleteitem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(541, 412);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 22);
            this.txtPrice.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "PRICE";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(541, 522);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(179, 22);
            this.txtQty.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "QUANTITY";
            // 
            // txtProdname
            // 
            this.txtProdname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtProdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdname.Location = new System.Drawing.Point(541, 305);
            this.txtProdname.Name = "txtProdname";
            this.txtProdname.Size = new System.Drawing.Size(179, 22);
            this.txtProdname.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(550, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "PRODUCT_NAME";
            // 
            // btnUpdateitem
            // 
            this.btnUpdateitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateitem.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateitem.Location = new System.Drawing.Point(572, 598);
            this.btnUpdateitem.Name = "btnUpdateitem";
            this.btnUpdateitem.Size = new System.Drawing.Size(115, 48);
            this.btnUpdateitem.TabIndex = 47;
            this.btnUpdateitem.Text = "UPDATE";
            this.btnUpdateitem.UseVisualStyleBackColor = true;
            this.btnUpdateitem.Click += new System.EventHandler(this.btnUpdateitem_Click);
            // 
            // Userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1261, 803);
            this.Controls.Add(this.btnUpdateitem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProdname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDeleteitem);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbCategoryfilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnComputechange);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdname1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Userform";
            this.Text = "Userform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdname1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView d1;
        private System.Windows.Forms.DataGridView d2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnComputechange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.ComboBox cmbCategoryfilter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button btnDeleteitem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProdname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateitem;
    }
}