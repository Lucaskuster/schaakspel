using System.IO.Pipelines;

namespace Schaakspel.Context.Entities;

public class Vak
{
    public Vak(int location, Stuk stuk)
    {
        this.location = location;
        this.stuk = stuk;
    }

    public int location { get; set; }
    public Stuk stuk { get; set; }
}