using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero superman = new Hero();
            Console.WriteLine("superman berwarna >> {0}", superman.color);
            Console.WriteLine("superman mempunyai power >> {0}",superman.power);
            Console.WriteLine("superman mempunyai health sebesar >> {0}", superman.health);
            Console.Write("superman memiliki kekuatan >> ");
            superman.kekuatan();

            Console.ReadLine();
        }
    }
}
