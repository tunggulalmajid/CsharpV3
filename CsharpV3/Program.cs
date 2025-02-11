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
            //Hero superman = new Hero();
            //Console.WriteLine("superman berwarna >> {0}", superman.color);
            //Console.WriteLine("superman mempunyai power >> {0}",superman.power);
            //Console.WriteLine("superman mempunyai health sebesar >> {0}", superman.health);
            //Console.Write("superman memiliki kekuatan >> ");
            //superman.kekuatan();
            //Console.WriteLine();

            //// object kedua
            //Marksman usop = new Marksman(); // turunan kelas hero
            //Console.WriteLine("usop berwarna >> {0}", usop.color);
            //Console.WriteLine("usop mempunyai senjata  >> {0}", usop.senjata);
            //Console.Write("bunyi senjata usop  >> ");
            //usop.suaraSenjata();
            //usop.tinggi = 170; // pemanfaatan get set untuk mendapatkan nilai
            //Console.WriteLine("tinggi usop >> {0}", usop.tinggi);

            Hero Lancer = new Hero();
            villain Argus = new villain();

            Console.WriteLine("Hero");
            Console.WriteLine("Hero Lancer memiliki aura >> {0}", Lancer.color);
            Console.WriteLine("Hero Lancer memiliki power >> {0}", Lancer.power);
            Console.WriteLine("Hero Lancer memiliki health >> {0}", Lancer.health);
            Console.Write("Hero Lancer memiliki kekuatan >> ");
            Lancer.kekuatan();
            Console.WriteLine("Hero Lancer memiliki total kekuatan >> {0}", Lancer.total_kekuatan());

            Console.WriteLine("");

            Console.WriteLine("Villain");
            Console.WriteLine("Villain Argus memiliki aura >> {0}", Argus.aura);
            Console.WriteLine("Villain Argus memiliki power >> {0}", Argus.power);
            Console.WriteLine("Villain Argus memiliki health >> {0}", Argus.health);
            Console.Write("Villain Argus memiliki kekuatan >> ");
            Argus.kekuatan();
            Console.WriteLine("Villain Argus memiliki total kekuatan >> {0}", Argus.total_kekuatan());

            int PoinHero = 0;
            int PoinVillain = 0;
            string HasilAura;
            string HasilHealth;
            string HasilTotalKekuatan;
            string Kesimpulan;
            string HasilPower;

            if (Lancer.color == "yellow" && Argus.aura == "red" )
            {
                HasilAura = "aura milik villain lebih kuat daripada Hero";
                PoinVillain += 1;
            }
            else
            {
                HasilAura = "aura milik Hero lebih kuat daripada Villain";
                PoinHero += 1;
            }

            
            if (Lancer.power > Argus.power)
            {
                HasilPower = "Power Hero lebih kuat daripada Villain";
                PoinHero += 1;
            }
            else
            {
                HasilPower = "Power Villain lebih kuat daripada Hero";
                PoinVillain += 1;
            }

            
            if (Lancer.health > Argus.health)
            {
                HasilHealth = "Health Hero lebih besar daripada Villain";
                PoinHero += 1;
            }
            else
            {
                HasilHealth = "Health Villain lebih besar daripada Hero";
                PoinVillain += 1;
            }

            if (Lancer.total_kekuatan() > Argus.total_kekuatan())
            {
                HasilTotalKekuatan = "Hero lebih kuat daripada Villain";
                PoinHero += 1;
            }
            else
            {
                HasilTotalKekuatan = "Villain lebih kuat daripada Hero";
                PoinVillain += 1;
            }



            Console.WriteLine("");
            Console.WriteLine("Perbandingan kekuatan");

            Console.Write("1. ");
            Console.WriteLine(HasilAura);
            Console.Write("2. ");
            Console.WriteLine(HasilPower);
            Console.Write("3. ");
            Console.WriteLine(HasilHealth);
            Console.Write("4. ");
            Console.WriteLine(HasilTotalKekuatan);

            Console.ReadLine();
        }
    }
}
