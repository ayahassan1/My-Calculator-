using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {

        double[,] mat1 = new double[4, 4];
        double[,] mat2 = new double[4, 4];
        public Form3()
        {
            InitializeComponent();
        }

              

        private void button1_Click(object sender, EventArgs e)
        {
            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);


            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);

            c00.Text = Convert.ToString(mat1[0, 0] + mat2[0, 0]);
            c01.Text = Convert.ToString(mat1[0, 1] + mat2[0, 1]);
            c10.Text = Convert.ToString(mat1[1, 0] + mat2[1, 0]);
            c11.Text = Convert.ToString(mat1[1, 1] + mat2[1, 1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);


            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);

            c00.Text = Convert.ToString(mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] );
            c01.Text = Convert.ToString(mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] );
            c10.Text = Convert.ToString(mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0]);
            c11.Text = Convert.ToString(mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1]);
        }

      
    }
}
