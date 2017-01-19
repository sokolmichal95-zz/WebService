using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Consumer.ServiceReference1;
namespace Consumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceSoapClient service = new ServiceSoapClient();
            try
            {
                label3.Text = "x + y = " + service.Add(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceSoapClient service = new ServiceSoapClient();
            try
            {
                label3.Text = "x - y = " + service.Substract(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceSoapClient service = new ServiceSoapClient();
            try
            {
                label3.Text = "x * y = " + service.Multiply(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceSoapClient service = new ServiceSoapClient();
            try
            {
                label3.Text = "x / y = " + service.Divide(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
