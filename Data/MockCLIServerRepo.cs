using System.Collections.Generic;
using CLIServer.Models;

namespace CLIServer.Data{
    public class MockCLIServerRepo : IServerRepo{
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands(){
            var commands = new List<Command>{
                new Command{Id=0,HowTo="make toast",Line="toast bread", Platform="kitchen"},
                new Command{Id=1,HowTo="make eggs",Line="crack egg", Platform="kitchen"},
                new Command{Id=2,HowTo="make sandwhich",Line="cut bread", Platform="chopping board"}
            };
            
            return commands;
        }

        public Command GetCommandById(int id){
            return new Command{Id=0,HowTo="make toast",Line="toast bread", Platform="kitchen"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}