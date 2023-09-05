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