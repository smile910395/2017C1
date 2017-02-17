using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(true);//點了第一個按鈕，將true傳到Calculate進行判斷
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }
        private void Calculate(bool add)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if(add)
            {
                label1.Text = (x + y).ToString();
            }
            else
            {
                label1.Text = (x - y).ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate1(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate1(2);
        }
        private void Calculate1(int i)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            switch(i)
            {
                case 1:
                   label1.Text = (x + y).ToString();
                    break;
                case 2:
                    label1.Text = (x - y).ToString();
                    break;
            }
        }
    }
}
