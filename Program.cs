using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mit Schleifen kann man Codeblöcke wiederholt ausführen
            //While
            Console.Write("Gebe Integer 1 an: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gebe Integer 2 an: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            while (zahl1 < zahl2)
            {
                Console.WriteLine(zahl1);
                zahl1 += 1;
            }

            //While-DO
            string passwort = "HelloWorld";
            string input = "";
            do
            {
                Console.Write("Gebe das Passwort ein: ");
                input = Console.ReadLine();
            }while (passwort != input);

            Console.WriteLine("Du hast das richtige Passwort!");


            //For-Schleifen
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[,] products = new string[,]
            {
                {
                    "Apfel",
                    "PCGames",
                    "Schokolade"
                },
                {
                    "Lebensmittel",
                    "Zeitschrift",
                    "Lebensmittel"
                }

            };

            for(int zeile = 0; zeile < products.GetLength(1); zeile++)
            {
                for(int spalte = 0; spalte < products.GetLength(0); spalte++)
                {
                    Console.Write(products[spalte, zeile]);
                    Console.Write(" ");
                }
                //Für den Zeilenumbruch
                Console.WriteLine();
            }

            //Foreach (nicht überschreibbar, nur lesbar)
            string[] names = new string[]
            {
                "Alina",
                "Babara",
                "Samantha",
                "Zoey",
                "Marcel",
                "Erik"
            };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            //break (damit kann man eine Schleife unterbrechen)
            int zahlbreak = 1;

            while (zahlbreak <= 10)
            {
                Console.WriteLine(zahlbreak);
                if(zahlbreak == 6)
                {
                    break;
                }
                zahlbreak++;
            }
            //continue
            int zahlcontinue = 0;

            while (zahlcontinue <= 10)
            {
                zahlcontinue++;
                if(zahlcontinue == 6)
                {
                    continue;
                }
                Console.WriteLine(zahlcontinue);
            }

            Console.ReadKey();
        }

    }
}
