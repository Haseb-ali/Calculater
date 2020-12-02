using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calculater
{
    public partial class Form1 : Form
    {
        private double totall, totall2 = 0, totall3 = 1;
        private double totall1;
        private char op='0';
        private double result;
        private bool key;
        private int count = 0;
        private double s, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.Hide();
            richTextBox1.Text = "0";
            listBox1.Hide();
            panel1.Hide();
            label2.Hide();
            panel2.Hide();
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"!";
            try
            {

                int num;
                num = int.Parse(richTextBox1.Text);
                int fac = 1;
                for (int i = num; i > 0; i--)
                {
                    fac *= i;
                }
                richTextBox1.Clear();
                richTextBox1.Text = fac.ToString();
            }
            catch
            {
                richTextBox1.Text = "invalid";
            }
        }

        private void button22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='/')
            {
                button22.Focus();
                button22.BackColor = Color.Black;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void Button22_MouseHover(object sender, EventArgs e)
        {
            button22.BackColor = Color.Red;
        }

        private void button22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button22.Focus();
                button22.BackColor = Color.Black;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {

                richTextBox1.Focus();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string temp1;
            temp1 = textBox1.Text;
            if (richTextBox1.Text == "0"|| richTextBox1.Text == "Empty"|| richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            textBox1.Text = textBox1.Text + "1";
            richTextBox1.Text = richTextBox1.Text+ "1";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "2";
            textBox1.Text = textBox1.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "3";
            textBox1.Text = textBox1.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "4";
            textBox1.Text = textBox1.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "5";
            textBox1.Text = textBox1.Text + "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "6";
            textBox1.Text = textBox1.Text + "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "7";
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "8";
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" || richTextBox1.Text == "Empty" || richTextBox1.Text == "invalid")
            { richTextBox1.Clear(); }
            richTextBox1.Text = richTextBox1.Text + "9";
            textBox1.Text = textBox1.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "0";
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {if (richTextBox1.Text != "Empty")
                {
                    string temp = richTextBox1.Text;
                    string i = temp.Substring(0, temp.Length - 1);
                    richTextBox1.Text = i;
                }
            if(textBox1.TextLength!=0)
                {
                    string temp1 = textBox1.Text;
                    string l = temp1.Substring(0, temp1.Length - 1);
                    textBox1.Text = l;
                }
            }
            catch
            {
                richTextBox2.Clear();
                richTextBox1.Text = "Empty";
            }

        }
        private void show(string v)
        {
            textBox1.Text = v;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.MouseClick += RichTextBox1_MouseClick;
            richTextBox1.KeyPress += RichTextBox1_KeyPress;
            richTextBox1.KeyDown += RichTextBox1_KeyDown;
            //textBox1.Text = richTextBox1.Text;
            textBox1.Show();
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                double r = totall - 2;
                MessageBox.Show(r.ToString());
            }
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if(e.KeyChar=='+')
            {
                try
                {
                    string j = richTextBox1.Text;
                    MessageBox.Show(j);
                    totall+= double.Parse(richTextBox1.Text);
                    MessageBox.Show(totall.ToString());
                    string temp = textBox1.Text;
                    op = '+';
                }
                catch
                {
                    richTextBox2.Text = "invalid";
                }
            }
        }

        private void RichTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if ( richTextBox1.Text == "0"|| richTextBox1.Text == "Empty")
            { richTextBox1.Clear(); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265";
            richTextBox1.Text = "3.14159265";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            /* string h = "histroy";
                 using (StreamWriter sw = new StreamWriter(h+".txt"))
                 {
                     sw.WriteLine(richTextBox1.Text);
                 }*/
                 if(op=='0')
            {
                richTextBox1.Text = "0";
            }
            if (op == '+')
            {
                count++;
                totall1 = double.Parse(richTextBox1.Text);
                result = totall + totall1;
                richTextBox1.Clear();
                string j = textBox1.Text;
                textBox1.Text = j+"="+ result.ToString();
                richTextBox1.Text = result.ToString();
                if(key==false)
                {
                    textBox1.Clear();
                }
                key = false;
                
            }
            if (op == '-')
            {
                totall1 = double.Parse(richTextBox1.Text);
                result = totall - totall1;
                richTextBox1.Clear();
                string j = textBox1.Text;
                textBox1.Text = j + "=" + result.ToString();
                richTextBox1.Text = result.ToString();
                if (key == false)
                {
                    textBox1.Clear();
                }
                key = false;
            }
            if (op == '*')
            {
                totall1 = double.Parse(richTextBox1.Text);
                result = totall * totall1;
                richTextBox1.Clear();
                string j = textBox1.Text;
                textBox1.Text = j + "=" + result.ToString();
                richTextBox1.Text = result.ToString();
                if (key == false)
                {
                    textBox1.Clear();
                }
                key = false;
            }
            if (op == '/')
            {
                totall1 = double.Parse(richTextBox1.Text);
                result = totall / totall1;
                richTextBox1.Clear();
                string j = textBox1.Text;
                textBox1.Text = j + "=" + result.ToString();
                richTextBox1.Text = result.ToString();
                if (key == false)
                {
                    textBox1.Clear();
                }
                key = false;
            }
            if (op == '%')
            {
                totall1 = double.Parse(richTextBox1.Text);
                result = totall / totall1;
                richTextBox1.Clear();
                string j = textBox1.Text;
                textBox1.Text = j + "=" + result.ToString();
                richTextBox1.Text = result.ToString();
                if (key == false)
                {
                    textBox1.Clear();
                }
                key = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
                string b = "";
                b = textBox1.Text;
            if(b.Contains("="))
            {
                int y=b.IndexOf("=");
                b=b.Remove(0,y+1);
                textBox1.Text = b;
            }
          else  if(textBox1.TextLength==0)
            {
                string k = richTextBox1.Text;
                textBox1.Text = textBox1.Text + k;
            }
            try
            {
                totall = double.Parse(richTextBox1.Text);
                string temp = textBox1.Text;
                 b = textBox1.Text;
                richTextBox1.Clear();
                textBox1.Text = textBox1.Text + "+";
                op = '+';
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            key = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string b = "";
            b = textBox1.Text;
            if (b.Contains("="))
            {
                int y = b.IndexOf("=");
                b = b.Remove(0, y + 1);
                textBox1.Text = b;
            }
            else if (textBox1.TextLength == 0)
            {
                string k = richTextBox1.Text;
                textBox1.Text = textBox1.Text + k;
            }
            try
            {
                totall = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                op = '-';
                textBox1.Text = textBox1.Text + "-";
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            key = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = "";
            b = textBox1.Text;
            if (b.Contains("="))
            {
                int y = b.IndexOf("=");
                b = b.Remove(0, y + 1);
                textBox1.Text = b;
            }
            else if (textBox1.TextLength == 0)
            {
                string k = richTextBox1.Text;
                textBox1.Text = textBox1.Text + k;
            }
            try
            {
                totall = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                op = '*';
                if (textBox1.TextLength>0)
                {
                    textBox1.Text = textBox1.Text + "*";
                }
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            key = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "";
            b = textBox1.Text;
            if (b.Contains("="))
            {
                int y = b.IndexOf("=");
                b = b.Remove(0, y + 1);
                textBox1.Text = b;
            }
            else if (textBox1.TextLength == 0)
            {
                string k = richTextBox1.Text;
                textBox1.Text = textBox1.Text + k;
            }
            try
            {
                totall = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                op = '%';
                textBox1.Text = textBox1.Text + "%";
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            key = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string b = "";
            b = textBox1.Text;
            if (b.Contains("="))
            {
                int y = b.IndexOf("=");
                b = b.Remove(0, y + 1);
                textBox1.Text = b;
            }
            else if (textBox1.TextLength == 0)
            {
                string k = richTextBox1.Text;
                textBox1.Text = textBox1.Text + k;
            }
            try
            {
                totall = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                op = '/';
                textBox1.Text = textBox1.Text + "÷";
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            key = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(richTextBox1.Text);
                textBox1.Text = number + "*" + number;
                number *= number;
                richTextBox1.Clear();
                richTextBox1.Text = number.ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength!=0)
            {
                textBox1.Text = "√" + textBox1.Text; }
            try
            {
                double num = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                richTextBox1.Text = Math.Sqrt(num).ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text+= ".";
            textBox1.Text+= ".";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
         
            richTextBox2.Text = Math.Sign(get).ToString();
           
           
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Hide();
            label2.Show();
            panel1.Show();
            richTextBox2.Show();
            richTextBox2.Text = "0";
            panel2.Hide();
            textBox1.Hide();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Hide();
            panel1.Hide();
            richTextBox1.Show();
            richTextBox2.Hide();
            panel2.Hide();
            textBox1.Show();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            
                richTextBox2.Text = richTextBox2.Text + "0";
            
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "1";
            
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "2";
            
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "3";
            
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "4";
            
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "5";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "6";
            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "7";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "8";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
                richTextBox2.Text = richTextBox2.Text + "9";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += ".";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.Text = "0";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox2.Text != "Empty")
                {
                    string temp = richTextBox2.Text;
                    string i = temp.Substring(0, temp.Length - 1);
                    richTextBox2.Text = i;
                }
            }
            catch
            {
                richTextBox2.Text = "Empty";
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.MouseClick += RichTextBox2_MouseClick;
        }

        private void RichTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox2.Text == "0")
            {
                richTextBox2.Clear();
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            try
            {
                double get = double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                richTextBox2.Text = Math.Sin(get).ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Cos(get).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Tan(get).ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Asin(get).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Log(get).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Exp(get).ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Sinh(get).ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            richTextBox2.Clear();
            richTextBox2.Text = Math.Cosh(get).ToString();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            get = get * get * get;
            richTextBox2.Clear();
            richTextBox2.Text = get.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            get = get * get;
            richTextBox2.Clear();
            richTextBox2.Text = get.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double get = double.Parse(richTextBox2.Text);
            get = Math.Sqrt(get);
            richTextBox2.Clear();
            richTextBox2.Text = get.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
           double get = Math.PI;
            richTextBox2.Clear();
            richTextBox2.Text = get.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                num = int.Parse(richTextBox2.Text);
                int fac = 1;
                for (int i = num; i > 0; i--)
                {
                    fac *= i;
                }
                richTextBox2.Clear();
                richTextBox2.Text = fac.ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            try
            {
                double get = double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                richTextBox2.Text = Math.Log10(get).ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                double get = double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                richTextBox2.Text = Math.Acos(get).ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                double get = double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                richTextBox2.Text = Math.Atan(get).ToString();
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click_1(object sender, EventArgs e)
        {
            if(op=='0')
            {
                richTextBox2.Text = "0";
            }
            if (op == '+')
            {
                totall1 = double.Parse(richTextBox2.Text);
                result = totall2 + totall1;
                richTextBox2.Clear();
                richTextBox2.Text = result.ToString();
            }
            if (op == '-')
            {
                totall1 = double.Parse(richTextBox2.Text);
                result = totall- totall1;
                richTextBox2.Clear();
                richTextBox2.Text = result.ToString();
            }
            if (op == '*')
            {
                totall1 = double.Parse(richTextBox2.Text);
                result = totall3 * totall1;
                richTextBox2.Clear();
                richTextBox2.Text = result.ToString();
                totall3 = 1;
            }
            if (op == '/')
            {
                totall1 = double.Parse(richTextBox2.Text);
                result = totall / totall1;
                richTextBox2.Clear();
                richTextBox2.Text = result.ToString();
            }
            if (op == '%')
            {
                totall1 = double.Parse(richTextBox2.Text);
                result = totall / totall1;
                richTextBox2.Clear();
                richTextBox2.Text = result.ToString();
            }
           
        }

        private void button54_Click(object sender, EventArgs e)
        {
            try
            {
                totall2+=double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                op = '+';
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            try
            {
                totall= double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                op = '-';
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                totall3*= double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                op = '*';
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void develporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                totall= double.Parse(richTextBox2.Text);
                richTextBox2.Clear();
                op = '/';
            }
            catch
            {
                richTextBox2.Text = "invalid";
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
    }
}
