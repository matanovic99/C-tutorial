

public class PDV
{

    public static double IzracunajPdv(Proizvod proizvod)
    {
        return (proizvod.cijenaProizvoda.Iznos * 0.25);
    }

    public static double IzracunajUkupniPdv(List<Proizvod> proizvodi)
    {
        double ukupniPdv = 0;
        foreach (var proizvod in proizvodi)
        {
            ukupniPdv += IzracunajPdv(proizvod);
        }
        return ukupniPdv;
    }
}



