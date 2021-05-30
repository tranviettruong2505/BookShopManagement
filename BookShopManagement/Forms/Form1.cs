using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BookShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account = textBox1.Text;
            string password = textBox2.Text;
            if (Login_DAL.Instance.Staff_Infor(account,password).Rows.Count >0)
            {
                using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }
    }
}
