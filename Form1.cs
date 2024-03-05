using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool is_choose = false;
        string operaterValue = "";
        string before_string = "";
        string after_string = "";
        string curent_result = "";
        private void button_Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;
            if(is_choose)
            {
                textBox1.Text = "";
                after_string = after_string + buttonText;
                textBox1.Text = after_string;
            }
            else
            {
                before_string = before_string + buttonText;
                textBox1.Text = before_string;
            }
        }

        private void handleOperatorClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string operatorText = button.Text;
            is_choose = true;
            operaterValue = operatorText;
            if (curent_result != "")
            {
                before_string = curent_result;
                after_string = "";
            }
        }

        
        public Form1()
        {
            InitializeComponent();
            button1.Click+= button_Number_Click;
            button2.Click+= button_Number_Click;
            button3.Click+= button_Number_Click;
            button5.Click+= handleOperatorClick;
            button6.Click+= handleOperatorClick;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void handleResetValue ()
        {
            is_choose = false;
            operaterValue = "";
            after_string = "";
            before_string = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(before_string);
            int number2 = int.Parse(after_string);
            int result;
            switch (operaterValue)
            {
                case "+":
                {
                    result = number1 + number2;
                    break;
                }
                case "-":
                {
                    result = number1 - number2;
                    break;
                }
                default: 
                { 
                    result = 0; break; 
                }
            }    
            textBox1.Text = result.ToString();
            curent_result = result.ToString();
            handleResetValue();
        }
    }
}
