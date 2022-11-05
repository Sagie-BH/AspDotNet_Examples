using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface IRepository
    {
        IEnumerable<Command> GetAll();
        Command GetCommandById(int id);
    }
}