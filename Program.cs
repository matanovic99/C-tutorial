class Program
{
    private List<Proizvod> proizvodi = new List<Proizvod>();


  

    static void Main(string[] args)

    {
        Trgovina trgovina = new Trgovina();
        trgovina.DodajProizvod("Mlijeko", new Cijena(7.99, "€"), 5);
        trgovina.DodajProizvod("Kruh", new Cijena(3.49, "€"), 10);
        trgovina.DodajProizvod("Jogurt", new Cijena(4.29, "€"), 2);

        while (true)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("1. Ispis popisa proizvoda");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("2. Kupovina proizvoda");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("3. Izlaz");
            Console.WriteLine("*********************************************************");

            int izbor = Convert.ToInt32(Console.ReadLine());

            switch (izbor)
            {
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


                
                    int izborProizvoda = Convert.ToInt32(Console.ReadLine());
                    Proizvod proizvod = [izborProizvoda]; 

                    IDostava dostava = new DostavaKurirskomSluzbom("Adresa za dostavu", DateTime.Now.AddDays(2));

                    Console.WriteLine("Informacije o proizvodu:");
                    Console.WriteLine($"Proizvod: {proizvod.Naziv}");
                    Console.WriteLine($"Cijena: {proizvod.cijenaProizvoda}");
                    Console.WriteLine($"Stopa PDV-a: {proizvod.PDV}%");

                    dostava.Isporuci();

                    IDostava dostava1 = new DostavaPostom("Adresa za dostavu", DateTime.Now.AddDays(1));

                    Console.WriteLine("Informacije o proizvodu:");
                    Console.WriteLine($"Proizvod: {proizvod.Naziv}");
                    Console.WriteLine($"Cijena: {proizvod.cijenaProizvoda}");
                    Console.WriteLine($"Stopa PDV-a: {proizvod.PDV}%");

                    dostava1.Isporuci();

                    IDostava dostava2 = new OsobnoPreuzimanje("Adresa za dostavu", DateTime.Now.AddDays(2));

                    Console.WriteLine("Informacije o proizvodu:");
                    Console.WriteLine($"Proizvod: {proizvod.Naziv}");
                    Console.WriteLine($"Cijena: {proizvod.cijenaProizvoda}");
                    Console.WriteLine($"Stopa PDV-a: {proizvod.PDV}%");

                    dostava2.Isporuci();


            }
        }
    }
}


