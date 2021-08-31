using System;
using System.Collections.Generic;
using System.Linq;
using CLIServer.Models;

namespace CLIServer.Data{
    public class SqlCLIServerRepo : IServerRepo
    {
        private readonly CLIServerContext _context;

        public SqlCLIServerRepo(CLIServerContext context){
            _context=context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd==null){
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd==null){
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Remove(cmd);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateCommand(Command cmd)
        {
            //nothing
        }

        IEnumerable<Command> IServerRepo.GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        Command IServerRepo.GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}