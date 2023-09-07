public class Cijena {
    public double Iznos { get; set; }
    public string Valuta { get; set; }
    public double StopaPdv { get; set; }

    public Cijena(double iznos, string valuta, double stopaPdv) {
        Iznos = iznos;
        Valuta = valuta;
        StopaPdv = stopaPdv;    
    }

    public override string ToString() {
        return $"{Iznos:C2} {Valuta} {StopaPdv:0.##}";
    }
}
