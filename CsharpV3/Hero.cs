using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CsharpV3
{
    class Hero
    {
        public string color = "yellow";
        public int power = 1000;
        public int health = 1500;
        public void kekuatan()
        {
            Console.WriteLine("Light Aura");
        }
        public int total_kekuatan()
        {
            int total = power + health;
            return total;
        }
    }
    class Marksman : Hero
    {
        public string senjata = "pistol";
        public int tinggi {  get; set; }
        public void suaraSenjata()
        {
            Console.WriteLine("dar dar");
        }
    }

    class villain
    {
        public string aura = "red";
        public int power = 1500;
        public int health = 750;
        public void kekuatan() 
        {
            Console.WriteLine("dark Aura");
        }
        public int total_kekuatan()
        {
            int total = power + health;
            return total;
        }
    }
}
