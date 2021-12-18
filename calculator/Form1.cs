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

        string val_1, val_2="";
        char oprt;
        bool option = false;
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
                val_1 = "1";
            }
            else
            {
                if (option == false)
                {
                val_1 += "1";
                textBox1.Text += "1";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "1";
                        textBox1.Text += "1";
                    }
                    else
                    {
                        val_2 += "1";
                        textBox1.Text += "1";
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "2";
                val_1 = "2";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "2";
                    textBox1.Text += "2";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "2";
                        textBox1.Text += "2";
                    }
                    else
                    {
                        val_2 += "2";
                        textBox1.Text += "2";
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "3";
                val_1 = "3";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "3";
                    textBox1.Text += "3";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "3";
                        textBox1.Text += "3";
                    }
                    else
                    {
                        val_2 += "3";
                        textBox1.Text += "3";
                    }
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "4";
                val_1 = "4";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "4";
                    textBox1.Text += "4";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "4";
                        textBox1.Text += "4";
                    }
                    else
                    {
                        val_2 += "4";
                        textBox1.Text += "4";
                    }
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "5";
                val_1 = "5";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "5";
                    textBox1.Text += "5";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "5";
                        textBox1.Text += "5";
                    }
                    else
                    {
                        val_2 += "5";
                        textBox1.Text += "5";
                    }
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "6";
                val_1 = "6";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "6";
                    textBox1.Text += "6";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "6";
                        textBox1.Text += "6";
                    }
                    else
                    {
                        val_2 += "6";
                        textBox1.Text += "6";
                    }
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "7";
                val_1 = "7";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "7";
                    textBox1.Text += "7";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "7";
                        textBox1.Text += "7";
                    }
                    else
                    {
                        val_2 += "7";
                        textBox1.Text += "7";
                    }
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
                {
                    textBox1.Text = "8";
                    val_1 = "8";
                }
                else
                {
                    if (option == false)
                    {
                        val_1 += "8";
                        textBox1.Text += "8";
                    }
                    else
                    {
                        if (val_2 == "")
                        {
                            val_2 = "8";
                            textBox1.Text += "8";
                        }
                        else
                        {
                            val_2 += "8";
                            textBox1.Text += "8";
                        }
                    }
                }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "9";
                val_1 = "9";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "9";
                    textBox1.Text += "9";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "9";
                        textBox1.Text += "9";
                    }
                    else
                    {
                        val_2 += "9";
                        textBox1.Text += "9";
                    }
                }
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "" || textBox1.Text == null)
            {
                textBox1.Text = "0";
                val_1 = "0";
            }
            else
            {
                if (option == false)
                {
                    val_1 += "0";
                    textBox1.Text += "0";
                }
                else
                {
                    if (val_2 == "")
                    {
                        val_2 = "0";
                        textBox1.Text += "0";
                    }
                    else
                    {
                        val_2 += "0";
                        textBox1.Text += "0";
                    }
                }
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            oprt = '/';
            option = true;
            textBox1.Text = textBox1.Text + "/";
            
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            oprt = '*';
            option = true;
            textBox1.Text = textBox1.Text + "*";
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            oprt = '-';
            option = true;
            textBox1.Text = textBox1.Text + "-";
            
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            oprt = '+';
            option = true;
                textBox1.Text = textBox1.Text + "+";
           
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            switch (oprt)
            {
                case '+':
                    {
                       int ans = int.Parse(val_1) + int.Parse(val_2);
                        textBox1.Text = Convert.ToString(ans);
                        break;
                    }
                case '-':
                    {
                        int ans = int.Parse(val_1) - int.Parse(val_2);
                        textBox1.Text = Convert.ToString(ans);
                        break;
                    }
                case '/':
                    {
                        int ans = int.Parse(val_1) / int.Parse(val_2);
                        textBox1.Text = Convert.ToString(ans);
                        break;
                    }
                case '*':
                    {
                        int ans = int.Parse(val_1) * int.Parse(val_2);
                        textBox1.Text = Convert.ToString(ans);
                        break;
                    }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";


        }
    }
}
