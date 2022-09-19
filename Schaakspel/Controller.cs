using Schaakspel.AppLayer.CommandHandlers;
using Schaakspel.AppLayer.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Schaakspel
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoveController : ControllerBase
    {
        private MakeMoveCommandHandler _makeMoveCommandHandler;

        public MoveController(MakeMoveCommandHandler makeMoveCommandHandler)
        {
            _makeMoveCommandHandler = makeMoveCommandHandler;
        }

        [HttpPut]
        public IActionResult MakeMove(MakeMoveCommand makeMoveCommand)
        {
            if (ModelState.IsValid)
            {
                _makeMoveCommandHandler.HandleCommand(makeMoveCommand);
            }
            return Ok();
        }
    }
}