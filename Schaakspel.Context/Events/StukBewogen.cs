namespace Schaakspel.Context.Entities
{
    public class StukBewogen : Event
    {
       public StukBewogen(Stuk stuk, Vak vak)
        {
            this.stuk = stuk;
            this.vak = vak;
            EventTime = DateTimeOffset.UtcNow;
        }

       public Vak vak { get; set; }

       public Stuk stuk { get; set; }

       public DateTimeOffset EventTime { get; set; }
    }
}
