using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFinished
{
    public partial class Form1 : Form
    {
        CalcState calculator;
        List<char> list = new List<char>();
        public Form1()
        {
            InitializeComponent();
            calculator = new CalcState();
        }
        private void numbers_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (textBox1.Text == "0")
             {
                textBox1.Text = "";
                textBox1.Text += bt.Text;
             }
            else if(bt.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text += bt.Text;
                }
            }
              else
                    textBox1.Text += bt.Text;
        }
        private void operation_click(object sender,EventArgs e)
        {
            Button bt = (Button)sender;
            calculator.first_number = float.Parse(textBox1.Text);
            calculator.operation = bt.Text;
            textBox1.Text = "";
        }
        private void equal_click(object sender,EventArgs e)
        {
            calculator.second_number = double.Parse(textBox1.Text);
            calculator.calculate();
            textBox1.Text = calculator.result+"";
        }
        private void clear_clicked(object sender, EventArgs e)
        {
            calculator = new CalcState();
            textBox1.Text = "0";
        }
        private void operation2_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            calculator.first_number = double.Parse(textBox1.Text);
            calculator.operation = bt.Text;
            calculator.calculate();
            textBox1.Text = calculator.result.ToString();
        }
        private void showNumber_click(object sender,EventArgs e)
        {
            Button bt = (Button)sender;
            calculator.operation = bt.Text;
            calculator.calculate();
            textBox1.Text = calculator.result.ToString();
        }
        private void clearLast_click(object sender,EventArgs e)
        {
            /*for(int  i = 0; i < textBox1.Text.Length; i++)
            {
                list.Add(textBox1.Text[i]);
            }
            while (list.Count != 0)
            {
                list.RemoveAt(list.Count - 1);
                foreach (char c in list)
                {
                    textBox1.Text += c;
                }
            }*/
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            
        }
    }
}
