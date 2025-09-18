public class Pohon : Tanaman
{
    public double TinggiMeter { get; set; }

    public Pohon(string spesies, int usiaBulan, double tinggi) : base(spesies, usiaBulan)
    {
        this.TinggiMeter = tinggi;
    }

    public override void Deskripsi()
    {
        base.Deskripsi();
        Console.WriteLine($"Pohon ini sudah setinggi {TinggiMeter} meter dan akarnya bertipe {SistemAkar.Tipe}.");
    }
}