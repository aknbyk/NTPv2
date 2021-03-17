using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 61, 62, 34, 10, 25, 63, 81, 99 };
            var teksayilar = from s in sayilar
                             orderby s ascending
                             where s % 2 == 1
                             select s;
            foreach (int x in teksayilar)
            {
                listBox1.Items.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
