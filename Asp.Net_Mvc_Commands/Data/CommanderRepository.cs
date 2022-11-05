using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class CommanderRepository : IRepository
    {
        public IEnumerable<Command> GetAll()
        {
            List<Command> lists = new List<Command>
            {
              new Command{Id = 0, HowTo="Drink", Line="Beer", Platform="Holla"},
              new Command{Id = 1, HowTo="Jump", Line="First", Platform="Bamba"},
              new Command{Id = 2, HowTo="Walk", Line="Middle", Platform="Microsoft"},
              new Command{Id = 3, HowTo="PubG", Line="Cd", Platform="Cod"},
            };
            return lists;
        }

        public Command GetCommandById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id );
        }
    }
}