using DotNetCoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Data
{
    public class SQLCommanderRepository : ICommanderRepository
    {
        private readonly CommanderContext _context;

        public SQLCommanderRepository(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
