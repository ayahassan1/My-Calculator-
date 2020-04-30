using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        int A = 1; Boolean flag = true;int i=1;
        private void button2_Click(object sender, EventArgs e)
        {
            
            AddNewTextBox();
        }
        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            if (flag)
            {
                txt.Top = A * 130;
                flag = false;
                i++;
            }
            else if(!flag && i>5)
            {

                txt.Top = A * 28;
            }
            txt.Left = 28;
            A = A + 1;
            return txt;


        }
    }
}
