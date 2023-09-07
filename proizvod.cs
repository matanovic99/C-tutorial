public class Proizvod
{
    public string Naziv { get; set; }
    public Cijena cijenaProizvoda { get; set; }
    public int KolicinaNaStanju { get; set; }
    

    public Proizvod(string Naziv, Cijena Cijena, int kolicina)
    {
        this.Naziv = Naziv;
        this.cijenaProizvoda = Cijena;
        this.KolicinaNaStanju = kolicina;
        
    }
}
public interface IDostava
{
     public string TipDostave {get; set;}
    public string Adresa { get; set;}
    public DateTime DatumDostave { get; set;}
    void Isporuci();
}