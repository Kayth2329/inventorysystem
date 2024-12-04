using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
            dgvMenu.Rows.Add("CUP", "12oz ColdCup" , "100", "50");
            dgvMenu.Rows.Add("CUP", "6oz ColdCup", "80", "50");
            dgvMenu.Rows.Add("CUP", "22oz ColdCup", "150", "50");
            dgvMenu.Rows.Add("CUP", "62oz PlainCup", "70", "50");
            dgvMenu.Rows.Add("WRAP", "Rice Wrap", "120", "30");
            dgvMenu.Rows.Add("CLAMSHELL", "Big Mac Clamshell", "200", "20");
            dgvMenu.Rows.Add("CLAMSHELL", "McSpaghetti", "200", "50");
            dgvMenu.Rows.Add("CLAMSHELL", "1pc Chicken", "200", "50");
            dgvMenu.Rows.Add("CLAMSHELL", "2pc Chicken", "210", "50");
            dgvMenu.Rows.Add("CONTAINER", "Sundae Container", "150", "30");
            dgvMenu.Rows.Add("DISPOSABLE", "Fork", "60", "50");
            dgvMenu.Rows.Add("DISPOSABLE", "Spoon", "60", "50");
            dgvMenu.Rows.Add("BOX", "McShare", "100", "50");
        }




        private int nextproductID;
        private DataTable originalDataTable;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            if (txtProdname.Text == string.Empty || txtQty.Text == string.Empty || txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Please select your desired item and enter the quantity");
            }
            else
            {
                string productName = txtProdname.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int quantity = int.Parse(txtQty.Text);
                dgvMenu.Rows.Add(productName, price, quantity);
                txtProdname.Clear();
                txtQty.Clear();
                txtPrice.Clear();
            }
        }

        private void btnUpdateitem_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvMenu.CurrentRow.Index;
            int c3value = Convert.ToInt32(dgvMenu.Rows[rowIndex].Cells[3].Value);
            int add = int.Parse(txtQty.Text);
            int result = c3value + add;
            DataGridViewCell priceCell = dgvMenu.Rows[rowIndex].Cells[3];
            priceCell.Value = result;

            txtPrice.Clear();
            txtProdname.Clear();
            txtQty.Clear();
            MessageBox.Show("Updated Succesfully");
        }

        private void btnDeleteitem_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMenu.SelectedRows[0];
                dgvMenu.Rows.Remove(selectedRow);
            }
        }


        private void cmbCategoryfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbCategoryfilter.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedValue))
            {
                foreach (DataGridViewRow row in dgvMenu.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string cellValue = row.Cells[0].Value?.ToString();
                        row.Visible = (cellValue == selectedValue);
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvMenu.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }

        }

        private void Adminform_Load(object sender, EventArgs e)
        {
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMenu.SelectedRows[0];
                string column2Value = selectedRow.Cells[1].Value.ToString();
                string column3Value = selectedRow.Cells[2].Value.ToString();
                txtProdname.Text = column2Value;
                txtPrice.Text = column3Value;
            }
        }
    }
}
