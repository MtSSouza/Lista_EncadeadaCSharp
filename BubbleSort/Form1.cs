using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int max = 10;
        const int troca = 0;
        public int counts = 100;
        private void Write_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                counts = int.Parse(textBox1.Text);
            }
            List list = new List();
            list.RandomValues(max, list);
            list.Organize(list);
            chart1.Series["Series1"].Points.AddXY(list.length, list.stopwatch.ElapsedMilliseconds);
            while (list.number < counts)
            {
                list.RandomValues(5, list);
                list.Organize(list);
                chart1.Series["Series1"].Points.AddXY(list.length, list.stopwatch.ElapsedMilliseconds);
            }
            label1.Text = "Time: ";
            label1.Text += list.stopwatch.Elapsed.ToString();
        }
    }
}
