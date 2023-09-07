public abstract class Placanje {
    public virtual void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Kartice : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje karticom u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Novcanice : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje novčanicama u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

public class Cekovi : Placanje {
    public override void Plati(double ukupanIznos) {
        Console.WriteLine($"Plaćanje čekovima u iznosu od {ukupanIznos:C2} je uspješno izvršeno.");
    }
}

