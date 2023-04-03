using hesapMakinesi.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hesapMakinesi.concreters
{
    public class Sonuc : hesap
    {
        private List<string> list=new List<string>();
        public double add(string text)
        {
            list.Add(text);
            List<int> liste = new List<int>();
            int sayı1 = 0; int sayı2 = 0; 
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] == '+') { 
                
                    sayı1 = Convert.ToInt32(text.Substring(0, i + 1)); sayı2 = Convert.ToInt32(text.Substring(i + 1)); break; }

            }
         double   toplam = sayı1 + sayı2;
            return toplam;
        }
         
        public double böl(string text)
        {
            list.Add(text);


            double sayı1 = 0; double sayı2 = 0; int toplam;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] == '/')
                {

                    sayı1 = Convert.ToDouble(text.Substring(0, i + 1).ToString()); sayı2 = Convert.ToDouble(text.Substring(i + 2).ToString()); break;
                }

            }
           double toplamm = sayı1 / sayı2;
            return toplamm;
        }

        public List<char> count(string text)
        {
           

            List<char> list =new List<char>();
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '+' ) { list.Add(text[i]); }
                if (text[i] == '-') { list.Add(text[i]); }
                if (text[i] == 'x') { list.Add(text[i]); }
                if (text[i] == '/') { list.Add(text[i]); }
                if (text[i] == '%') { list.Add(text[i]); }
                if (text[i] == '^') { list.Add(text[i]); }
                else { }
            }
            return list;

        }

        public double mod(string text)
        {
            list.Add(text);

            double sayı1 = 0; double sayı2 = 0; double toplam;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] == '%')
                {

                    sayı1 = Convert.ToDouble(text.Substring(0, i + 1)); sayı2 = Convert.ToDouble(text.Substring(i + 2)); break;
                }

            }
            toplam = sayı1 % sayı2;
            return toplam;
        }

        public double mutlak(string text)
        {
            list.Add(text);

            string a = "";
            double sayı = 0; double sayı2 = 0; double toplam;int sayaç = 0;
            for (int i = 0; i < text.Length-1 ; i++)
            {


                if (text[i] == '|')
                {


                    sayaç++;
                    text = text.Remove(i, 1);
                    a += text[i];
                }
                else { a += text[i]; }
                if (sayaç == 2)
                {
                    sayaç = 0; break;

                }
            }
            text = text.Remove(text.Length-1);
            sayı2 = Convert.ToDouble(text);
            toplam =   sayı2>=0?sayı2:(-sayı2);
            return toplam;
        }

        public double remove(string text)
        {
            list.Add(text);

            double sayı1 = 0; double sayı2 = 0; double toplam=0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Contains('|')){ toplam= mutlak(text);break; }
           
               else if (text[i + 1] == '-')
                {

                    sayı1 = Convert.ToDouble(text.Substring(0, i + 1)); sayı2 = Convert.ToDouble(text.Substring(i + 2)); toplam = sayı1 - sayı2; break;
                
                }
                else { }

            }
         

            return toplam;
        }

        public double virgül(string text)
        {
            list.Add(text);

            text = text + ".";
            double toplam = Convert.ToInt64(text);
            return toplam;
        }

        public double carp(string text, int[]dizi1) {


            List<double> listcarp = new List<double>();
            list.Add(text);
            int u = dizi1.Length; int bb = 0; int uu = 0;
            while (uu < u)
            {
                if (text[dizi1[uu]] == 'x') { listcarp.Add(Convert.ToDouble(text.Substring(bb, uu))); uu++; bb = uu; }
                else { uu++; }

            }

            double d =çarp2(listcarp);

            return d;

        }
        public double çarp2(List<double> çarp) {
            double ç = 1;
            for (int i = 0; i < çarp.Capacity; i++) {

                ç *= çarp[i];
            }

            return ç;
        
        }

        public double çarp(string text, int[] dizi1)
        {
            


            double sayı1 = 0; double sayı2 = 0; double toplam;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] == 'x')
                {

                    sayı1 = Convert.ToDouble(text.Substring(0, i + 1)); sayı2 = Convert.ToDouble(text.Substring(i + 2)); break;
                }

            }
            toplam = sayı1 * sayı2;
            return toplam;
        }

        public double üs(string text)
        {
            list.Add(text);

            double sayı1 = 0; double sayı2 = 0; double toplam;


            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1] == '^')
                {

                    sayı1 = Convert.ToDouble(text.Substring(0, i + 1)); break;
                }

            }
            toplam = sayı1*sayı1;
            return toplam;
        }
        public string back(List<string>list1) {
            string[] d = list1.ToArray();
            int i = d.Length-1;
            try
            {
                if (d[i] != " " && d[i - 1] != " ") { i--; return d[i]; }
                if (d[i] != " " && d[i - 1] == " ") { i--; return " "; }
                if (d[i] == " ") { return " "; }
                return " ";
            }
            catch (Exception e) {
                return "";
            }



        }

    }
}
