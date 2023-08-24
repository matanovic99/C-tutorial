
namespace Program
{
    class MainMenu
    {
        private string charClass;
        public string CharacterClass()
        {
            bool running = true;
            do {
                Console.WriteLine("1. Warrior");
                Console.WriteLine("2. Mage");
                Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                if(choice == 1)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Warrior");
                    charClass = "Warrior";
                    running = false;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Mage");
                    charClass = "Mage";
                    running = false;
                }
                else{
                    Console.WriteLine ("\nNedotvoljeni unos! Pokušajte ponovno.");
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
