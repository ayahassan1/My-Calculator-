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
    public partial class Form5 : Form
    {
        double[,] mat1 = new double[4, 4];
        double[,] mat2 = new double[4, 4];
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[0, 2] = Convert.ToDouble(a02.Text);
            mat1[0, 3] = Convert.ToDouble(a03.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);
            mat1[1, 2] = Convert.ToDouble(a12.Text);
            mat1[1, 3] = Convert.ToDouble(a13.Text);
            mat1[2, 0] = Convert.ToDouble(a20.Text);
            mat1[2, 1] = Convert.ToDouble(a21.Text);
            mat1[2, 2] = Convert.ToDouble(a22.Text);
            mat1[2, 3] = Convert.ToDouble(a23.Text);
            mat1[3, 0] = Convert.ToDouble(a30.Text);
            mat1[3, 1] = Convert.ToDouble(a31.Text);
            mat1[3, 2] = Convert.ToDouble(a32.Text);
            mat1[3, 3] = Convert.ToDouble(a33.Text);


            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[0, 2] = Convert.ToDouble(b02.Text);
            mat2[0, 3] = Convert.ToDouble(b03.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);
            mat2[1, 2] = Convert.ToDouble(b12.Text);
            mat2[1, 3] = Convert.ToDouble(b13.Text);
            mat2[2, 0] = Convert.ToDouble(b20.Text);
            mat2[2, 1] = Convert.ToDouble(b21.Text);
            mat2[2, 2] = Convert.ToDouble(b22.Text);
            mat2[2, 3] = Convert.ToDouble(b23.Text);
            mat2[3, 0] = Convert.ToDouble(b30.Text);
            mat2[3, 1] = Convert.ToDouble(b31.Text);
            mat2[3, 2] = Convert.ToDouble(b32.Text);
            mat2[3, 3] = Convert.ToDouble(b33.Text);

            c00.Text = Convert.ToString(mat1[0, 0] + mat2[0, 0]);
            c01.Text = Convert.ToString(mat1[0, 1] + mat2[0, 1]);
            c02.Text = Convert.ToString(mat1[0, 2] + mat2[0, 2]);
            c03.Text = Convert.ToString(mat1[0, 3] + mat2[0, 3]);
            c10.Text = Convert.ToString(mat1[1, 0] + mat2[1, 0]);
            c11.Text = Convert.ToString(mat1[1, 1] + mat2[1, 1]);
            c12.Text = Convert.ToString(mat1[1, 2] + mat2[1, 2]);
            c13.Text = Convert.ToString(mat1[1, 3] + mat2[1, 3]);
            c20.Text = Convert.ToString(mat1[2, 0] + mat2[2, 0]);
            c21.Text = Convert.ToString(mat1[2, 1] + mat2[2, 1]);
            c22.Text = Convert.ToString(mat1[2, 2] + mat2[2, 2]);
            c23.Text = Convert.ToString(mat1[2, 3] + mat2[2, 3]);
            c30.Text = Convert.ToString(mat1[3, 0] + mat2[3, 0]);
            c31.Text = Convert.ToString(mat1[3, 1] + mat2[3, 1]);
            c32.Text = Convert.ToString(mat1[3, 2] + mat2[3, 2]);
            c33.Text = Convert.ToString(mat1[3, 3] + mat2[3, 3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[0, 2] = Convert.ToDouble(a02.Text);
            mat1[0, 3] = Convert.ToDouble(a03.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);
            mat1[1, 2] = Convert.ToDouble(a12.Text);
            mat1[1, 3] = Convert.ToDouble(a13.Text);
            mat1[2, 0] = Convert.ToDouble(a20.Text);
            mat1[2, 1] = Convert.ToDouble(a21.Text);
            mat1[2, 2] = Convert.ToDouble(a22.Text);
            mat1[2, 3] = Convert.ToDouble(a23.Text);
            mat1[3, 0] = Convert.ToDouble(a30.Text);
            mat1[3, 1] = Convert.ToDouble(a31.Text);
            mat1[3, 2] = Convert.ToDouble(a32.Text);
            mat1[3, 3] = Convert.ToDouble(a33.Text);


            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[0, 2] = Convert.ToDouble(b02.Text);
            mat2[0, 3] = Convert.ToDouble(b03.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);
            mat2[1, 2] = Convert.ToDouble(b12.Text);
            mat2[1, 3] = Convert.ToDouble(b13.Text);
            mat2[2, 0] = Convert.ToDouble(b20.Text);
            mat2[2, 1] = Convert.ToDouble(b21.Text);
            mat2[2, 2] = Convert.ToDouble(b22.Text);
            mat2[2, 3] = Convert.ToDouble(b23.Text);
            mat2[3, 0] = Convert.ToDouble(b30.Text);
            mat2[3, 1] = Convert.ToDouble(b31.Text);
            mat2[3, 2] = Convert.ToDouble(b32.Text);
            mat2[3, 3] = Convert.ToDouble(b33.Text);

            c00.Text = Convert.ToString(mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0] + mat1[0, 3] * mat2[3, 0]);
            c01.Text = Convert.ToString(mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1] + mat1[0, 3] * mat2[3, 1]);
            c02.Text = Convert.ToString(mat1[0, 0] * mat2[0, 2] + mat1[0, 1] * mat2[1, 2] + mat1[0, 2] * mat2[2, 2] + mat1[0, 3] * mat2[3, 2]);
            c03.Text = Convert.ToString(mat1[0, 0] * mat2[0, 3] + mat1[0, 1] * mat2[1, 3] + mat1[0, 2] * mat2[2, 3] + mat1[0, 3] * mat2[3, 3]);
            c10.Text = Convert.ToString(mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0] + mat1[1, 3] * mat2[3, 0]);
            c11.Text = Convert.ToString(mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1] + mat1[1, 3] * mat2[3, 1]);
            c12.Text = Convert.ToString(mat1[1, 0] * mat2[0, 2] + mat1[1, 1] * mat2[1, 2] + mat1[1, 2] * mat2[2, 2] + mat1[1, 3] * mat2[3, 2]);
            c13.Text = Convert.ToString(mat1[1, 0] * mat2[0, 3] + mat1[1, 1] * mat2[1, 3] + mat1[1, 2] * mat2[2, 3] + mat1[1, 3] * mat2[3, 3]);
            c20.Text = Convert.ToString(mat1[2, 0] * mat2[0, 0] + mat1[2, 1] * mat2[1, 0] + mat1[2, 2] * mat2[2, 0] + mat1[2, 3] * mat2[3, 0]);
            c21.Text = Convert.ToString(mat1[2, 0] * mat2[0, 1] + mat1[2, 1] * mat2[1, 1] + mat1[2, 2] * mat2[2, 1] + mat1[2, 3] * mat2[3, 1]);
            c22.Text = Convert.ToString(mat1[2, 0] * mat2[0, 2] + mat1[2, 1] * mat2[1, 2] + mat1[2, 2] * mat2[2, 2] + mat1[2, 3] * mat2[3, 2]);
            c23.Text = Convert.ToString(mat1[2, 0] * mat2[0, 3] + mat1[2, 1] * mat2[1, 3] + mat1[2, 2] * mat2[2, 3] + mat1[2, 3] * mat2[3, 3]);
            c30.Text = Convert.ToString(mat1[3, 0] * mat2[0, 0] + mat1[3, 1] * mat2[1, 0] + mat1[3, 2] * mat2[2, 0] + mat1[3, 3] * mat2[3, 0]);
            c31.Text = Convert.ToString(mat1[3, 0] * mat2[0, 1] + mat1[3, 1] * mat2[1, 1] + mat1[3, 2] * mat2[2, 1] + mat1[3, 3] * mat2[3, 1]);
            c32.Text = Convert.ToString(mat1[3, 0] * mat2[0, 2] + mat1[3, 1] * mat2[1, 2] + mat1[3, 2] * mat2[2, 2] + mat1[3, 3] * mat2[3, 2]);
            c33.Text = Convert.ToString(mat1[3, 0] * mat2[0, 3] + mat1[3, 1] * mat2[1, 3] + mat1[3, 2] * mat2[2, 3] + mat1[3, 3] * mat2[3, 3]);
            
        }
    }
}
