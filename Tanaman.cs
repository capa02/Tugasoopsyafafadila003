using System;
public class Tanaman
{
    private string _spesies;
    private int _usiaBulan;
    private Akar _sistemAkar;
    public string Spesies
    {
        get { return _spesies; }
        set { _spesies = value; }
    }

    public int UsiaBulan
    {
        get { return _usiaBulan; }
        set { _usiaBulan = value; }
    }
    public Akar SistemAkar
    {
        get { return _sistemAkar; }
        set { _sistemAkar = value; }
    }

    public Tanaman(string spesies, int usiaBulan)
    {
        this._spesies = spesies;
        this._usiaBulan = usiaBulan;
        this._sistemAkar = new Akar(10, "Serabut");
    }
    public void Tumbuh()
    {
        _usiaBulan++;
        Console.WriteLine($"Tanaman spesies {_spesies} tumbuh 1 bulan. Usia sekarang {_usiaBulan} bulan.");
    }

    public void Tumbuh(int tahun)
    {
        _usiaBulan += tahun * 12;
        Console.WriteLine($"Tanaman spesies {_spesies} tumbuh {tahun} tahun. Usia sekarang {_usiaBulan} bulan.");
    }
    public virtual void Deskripsi()
    {
        Console.WriteLine($"Tanaman ini adalah spesies {_spesies} dengan usia {_usiaBulan} bulan.");
    }
}
