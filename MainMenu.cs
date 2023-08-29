
namespace Program
{
    class MainMenu
    {
        private string charClass;
        public string CharacterClass()
        {
            bool running = true;
            do {
                Console.WriteLine("1. Elf");
                Console.WriteLine("2. Dwarf");
                Console.WriteLine("3. Human");
                Console.WriteLine("4. Goblin");
                Console.WriteLine("5. Wizard");
                Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                if(choice == 1)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Elf");
                    charClass = "Elf";
                    running = false;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Dwarf");
                    charClass = "Dwarf";
                    running = false;
                }
                else if (choice == 3)
                {
                    Console.WriteLine ("\nodabrali ste klasu: Human");
                    charClass = "Human";
                    running = false;
                }
                 else if (choice == 4)
                 {
                    Console.WriteLine ("\nOdabrali ste klasu Goblin:");
                    charClass = "Goblin";
                    running = false;
                 }   
               
                
                else if (choice == 5);
                {
                    Console.WriteLine("\nOdabrali ste klasu: Wizard");
                    charClass = "Wizard";
                    running = false;
                    }

                
        

            } while (running);
            return charClass;
        }
        public string CharacterName()
        {
            string name;
            bool running = true;
            do
            {
                Console.WriteLine("\n*****************************************************");
                Console.WriteLine("\nUpišite naziv vašeg lika: ");
                name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("\nGreška! Niste unijeli ime lika. Pokušajte ponovno. ");
            }
            else{
                running = false;
            }
            } while (running);
            return name;
        }
    }
}
