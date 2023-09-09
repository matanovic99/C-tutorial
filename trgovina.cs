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
                double pdv = PDV.IzracunajPdv(odabraniProizvod);
                Console.WriteLine($"Cijena sa Pdv: {pdv}");
                Console.WriteLine("Odaberite način plaćanja: 1. Kartice, 2. Novčanice, 3. Čekovi");
                int izborPlacanja = Convert.ToInt32(Console.ReadLine());

                Placanje placanje = null;

                switch (izborPlacanja)
                {
                    case 1:
                        placanje = new Kartice();
                        break;
                    case 2:
                        placanje = new Novcanice();
                        break;
                    case 3:
                        placanje = new Cekovi();
                        break;
                    default:
                        Console.WriteLine("Nepoznat izbor plaćanja, kupovina otkazana.");
                        return;
                }

                placanje.Plati(ukupnaCijena);
                Console.WriteLine("Hvala na kupovini!");


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
        Console.WriteLine("Koji tip dostave zelite:");
        Console.WriteLine("*********************************************************");
        Console.WriteLine("1.Dostava Kurirskom sluzbom");
        Console.WriteLine("*********************************************************");
        Console.WriteLine("2.Dostava postom");
        Console.WriteLine("*********************************************************");
        Console.WriteLine("3.Osobno preuzimanje");
        Console.WriteLine("*********************************************************");
        int tipDostave = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" adresa dostave: ");
        string adresa = Console.ReadLine();
        Console.WriteLine("ime i prezime: ");
        string ime = Console.ReadLine();
        IDostava dostava = null;
        if (tipDostave == 1)
        {
            dostava = new DostavaKurirskomSluzbom(ime, adresa, DateTime.Now.AddDays(2));


        }
        else if (tipDostave == 2)
        {
            dostava = new DostavaPostom(ime, adresa, DateTime.Now.AddDays(2));

        }
        else
        {
            dostava = new OsobnoPreuzimanje(ime, adresa, DateTime.Now.AddDays(2));

        }

        dostava.Isporuci();
    }
}
