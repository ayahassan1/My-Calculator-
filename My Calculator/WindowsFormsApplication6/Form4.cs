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
    public partial class Form4 : Form
    {
        double[,] mat1 = new double[4, 4];
        double[,] mat2 = new double[4, 4];
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[0, 2] = Convert.ToDouble(a02.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);
            mat1[1, 2] = Convert.ToDouble(a12.Text);
            mat1[2, 0] = Convert.ToDouble(a20.Text);
            mat1[2, 1] = Convert.ToDouble(a21.Text);
            mat1[2, 2] = Convert.ToDouble(a22.Text);

            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[0, 2] = Convert.ToDouble(b02.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);
            mat2[1, 2] = Convert.ToDouble(b12.Text);
            mat2[2, 0] = Convert.ToDouble(b20.Text);
            mat2[2, 1] = Convert.ToDouble(b21.Text);
            mat2[2, 2] = Convert.ToDouble(b22.Text);

            c00.Text = Convert.ToString(mat1[0, 0] + mat2[0, 0]);
            c01.Text = Convert.ToString(mat1[0, 1] + mat2[0, 1]);
            c02.Text = Convert.ToString(mat1[0, 2] + mat2[0, 2]);
            c10.Text = Convert.ToString(mat1[1, 0] + mat2[1, 0]);
            c11.Text = Convert.ToString(mat1[1, 1] + mat2[1, 1]);
            c12.Text = Convert.ToString(mat1[1, 2] + mat2[1, 2]);
            c20.Text = Convert.ToString(mat1[2, 0] + mat2[2, 0]);
            c21.Text = Convert.ToString(mat1[2, 1] + mat2[2, 1]);
            c22.Text = Convert.ToString(mat1[2, 2] + mat2[2, 2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            mat1[0, 0] = Convert.ToDouble(a00.Text);
            mat1[0, 1] = Convert.ToDouble(a01.Text);
            mat1[0, 2] = Convert.ToDouble(a02.Text);
            mat1[1, 0] = Convert.ToDouble(a10.Text);
            mat1[1, 1] = Convert.ToDouble(a11.Text);
            mat1[1, 2] = Convert.ToDouble(a12.Text);
            mat1[2, 0] = Convert.ToDouble(a20.Text);
            mat1[2, 1] = Convert.ToDouble(a21.Text);
            mat1[2, 2] = Convert.ToDouble(a22.Text);

            mat2[0, 0] = Convert.ToDouble(b00.Text);
            mat2[0, 1] = Convert.ToDouble(b01.Text);
            mat2[0, 2] = Convert.ToDouble(b02.Text);
            mat2[1, 0] = Convert.ToDouble(b10.Text);
            mat2[1, 1] = Convert.ToDouble(b11.Text);
            mat2[1, 2] = Convert.ToDouble(b12.Text);
            mat2[2, 0] = Convert.ToDouble(b20.Text);
            mat2[2, 1] = Convert.ToDouble(b21.Text);
            mat2[2, 2] = Convert.ToDouble(b22.Text);

            c00.Text = Convert.ToString(mat1[0, 0] * mat2[0, 0] + mat1[0, 1] * mat2[1, 0] + mat1[0, 2] * mat2[2, 0] );
            c01.Text = Convert.ToString(mat1[0, 0] * mat2[0, 1] + mat1[0, 1] * mat2[1, 1] + mat1[0, 2] * mat2[2, 1] );
            c02.Text = Convert.ToString(mat1[0, 0] * mat2[0, 2] + mat1[0, 1] * mat2[1, 2] + mat1[0, 2] * mat2[2, 2] );
            c10.Text = Convert.ToString(mat1[1, 0] * mat2[0, 0] + mat1[1, 1] * mat2[1, 0] + mat1[1, 2] * mat2[2, 0] );
            c11.Text = Convert.ToString(mat1[1, 0] * mat2[0, 1] + mat1[1, 1] * mat2[1, 1] + mat1[1, 2] * mat2[2, 1] );
            c12.Text = Convert.ToString(mat1[1, 0] * mat2[0, 2] + mat1[1, 1] * mat2[1, 2] + mat1[1, 2] * mat2[2, 2] );
            c20.Text = Convert.ToString(mat1[2, 0] * mat2[0, 0] + mat1[2, 1] * mat2[1, 0] + mat1[2, 2] * mat2[2, 0] );
            c21.Text = Convert.ToString(mat1[2, 0] * mat2[0, 1] + mat1[2, 1] * mat2[1, 1] + mat1[2, 2] * mat2[2, 1] );
            c22.Text = Convert.ToString(mat1[2, 0] * mat2[0, 2] + mat1[2, 1] * mat2[1, 2] + mat1[2, 2] * mat2[2, 2] );

        }
    }
}
