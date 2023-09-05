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
        }