public class Bunga : Tanaman
{
    public string WarnaBunga { get; set; }

    public Bunga(string spesies, int usiaBulan, string warna) : base(spesies, usiaBulan)
    {
        this.WarnaBunga = warna;
    }

    public override void Deskripsi()
    {
        base.Deskripsi();
        Console.WriteLine($"Bunga ini memiliki warna {WarnaBunga}.");
    }
}