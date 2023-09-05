class Trgovina {
    private List<Proizvod> popisProizvoda = new List<Proizvod>();
    private Placanje placanje;
    
    public void DodajProizvod(string naziv, double cijena, int kolicina) {
        Cijena cijenaProizvoda = new Cijena(cijena, "€");
        Proizvod noviProizvod = new Proizvod(naziv, cijenaProizvoda, kolicina, stopaPdv);
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
