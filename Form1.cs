using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Review
{
    public partial class MayankMK1 : Form
    {
        public MayankMK1()
        {
            InitializeComponent();
        }

        private void MayankMK1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string des = txtDesignation.Text;
            string sal = txtSalary.Text;
            MessageBox.Show("Hello" + " " + name + ", " + "In the year 2023 you will be " + des + ", and your salary will be "+ sal + "$");
        }
    }
}
