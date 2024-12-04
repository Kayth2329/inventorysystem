namespace Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds
{
    partial class Adminform
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCategoryfilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteitem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateitem = new System.Windows.Forms.Button();
            this.txtProdname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1169, 100);
            this.panel1.TabIndex = 5;
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
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORY,
            this.PRODUCT_NAME,
            this.PRICE,
            this.QUANTITY});
            this.dgvMenu.Location = new System.Drawing.Point(505, 219);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(639, 467);
            this.dgvMenu.TabIndex = 25;
            this.dgvMenu.SelectionChanged += new System.EventHandler(this.dgvMenu_SelectionChanged);
            // 
            // CATEGORY
            // 
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.MinimumWidth = 6;
            this.CATEGORY.Name = "CATEGORY";
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.HeaderText = "PRODUCT_NAME";
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
            this.cmbCategoryfilter.Location = new System.Drawing.Point(918, 170);
            this.cmbCategoryfilter.Name = "cmbCategoryfilter";
            this.cmbCategoryfilter.Size = new System.Drawing.Size(226, 24);
            this.cmbCategoryfilter.TabIndex = 27;
            this.cmbCategoryfilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryfilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRODUCT_NAME";
            // 
            // btnDeleteitem
            // 
            this.btnDeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteitem.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteitem.Location = new System.Drawing.Point(341, 523);
            this.btnDeleteitem.Name = "btnDeleteitem";
            this.btnDeleteitem.Size = new System.Drawing.Size(115, 48);
            this.btnDeleteitem.TabIndex = 23;
            this.btnDeleteitem.Text = "DELETE";
            this.btnDeleteitem.UseVisualStyleBackColor = true;
            this.btnDeleteitem.Click += new System.EventHandler(this.btnDeleteitem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "QUANTITY";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(225, 402);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(179, 22);
            this.txtQty.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(225, 292);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // btnUpdateitem
            // 
            this.btnUpdateitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateitem.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateitem.Location = new System.Drawing.Point(219, 523);
            this.btnUpdateitem.Name = "btnUpdateitem";
            this.btnUpdateitem.Size = new System.Drawing.Size(115, 48);
            this.btnUpdateitem.TabIndex = 22;
            this.btnUpdateitem.Text = "TOP UP";
            this.btnUpdateitem.UseVisualStyleBackColor = true;
            this.btnUpdateitem.Click += new System.EventHandler(this.btnUpdateitem_Click);
            // 
            // txtProdname
            // 
            this.txtProdname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtProdname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdname.Location = new System.Drawing.Point(225, 185);
            this.txtProdname.Name = "txtProdname";
            this.txtProdname.Size = new System.Drawing.Size(179, 22);
            this.txtProdname.TabIndex = 7;
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1169, 734);
            this.Controls.Add(this.cmbCategoryfilter);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnDeleteitem);
            this.Controls.Add(this.btnUpdateitem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminform";
            this.Text = "Adminform";
            this.Load += new System.EventHandler(this.Adminform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.ComboBox cmbCategoryfilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdateitem;
        private System.Windows.Forms.TextBox txtProdname;
    }
}