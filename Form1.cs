﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Variables
        Double FirstNumber;
        int OperationID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9")
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("."))
            { }
            else
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            OperationID = 0;
            FirstNumber = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)
                &&! char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //Only One Decimal is allowed
            if(e.KeyChar== '.')
            {
                if (textBox1.Text.Contains('.'))
                    e.Handled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperationID = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(OperationID)
            {
                case 1:
                    textBox1.Text =Convert.ToString(Convert.ToDouble(textBox1.Text) + FirstNumber);
                    break;
                case 2:
                    textBox1.Text = Convert.ToString(FirstNumber - Convert.ToDouble(textBox1.Text));
                    break;
                case 3:
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * FirstNumber);
                    break;
                case 4:
                    textBox1.Text = Convert.ToString(FirstNumber / (Convert.ToDouble(textBox1.Text)));
                    break;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperationID = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperationID = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            OperationID = 4;
        }
    }
}
