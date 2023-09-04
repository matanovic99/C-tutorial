using System.Security.Cryptography.X509Certificates;

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


public class Proizvod {
    public string Naziv { get; set; }
    public Cijena cijenaProizvoda { get; set; }
    public int KolicinaNaStanju { get; set; }
    public double stopaPdv {get; set; }     
    
    public Proizvod(string Naziv, Cijena Cijena, int kolicina, double stopaPdv){
        this.Naziv = Naziv; 
        this.cijenaProizvoda = Cijena;
        this.KolicinaNaStanju = kolicina;
        this.stopaPdv = stopaPdv;
    }
    public class PDV
{
    PDV
    public static double IzracunajPdv(Proizvod proizvod, double stopaPdv)
    {
        return (proizvod.Cijena * stopaPdv) / 100;
    }

    public static double IzracunajUkupniPdv(List<Proizvod> proizvodi, double stopaPdv)
    {
        double ukupniPdv = 0;
        foreach (var proizvod in proizvodi)
        {
            ukupniPdv += IzracunajPdv(proizvod, stopaPdv);
        }
        return ukupniPdv;
    }
}


}

public abstract class Placanje {
    public virtual void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Kartice : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje karticom u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Novcanice : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje novčanicama u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Cekovi : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje čekovima u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Cijena {
    public double Iznos { get; set; }
    public string Valuta { get; set; }

    public Cijena(double iznos, string valuta) {
        Iznos = iznos;
        Valuta = valuta;
    }

    public override string ToString() {
        return $"{Iznos:C2} {Valuta}";
    }
}


class Trgovina {
    private List<Proizvod> popisProizvoda = new List<Proizvod>();
    private Placanje placanje;
    
    public void DodajProizvod(string naziv, double cijena, int kolicina) {
        Cijena cijenaProizvoda = new Cijena(cijena, "€");
        Proizvod noviProizvod = new Proizvod(naziv, cijenaProizvoda, kolicina);
        PDV pdv = new PDV(naziv,cijenaProizvoda);
        popisProizvoda.Add(noviProizvod);
    }
    
    public void IspisiPopisProizvoda() {
        Console.WriteLine("Popis proizvoda:");
        foreach (var proizvod in popisProizvoda) {
            if (proizvod.KolicinaNaStanju > 0) {
                Console.WriteLine($"{proizvod.Naziv} - {proizvod.cijenaProizvoda.Iznos} {proizvod.cijenaProizvoda.Valuta} (kom. {proizvod.KolicinaNaStanju})");
            }
        }
    }
    
    public void Kupovina() {
        this.IspisiPopisProizvoda();

        Console.WriteLine("Unesite broj proizvoda za kupiti:");
        int brojProizvoda = Convert.ToInt32(Console.ReadLine());
        
        List<Proizvod> kupljeniProizvodi = new List<Proizvod>();
        double ukupanIznos = 0;
        
        for (int i = 0; i < brojProizvoda; i++) {
            Console.WriteLine($"Unesite ime proizvoda {i + 1}:");
            string imeProizvoda = Console.ReadLine();
            
            Proizvod proizvod = popisProizvoda.Find(p => p.Naziv == imeProizvoda && p.KolicinaNaStanju > 0);
            
            if (proizvod != null) {
                kupljeniProizvodi.Add(proizvod);
                ukupanIznos += proizvod.cijenaProizvoda.Iznos;
                proizvod.KolicinaNaStanju--;
            } else {
                Console.WriteLine($"Proizvod {imeProizvoda} nije dostupan ili nema više na stanju.");
            }
            Console.WriteLine("Unesite stopu PDV-a (u postocima):");
        double stopaPdv = Convert.ToDouble(Console.ReadLine());

        
        double ukupniPdv = PDV.IzracunajUkupniPdv(kupljeniProizvodi, stopaPdv);

        Console.WriteLine($"Ukupna cijena proizvoda: {ukupanIznos:C}");
        Console.WriteLine($"Ukupan PDV: {ukupniPdv:C}");
        Console.WriteLine($"Ukupno za platiti: {ukupanIznos + ukupniPdv:C}");
        }
        
        Console.WriteLine("Odaberite način plaćanja: 1. Kartice, 2. Novčanice, 3. Čekovi");
        int izborPlacanja = Convert.ToInt32(Console.ReadLine());
        
        switch (izborPlacanja) {
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
        
        placanje.Plati(ukupanIznos);
        Console.WriteLine("Hvala na kupovini!");
    }
}


public interface IDostava
{
    string TipDostave { get; }
    string Adresa { get; }
    DateTime DatumDostave { get; }

    void IspisiPodatkeDostave();
}


public class OsobnoPreuzimanje : IDostava
{
    public string TipDostave => "Osobno preuzimanje";
    public string Adresa { get; }
    public DateTime DatumDostave { get; }

    public OsobnoPreuzimanje(string adresa, DateTime datumDostave)
    {
        Adresa = adresa;
        DatumDostave = datumDostave;
    }

    public void IspisiPodatkeDostave()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}


public class DostavaPostom : IDostava
{
    public string TipDostave => "Dostava poštom";
    public string Adresa { get; }
    public DateTime DatumDostave { get; }

    public DostavaPostom(string adresa, DateTime datumDostave)
    {
        Adresa = adresa;
        DatumDostave = datumDostave;
    }

    public void IspisiPodatkeDostave()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}


public class DostavaKurirskomSluzbom : IDostava
{
    public string TipDostave => "Dostava kurirskom službom";
    public string Adresa { get; }
    public DateTime DatumDostave { get; }

    public DostavaKurirskomSluzbom(string adresa, DateTime datumDostave)
    {
        Adresa = adresa;
        DatumDostave = datumDostave;
    }

    public void IspisiPodatkeDostave()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}
