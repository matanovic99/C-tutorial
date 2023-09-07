public class DostavaPostom : IDostava
{
    public string TipDostave { get; set;} 
    public string Ime {get; set;}
    public string Adresa { get; set;}
    public DateTime DatumDostave { get; set;}

    public DostavaPostom(string ime,string adresa, DateTime datumDostave)

    {
        this.TipDostave= "Dostava poštom";
        this.Adresa = adresa;
        this.DatumDostave = datumDostave;
        this.Ime = ime;
    }

    public void Isporuci()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}


public class DostavaKurirskomSluzbom : IDostava
{
    public string TipDostave { get; set; }  
    public string Ime {get; set;}
    public string Adresa { get; set; }
    public DateTime DatumDostave { get; set; }

    public DostavaKurirskomSluzbom(string ime, string adresa, DateTime datumDostave)
    {
        this.TipDostave= "Dostava kurirskom službom";
        this.Adresa = adresa;
        this.DatumDostave = datumDostave;
        this.Ime = ime;
        
    }

    public void Isporuci()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}

public class OsobnoPreuzimanje : IDostava
{
     public string TipDostave { get; set; } 
     public string Ime {get; set;} 
    public string Adresa { get; set; }
    
    public DateTime DatumDostave { get; set; }

    public OsobnoPreuzimanje(string ime, string adresa, DateTime datumDostave)
    {
        this.TipDostave = "	Osobno preuzimanje";
        this.Adresa= adresa;
        this.DatumDostave = datumDostave ;
        this.Ime = ime;

    }
     public void Isporuci()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }


}