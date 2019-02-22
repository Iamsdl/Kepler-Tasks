using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20Ex;
namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ex1.exer1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ex2.exer2(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string loud="";
            if (radioButton1.Checked)
                loud = "loud";
            if (radioButton3.Checked)
                loud = "quiet";
            MessageBox.Show(ex3.exer3(textBox2.Text, loud));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double [] temp = ex4.exer4(dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            MessageBox.Show($"You are {temp[0]} days old and there are {temp[1]} days until your next 27 birthday?");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ex5.exer5(Convert.ToInt16(numericUpDown1.Value)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ex6.exer6());
        }
    }
}
