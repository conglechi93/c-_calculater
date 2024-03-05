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
        // Sự kiện Event 
        // Đối tượng đang được tác động vào
        // Sự kiện tác động lên đối tượng thuộc loại nào

        // Kiểu dữ liệu mù 
        // object = button = label = view = image 
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button; // Ép kiểu. Nói chính xác hơn thì ta đang dùng sender như một Button 

            // button sẽ có các phương thức và thuộc tính như một Button 
            string buttonText = button.Text;
            label3.Text = buttonText + "avbc";


        }
        public Form1()
        {
            InitializeComponent();
            button1.Click+= button_Click;
            button2.Click+= button_Click;
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
    }
}
