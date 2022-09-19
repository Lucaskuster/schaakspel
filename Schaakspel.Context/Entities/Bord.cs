namespace Schaakspel.Context.Entities
{
    public class Bord
    {
        public List<Vak> vakken { get; set; }
        
        public Bord(List<StukBewogen> oldEvents)
        {
            oldEvents.ForEach(x =>
            {
                vakken.Add(new Vak(x.vak.location, x.vak.stuk));
            });
        }
    }
}
