using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Value1;
            int Time, Minute;


            Value1 = Convert.ToInt32(textBox1.Text);

           Time = Value1/ 60;
            label2.Text = Time.ToString();

            Minute = Value1 % 60;
            label4.Text = Minute.ToString();

        }
    }
}
