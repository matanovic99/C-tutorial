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
