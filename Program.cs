class Program {
    static void Main(string[] args) {
        Trgovina trgovina = new Trgovina();
        trgovina.DodajProizvod("Mlijeko", 7.99, 5);
        trgovina.DodajProizvod("Kruh", 3.49, 10);
        trgovina.DodajProizvod("Jogurt", 4.29, 2);
        
        while (true) {
            Console.WriteLine("1. Ispis popisa proizvoda");
            Console.WriteLine("2. Kupovina proizvoda");
            Console.WriteLine("3. Izlaz");
            
            int izbor = Convert.ToInt32(Console.ReadLine());
            
            switch (izbor) {
                case 1:
                    trgovina.IspisiPopisProizvoda();
                    break;
                case 2:
                    trgovina.Kupovina();
                    break;
                case 3:
                    Console.WriteLine("Hvala na posjeti!");
                    return;
                default:
                    Console.WriteLine("Nepoznat izbor, pokušajte ponovno.");
                    break;
        static void Main(string[] args){
        IDostava dostava = new DostavaKurirskomSluzbom("Adresa za dostavu", DateTime.Now.AddDays(2)); {

       
        Console.WriteLine("Informacije o proizvodu:");
        Console.WriteLine($"Proizvod: {proizvod.Naziv}");
        Console.WriteLine($"Cijena: {proizvod.Cijena:C}");
        Console.WriteLine($"Stopa PDV-a: {proizvod.StopaPdv}%");

        dostava.IspisiPodatkeDostave();
           }
        }
            }
        }
    }
}

