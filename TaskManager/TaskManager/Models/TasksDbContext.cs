using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TasksDbContext : DbContext
    {
        public DbSet<TasksManager> TaskManager { get; set; }

        public TasksDbContext(DbContextOptions<TasksDbContext> options): base(options)
        {

        }
    }
}