using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_Diary : UserControl
    {
        public UC_Diary()
        {
            InitializeComponent();
            dataGridView2.DataSource = CSDL_OOP.Instance.GetDiaries();
        }

       
    }
}
