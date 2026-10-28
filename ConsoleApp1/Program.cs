using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 100;
            Console.WriteLine("Tu chasse un cerf depuis 2H en toute discrétions, tu a enfin une chance de lui titer dessus et de mettre terme a cette chasse. ");
            while (l > 0)
            {
                Console.WriteLine("Tu as deux choix, soit tirer reussi(1) ou tire louper (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    i = i + 1;
                    k = k + 1;
                    l = l - 50;
                    Console.WriteLine("Tire reussi");
                    Console.WriteLine("Le cerf n'a plus que" + l + "de vie");
                }
                if (choose == 2)
                {
                    i = i + 1;
                    j = j + 1;
                    Console.WriteLine("Tire raté");
                }

            }
            Console.WriteLine("Bien jouer la chasse est terminé");
            Console.WriteLine("Voici vos stat, " + i + "Tir tiré, " + j + "Tir raté, " + k + "Tir Réussi");
        }
    }
}
