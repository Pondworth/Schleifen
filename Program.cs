﻿using System;
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

            Console.ReadKey();
        }

    }
}