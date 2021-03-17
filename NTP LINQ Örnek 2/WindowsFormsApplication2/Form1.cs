using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dct = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
           var sorgu = from o in dct.ogrencis
                        select o;
            bindingSource1.DataSource = sorgu;
            dataGridView1.DataSource = bindingSource1;
            textBox1.DataBindings.Add("Text", bindingSource1, "id");
            textBox2.DataBindings.Add("Text", bindingSource1, "ad");
            textBox3.DataBindings.Add("Text", bindingSource1, "soyad");
            textBox4.DataBindings.Add("Text", bindingSource1, "numara");
            
        }
        public void bilgigoster()
        {
            var sorgu = from o in dct.ogrencis
                        select o;
            bindingSource1.DataSource = sorgu;
            dataGridView1.DataSource = bindingSource1;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ogrenci yeniogr = new ogrenci();
            yeniogr.ad = textBox5.Text;
            yeniogr.soyad = textBox6.Text;
            yeniogr.numara = Convert.ToInt32(textBox7.Text);
            dct.ogrencis.InsertOnSubmit(yeniogr);
            dct.SubmitChanges();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            bilgigoster();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gun = (from deger in dct.ogrencis
                       where deger.id == Convert.ToInt32(textBox1.Text)
                       select deger).FirstOrDefault();
            gun.ad = textBox2.Text;
            gun.soyad = textBox3.Text;
            gun.numara = Convert.ToInt32(textBox4.Text);
            dct.SubmitChanges();
            bilgigoster();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ogrenci sorgu = (from deger in dct.ogrencis
                             where deger.id == Convert.ToInt32(textBox8.Text)
                             select deger).FirstOrDefault();
            dct.ogrencis.DeleteOnSubmit(sorgu);
            dct.SubmitChanges();
            bilgigoster();
        }
    }
}
