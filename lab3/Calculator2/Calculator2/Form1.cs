using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text==".")
            {
                if(!result.Text.Contains(","))
                    result.Text = result.Text + ",";
            }
            else if (b.Text == "+/-")
            {
                if (result.Text.Contains("-"))
                    result.Text = result.Text.Substring(1);
                else
                    result.Text = "-" + result.Text;
            }else
            result.Text = result.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
               equation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                button18.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text=(value+Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;


            }
            value = double.Parse(result.Text);
           // value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text="0";
            value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

          private void button19_Click(object sender, EventArgs e)
          {
               result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
          }

          private void button20_Click(object sender, EventArgs e)
          {
               result.Text = Math.Pow(Double.Parse(result.Text), 2).ToString();
          }

          private void result_TextChanged(object sender, EventArgs e)
          {

          }
     }
}
