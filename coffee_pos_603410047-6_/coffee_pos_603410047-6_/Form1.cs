using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410047_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void mark(string Menu, string Bath)
        {
            string[] mark = { Menu, Bath };
            var ton = new ListViewItem(mark);
            listView1.Items.Add(ton);
            int ma, mo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            mark("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mark("Americano(Hot)", "35");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mark("Latte(Hot)", "35");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mark("Cappuccino(Hot)", "20");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mark("ThaiTea(Hot)", "20");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mark("CoCoa(Hot)", "20");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mark("Esspresso(Ice)", "45");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mark("Americano(Ice)", "45");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mark("Latte(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mark("Cappuccino(Ice)", "45");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mark("GreenTea(Hot)", "20");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mark("GreenTea(Ice)", "25");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mark("ThaiTea(Ice)", "25");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mark("CoCoa(Ice)", "25");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mark("Esspresso(Frappe)", "50");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mark("Latte(Frappe)", "50");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mark("Cappuccino(Frappe)", "50");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mark("GreenTea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            mark("ThaiTea(Frappe)", "30");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            mark("CoCoa(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            mark("Milk(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            mark("Milo(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            mark("Nestcafe(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            mark("Milk(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            mark("MilkTea(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            mark("LemonTea(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            mark("Milo(Ice)", "25");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            mark("Nestcafe(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            mark("NestcaTea(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            mark("Milk(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            mark("MilkTea(Frappe)", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            mark("LemonTea(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            mark("Milo(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            mark("Nestcafe(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            mark("NestcaTea(Frappe)", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            mark("Italian Soda(Cantaloupe,Strawberry, Apple, BlueHawai)(Frappe)", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            mark("Red lime Soda)(Ice)", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            mark(" Honey lime Soda)(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            mark("NestcaTea(Hot)", "20");
        }

        double price;
        public string[] getproduct()
        {
            price = 0;
            string[] listproduct = new string[listView1.Items.Count];
            int itemCount = listView1.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                price += double.Parse(listView1.Items[i].SubItems[1].Text);
                listproduct[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label26.Text = price.ToString() + "Bath";
            return listproduct;
        }
        public string[] getprice()
        {
            string[] listprice = new string[listView1.Items.Count];
            int itemCount = listView1.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                listprice[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return listprice;
        }
        string file_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void ser()
        {
            String[] ma = getproduct();
            String[] mo = getprice();
            string file1 = "Mark Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill = "Mark Coffee";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n";
            filebill += Menu + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                filebill += ma[i] + "      " + mo[i] + " B" + "\r\n";

            }
            filebill += "Total Price :" + label26.Text;

            System.IO.File.WriteAllText(file_path + @"\" + file1 + ".txt", filebill);
            filebill += "\r\n" + "\r\n" + "\r\n" + "Save File at" + file_path + @"\" + file1 + ".txt";
            label29.Text = filebill;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ser();
        }
    }
}