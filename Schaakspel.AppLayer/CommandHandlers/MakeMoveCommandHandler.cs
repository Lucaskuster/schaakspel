using Schaakspel.AppLayer.Commands;
using Schaakspel.Context.Entities;

namespace Schaakspel.AppLayer.CommandHandlers;

public class MakeMoveCommandHandler
{
    
    public MakeMoveCommandHandler()
    {

    }
    
    public void MakeMoveCommand()
    {
        
    }

    public Bord HandleCommand(MakeMoveCommand command)
    {
        //TODO: Event ophalen uit;
        var previousEvents = new List<Event>();

        var bord = new Bord(previousEvents);

        var pieceMovedEvent = new StukBewogen(command.Stuk, command.Vak);

        //TODO: Event opslaan in database;

        return bord;
    }

}