using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomeApp_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double num1 = 0, num2 = 0;   string op = "";
        int say = 0;
        /////////////ButonNumbers
        private void button1_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = double.Parse(button1.Text); say++; label2.Text = Convert.ToString(1); }
            else if (op != "") { num2 = double.Parse(button1.Text); say = 0; label2.Text += Convert.ToString(1); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = double.Parse(button2.Text); say++; label2.Text = Convert.ToString(2); }
            else if (op != "") { num2 = double.Parse(button2.Text); say = 0; label2.Text += Convert.ToString(2); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = double.Parse(button3.Text); say++; label2.Text = Convert.ToString(3); }
            else if (op != "") { num2 = double.Parse(button3.Text); say = 0; label2.Text += Convert.ToString(3); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 4; label2.Text = Convert.ToString(4); }
            else if(op != "") { num2 = 4; say = 0; label2.Text += Convert.ToString(4); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 5; label2.Text = Convert.ToString(5); }
            else if (op != "") { num2 = 5; say = 0; label2.Text += Convert.ToString(5); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 6; label2.Text = Convert.ToString(6); }
            else if (op != "") { num2 = 6; say = 0; label2.Text += Convert.ToString(6); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 7; label2.Text = Convert.ToString(7); }
            else if (op != "") { num2 = 7; say = 0; label2.Text += Convert.ToString(7); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 8; label2.Text = Convert.ToString(8);  }
            else if (op != "") { num2 = 8; say = 0; label2.Text += Convert.ToString(8); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 9; label2.Text = Convert.ToString(9); }
            else if (op != "") { num2 = 9; say = 0; label2.Text += Convert.ToString(9); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (say == 0) { num1 = 0; label2.Text = Convert.ToString(9); }
            else if (op != "") { num2 = 0; say = 0; label2.Text += Convert.ToString(0); }
        }

        //private void button13_Click(object sender, EventArgs e)
        //{
            
        //}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            op = "/"; say++; label2.Text += op; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            op = "*"; say++; label2.Text += op;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            op = "-"; say++;  label2.Text += op;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            op = "+"; say++; label2.Text += op;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    label3.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    label3.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    label3.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    label3.Text = (num1 / num2).ToString();
                    break;
            }
            num1 = 0; num2 = 0; op = "";
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            //radioButton4.Checked = false;
            //txtDisplay.Clear.t
        }

        //////////NumberButtonlari Bitdi


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
