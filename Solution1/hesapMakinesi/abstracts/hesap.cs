using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi.abstracts
{
 public  interface hesap
    {  double add(string text);
        double carp(string text, int[] dizi);
        double çarp(string text, int[]dizi1);
        double böl(string text);
        double mod(string text);
        double üs(string text);
        double mutlak(string text);
        double virgül(string text);
        double remove(string text);
        List<char> count(string text);
        string back(List<string>list1);
    }
}
