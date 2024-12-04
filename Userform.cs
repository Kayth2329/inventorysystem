using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds
{
    public partial class Userform : Form
    {
        public Userform()
        {
            InitializeComponent();
            d1.Rows.Add("CUP", "12oz ColdCup", "100", "50");
            d1.Rows.Add("CUP", "6oz ColdCup", "80", "50");
            d1.Rows.Add("CUP", "22oz ColdCup", "150", "50");
            d1.Rows.Add("CUP", "62oz PlainCup", "70", "50");
            d1.Rows.Add("WRAP", "Rice Wrap", "120", "30");
            d1.Rows.Add("CLAMSHELL", "Big Mac Clamshell", "200", "20");
            d1.Rows.Add("CLAMSHELL", "McSpaghetti", "200", "50");
            d1.Rows.Add("CLAMSHELL", "1pc Chicken", "200", "50");
            d1.Rows.Add("CLAMSHELL", "2pc Chicken", "210", "50");
            d1.Rows.Add("CONTAINER", "Sundae Container", "150", "30");
            d1.Rows.Add("DISPOSABLE", "Fork", "60", "50");
            d1.Rows.Add("DISPOSABLE", "Spoon", "60", "50");
            d1.Rows.Add("BOX", "McShare", "100", "50");
        }



        private void btnComputechange_Click(object sender, EventArgs e)
        {
            int lblvalue = Convert.ToInt32(lblTotal.Text);
            int txtvalue = Convert.ToInt32(txtAmount.Text);

            if (lblvalue > txtvalue)
            {
                MessageBox.Show("Insufficient Amount");
            }

            int reslt = lblvalue - txtvalue;
            lblChange.Text = reslt.ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for purchasing! \n Come Again!");
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdname1.Text) || string.IsNullOrEmpty(txtPrice1.Text) || string.IsNullOrEmpty(txtQty1.Text))
            {
                MessageBox.Show("Please select your desired item and enter the quantity");
            }
            else
            {
                if (!int.TryParse(txtQty1.Text, out int txtQuantity) || !decimal.TryParse(txtPrice1.Text, out decimal txtPrice))
                {
                    MessageBox.Show("Invalid quantity or price entered");
                    return;
                }

                int rowIndex = d1.CurrentRow.Index;

                if (rowIndex < 0 || rowIndex >= d1.Rows.Count)
                {
                    MessageBox.Show("No row selected in d1 data grid");
                    return;
                }

                if (!int.TryParse(d1.Rows[rowIndex].Cells[3].Value.ToString(), out int cell3value))
                {
                    MessageBox.Show("Invalid value in cell 3 of d1 data grid");
                    return;
                }

                int result = cell3value - txtQuantity;
                d1.Rows[rowIndex].Cells[3].Value = result;

                int rslt = Convert.ToInt32(txtPrice * txtQuantity);
                d2.Rows.Add(txtProdname1.Text, txtPrice, txtQuantity, rslt);

                txtProdname1.Clear();
                txtQty1.Clear();
                txtPrice1.Clear();
            }
        }



        private void cmbCategoryfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbCategoryfilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                foreach (DataGridViewRow row in d1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string cellValue = row.Cells[0].Value?.ToString();
                        row.Visible = (cellValue == selectedValue);
                    }
                }
            }
        }

        private void d1_SelectionChanged(object sender, EventArgs e)
        {
            if (d1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = d1.SelectedRows[0];
                string column2Value = selectedRow.Cells[1].Value.ToString();
                string column3Value = selectedRow.Cells[2].Value.ToString();
                txtProdname1.Text = column2Value;
                txtPrice1.Text = column3Value;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal grandTotal = 0;
            int cll2value = Convert.ToInt32(d1.Rows[0].Cells[2].Value);
            int cll3value = Convert.ToInt32(d1.Rows[0].Cells[3].Value);
            int rslt = cll2value * cll3value;
            d1.Rows[0].Cells[3].Value = rslt;


            foreach (DataGridViewRow row in d2.Rows)
            {
                if (!row.IsNewRow && row.Cells[3].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells[3].Value);
                    grandTotal += price;
                }
            }
            lblTotal.Text = grandTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteitem_Click(object sender, EventArgs e)
        {
            if (d2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = d2.SelectedRows[0];
                d2.Rows.Remove(selectedRow);
            }
        }

        private void btnUpdateitem_Click(object sender, EventArgs e)
        {
            int rowIndex = d2.CurrentRow.Index;
            int prc = int.Parse(txtPrice.Text);
            int qnty = int.Parse(txtQty.Text);
            int reslt = prc * qnty;
            d2.Rows[rowIndex].Cells[3].Value = reslt;
            int newqnty;
            if (int.TryParse(txtQty.Text, out newqnty))
            {
                int cellIndex = 2;
                int Rowindex = 0;

                d2.Rows[Rowindex].Cells[cellIndex].Value = newqnty;
                d2.Refresh();
            }

            txtPrice.Clear();
            txtProdname.Clear();
            txtQty.Clear();
            MessageBox.Show("Updated Succesfully");
        }

        private void d2_SelectionChanged(object sender, EventArgs e)
        {
            if (d2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = d2.SelectedRows[0];
                string column2Value = selectedRow.Cells[0].Value.ToString();
                string column3Value = selectedRow.Cells[1].Value.ToString();
                txtProdname.Text = column2Value;
                txtPrice.Text = column3Value;
            }
        }
    }
}
