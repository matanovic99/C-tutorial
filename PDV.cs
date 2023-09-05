 public class PDV
{
    
    public static double IzracunajPdv(Proizvod proizvod, double stopaPdv)
    {
        return (proizvod.cijenaProizvoda.Iznos * stopaPdv) / 100;
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



