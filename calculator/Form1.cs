using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "/";
            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "*";
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = textBox1.Text + "-";
            
        }

        private void Button17_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = textBox1.Text + "+";
           
        }

        private void Button11_Click(object sender, EventArgs e)
        {
           
        }
    }
}
