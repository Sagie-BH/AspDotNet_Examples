using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManagerAsp.Net.ViewModels;

namespace TaskManagerAsp.Net.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TasksManager, TaskViewModel>();
        }
    }
}
