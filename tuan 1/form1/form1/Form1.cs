using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Was Clicked.");
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, WellComto C# progamming!");
        }
        private void frm1_click(object seder, EventArgs e)
        {
            MessageBox.Show("Form was clicker");

        }
    }
}
