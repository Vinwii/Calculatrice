using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choix possibles :\n     1 : + \n     2 : - \n     3 : * \n     4 : / \n     5 : Exit\n(Mettre \",\" et pas \".\")");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.NumPad1) Addition();
                if (key.Key == ConsoleKey.NumPad5) break;
                if (key.Key == ConsoleKey.NumPad2) Soustraction();
                if (key.Key == ConsoleKey.NumPad3) Multiplication();
                if (key.Key == ConsoleKey.NumPad4) Division();
                Console.Clear();
            }

        }
        static void Addition()
        {
            float a1 = Saisie1();
            float a2 = Saisie2();
            float resultat = a1 + a2;
            Console.WriteLine("La somme donne : " + resultat);
            Console.ReadKey();
        }

        static void Soustraction()
        {
            float a1 = Saisie1();
            float a2 = Saisie2();
            float resultat = a1 - a2;
            Console.WriteLine("La soustraction donne : " + resultat);
            Console.ReadKey();
        }

        static void Multiplication()
        {
            float a1 = Saisie1();
            float a2 = Saisie2();
            float resultat = a1 * a2;
            Console.WriteLine("Le produit donne : " + resultat);
            Console.ReadKey();
        }

        static void Division()
        {
            float a1 = Saisie1();
            float a2 = Saisie2();
            float resultat = a1 / a2;
            Console.WriteLine("La division donne : " + resultat);
            Console.ReadKey();
        }
        static float Saisie1()
        {
            float nb = 0;
            bool nbIsValid = false;
            while (!nbIsValid)
            {
                Console.WriteLine("Veuillez entrer votre premier nombre : ");
                string saisie = Console.ReadLine();
                if (float.TryParse(saisie, out nb))
                    nbIsValid = true;
                else
                {
                    nbIsValid = false;
                    Console.WriteLine("Votre saisie n'est pas correcte ...");
                }
            }
            return nb;

        }


        static float Saisie2()
        {
            float nb = 0;
            bool nbIsValid = false;
            while (!nbIsValid)
            {
                Console.WriteLine("Veuillez entrer votre second nombre : ");
                string saisie = Console.ReadLine();
                if (float.TryParse(saisie, out nb))
                    nbIsValid = true;
                else
                {
                    nbIsValid = false;
                    Console.WriteLine("Votre saisie n'est pas correcte ...");
                }
            }
            return nb;
        }
    }
}