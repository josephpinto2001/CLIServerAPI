using System.Collections.Generic;
using CLIServer.Models;

namespace CLIServer.Data{
    public interface IServerRepo{
        
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}