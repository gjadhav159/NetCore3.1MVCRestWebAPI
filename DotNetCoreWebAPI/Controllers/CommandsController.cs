using DotNetCoreWebAPI.Data;
using DotNetCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepository _repository;

        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;
        }
        //private readonly MockCommanderRepository _repository = new MockCommanderRepository();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandsItem = _repository.GetAllCommands();
            return Ok(commandsItem);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
