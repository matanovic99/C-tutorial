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
            }
        }
    }
}

class Trgovina {
    private List<Proizvod> popisProizvoda = new List<Proizvod>();
    private Placanje placanje;
    
    public void DodajProizvod(string naziv, double cijena, int kolicina) {
        popisProizvoda.Add(new Proizvod { Naziv = naziv, Cijena = cijena, KolicinaNaStanju = kolicina });
    }
    
    public void IspisiPopisProizvoda() {
        Console.WriteLine("Popis proizvoda:");
        foreach (var proizvod in popisProizvoda) {
            if (proizvod.KolicinaNaStanju > 0) {
                Console.WriteLine($"{proizvod.Naziv} - {proizvod.Cijena} kn");
            }
        }
    }
    
    public void Kupovina() {
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
                ukupanIznos += proizvod.Cijena;
                proizvod.KolicinaNaStanju--;
            } else {
                Console.WriteLine($"Proizvod {imeProizvoda} nije dostupan ili nema više na stanju.");
            }
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