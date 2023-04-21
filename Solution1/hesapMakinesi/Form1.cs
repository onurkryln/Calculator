using hesapMakinesi.abstracts;
using hesapMakinesi.concreters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        private hesap Hesap;
        private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void üsbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^2";
        }

        private void toplambtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void birbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void ikibtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void üçbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void dörtbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void beşbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void altıbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private string işlem(string text,hesap sonuc) {
            int lenght = text.Length;
            try
            {
      if (textBox1.Text.Trim() == "+" || textBox1.Text.Trim() == "-" ||
                    textBox1.Text.Trim() == "x"
                    || textBox1.Text.Trim() == "%" ||
                    textBox1.Text.Trim() == "/" || 
                    textBox1.Text.Trim() == "," ||
                    textBox1.Text.Trim() == "^2" ||
                    textBox1.Text.Trim() == "|")
                {
                    throw new Exception("sembol hatası");
                }

                else
                {

                    int i = 0; int sayaç = 0; int sayaç2 = 0;
                    while (i < lenght)
                    {
                        if (sayaç >= 2 || sayaç2 >= 3) { sayaç = 0; 
                            sayaç2 = 0;
                            throw new 
                                Exception("birden fazla sembol girilemez"); 
                            break; }

                        if (text[i] == '+' || text[i] == '-' ||
                            text[i] == 'x' ||
                            text[i] == '/' 
                            || text[i] == '%' ||
                            text[i] == '^'
                          ) { sayaç++; i++; }
                        if (text[i] == '|')
                        {
                            sayaç2++; i++;
                        }
                        else { i++; }
                    }
                    int[] dizi1 = dizi(text);
                    if (text.Contains("+")) { return sonuc.add(text).ToString(); }
                    if (text.Contains("-")) { return sonuc.remove(text).ToString(); }
                    if (text.Contains("x")) { return sonuc.çarp(text, dizi1).ToString(); }
                    if (text.Contains("%")) { return sonuc.mod(text).ToString(); }
                    if (text.Contains("/")) { return sonuc.böl(text).ToString(); }
                    if (text.Contains("^2")) { return sonuc.üs(text).ToString(); }
                    if (text.Contains("|")) { return sonuc.mutlak(text).ToString(); }
                    else { return ""; }
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }




        }

        private void yedibtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void sekizbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void dokuztn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void virgülbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void sıfırbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void sonucbtn_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            Hesap = new Sonuc();
           textBox1.Text= işlem(textBox1.Text, Hesap);
            



        }

       

    

        private void modbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void bölümbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void mutlakbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "|"+textBox1.Text +"|";
        }

        private void çıkarmabtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void çarpbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "x";
        }
        private int[] dizi(string text)
        {
            List<int> liste = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == '+' || text[i] == '-' || text[i] == 'x' ||
                    text[i] == '/' || text[i] == '%' ||
                    text[i] == '^' || text[i] == ',' || text[i] == '|') { liste.Add(i); }

            }int[] dizi = liste.ToArray();
            return dizi;
        }

            private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text=" ";
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            hesap Hesap= new Sonuc();
           textBox1.Text= Hesap.back(list);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() != " ")
            {
                if (textBox1.Text.Length == 1 || textBox1.Text.Length==0) { textBox1.Text = ""; }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
            else { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
