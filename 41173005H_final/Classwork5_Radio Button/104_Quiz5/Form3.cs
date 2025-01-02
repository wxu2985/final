using _106_Classwork5_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _104_Quiz5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            Form1 triangleForm = new Form1();
            triangleForm.Show(); // 顯示 Form1

        }

        private void btn_quadrilateral_Click(object sender, EventArgs e)
        {
            Form2 quadrilateralForm = new Form2();
            quadrilateralForm.Show(); // 顯示 Form2
        }
    }
}
