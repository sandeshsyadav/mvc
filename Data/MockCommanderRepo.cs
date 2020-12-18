using System.Collections.Generic;
using Commander.Data;
using Commander.models;

namespace CommanderData
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Create an Api", Line="Create folder", Platfrom= "Visual Code"},
                new Command{Id=2, HowTo="Create an Docker ", Line="Create docker", Platfrom= "Docker"},
                new Command{Id=3, HowTo="Create a DB", Line="Create DB", Platfrom= "DB"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Create an Api", Line="Create folder", Platfrom= "Visual Code"};
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