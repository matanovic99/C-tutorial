public class Trgovina
{
    private List<Proizvod> proizvodi = new List<Proizvod>();

    public void DodajProizvod(string naziv, Cijena cijena, int kolicina)
    {
        Proizvod proizvod = new Proizvod(naziv, cijena, kolicina);
        proizvodi.Add(proizvod);
    }

    public void IspisiPopisProizvoda()
    {
        Console.WriteLine("Popis proizvoda:");
        foreach (Proizvod proizvod in proizvodi)
        {
            Console.WriteLine($"Naziv: {proizvod.Naziv}, Cijena: {proizvod.cijenaProizvoda}, Dostupno: {proizvod.KolicinaNaStanju}");
        }
    }

    public void Kupovina()
    {
        IspisiPopisProizvoda();
        Console.Write("Unesite naziv proizvoda koji želite kupiti: ");
        string nazivProizvoda = Console.ReadLine();

        Proizvod odabraniProizvod = proizvodi.Find(proizvod => proizvod.Naziv.Equals(nazivProizvoda, StringComparison.OrdinalIgnoreCase));

        if (odabraniProizvod != null)
        {
            Console.Write("Unesite količinu koju želite kupiti: ");
            int kolicina = Convert.ToInt32(Console.ReadLine());

            if (kolicina > 0 && kolicina <= odabraniProizvod.KolicinaNaStanju)
            {
                double ukupnaCijena = kolicina * odabraniProizvod.cijenaProizvoda.Iznos;
                Console.WriteLine($"Ukupna cijena: {ukupnaCijena:C}");
                double pdv = PDV.IzracunajPdv( odabraniProizvod);
                Console.WriteLine("Cijena sa Pdv: {pdv}");

                
                IDostava dostava = new DostavaKurirskomSluzbom("Adresa za dostavu", DateTime.Now.AddDays(2));

                Console.WriteLine("*********************************************************");
                Console.WriteLine("Informacije o proizvodu:");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Proizvod: {odabraniProizvod.Naziv}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Cijena: {odabraniProizvod.cijenaProizvoda}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Stopa PDV-a: {odabraniProizvod}%");
                Console.WriteLine("*********************************************************");

                dostava.Isporuci();

                 IDostava dostava1 = new DostavaPostom("Adresa za dostavu", DateTime.Now.AddDays(2));

                Console.WriteLine("*********************************************************");
                Console.WriteLine("Informacije o proizvodu:");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Proizvod: {odabraniProizvod.Naziv}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Cijena: {odabraniProizvod.cijenaProizvoda}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Stopa PDV-a: {odabraniProizvod}%");
                Console.WriteLine("*********************************************************");

                dostava.Isporuci();

                IDostava dostava2 = new OsobnoPreuzimanje("Adresa za dostavu", DateTime.Now.AddDays(2));

                Console.WriteLine("*********************************************************");
                Console.WriteLine("Informacije o proizvodu:");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Proizvod: {odabraniProizvod.Naziv}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Cijena: {odabraniProizvod.cijenaProizvoda}");
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"Stopa PDV-a: {odabraniProizvod}%");
                Console.WriteLine("*********************************************************");

                dostava.Isporuci();



                
                odabraniProizvod.KolicinaNaStanju -= kolicina;
            }
            else
            {
                Console.WriteLine("Nevažeća količina ili nedostatna zalihama.");
            }
        }
        else
        {
            Console.WriteLine("Proizvod nije pronađen.");
        }
    }
}
