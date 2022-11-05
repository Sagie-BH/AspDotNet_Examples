using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskRepository : IRepository<TasksManager>
    {
        private readonly TasksDbContext context;

        public TaskRepository(TasksDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<TasksManager> GetAll()
        {
            return context.TaskManager;
        }
        public TasksManager GetById(int id)
        {
            return context.TaskManager.SingleOrDefault(t => t.Id == id);
        }
        public bool Create(TasksManager entity)
        {
            try
            {
                context.TaskManager.Add(entity);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(TasksManager entity)
        {
            try
            {
                context.TaskManager.Update(entity);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                context.Remove(GetById(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
