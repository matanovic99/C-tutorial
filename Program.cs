﻿using System.Net.Http.Headers;

namespace Program {
    class Applicaton {
        static void Main(string[]args){
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

            string key = Console.ReadLine();
            int choice =key =="" ? 0: int.Parse(key);
            string charClass = "";

      if (choice == 1){
                Console.WriteLine("\nOdabrali ste klasu Warrior");
                charClass = "Warrior";
        }   else if (choice == 2){
            Console.WriteLine("\nOdabrali ste klasu Mage");
        }   
           else {
           Console.WriteLine("\nNedozvoljeni unos Aplikacija će se zatvoriti.");
           Environment.Exit(0);

        }
    Console.WriteLine("***********************************************************");
    Console.WriteLine("\nUpišite ime vašeg lika: ");
    string name = Console.ReadLine();

    if (name == null || name == ""){
        Console.WriteLine("\nGreška, niste unijeli ime lika, Aplikacija će se zatvoriti");
        Environment.Exit(0);
    }
        }
        public string CharacterName{
            
        }
    }
}