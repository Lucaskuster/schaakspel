using Schaakspel.Context.Entities;

namespace Schaakspel.AppLayer.Commands;

public class MakeMoveCommand
{
    // Het commando om te bewegen
    public MakeMoveCommand()
    {
        
    }
public Stuk Stuk { get; set; }

     public Vak Vak { get; set; }
}