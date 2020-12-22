using DotNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var command = new List<Command>
            {
                new Command { HowTo = "Boil an Egg", Id = 0, Line = "Boil Water", Platform = "Kettel & Pan" },
                new Command { HowTo = "Cut bread", Id = 1, Line = "Get a Knife", Platform = "knife and" },
                new Command { HowTo = "Make a Cup of Tea", Id = 2, Line = "Boil Water", Platform = "Kettel & Pan" }
            };
            return command;
        }

        public Command GetCommandById(int id)
        {
            return new Command { HowTo = "Boil an Egg", Id = 0, Line = "Boil Water", Platform = "Kettel & Pan" };
        }
    }
}
