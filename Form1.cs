using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_of_Stocks_of_Dry_Goods_in_Mcdonalds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (txtUsername.Text == "Admin" || txtPassword.Text == "Admin")
            {
                Adminform adminform = new Adminform();
                adminform.Show();
                this.Hide();

            }
            else
            {

                Userform use = new Userform();
                use.Show();
                this.Hide();
            }
        }
    }
}
