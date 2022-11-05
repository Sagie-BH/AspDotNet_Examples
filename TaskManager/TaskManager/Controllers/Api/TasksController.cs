using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;
using TaskManagerAsp.Net.ViewModels;

namespace TaskManagerAsp.Net.Controllers.Api
{
    [Route("api/Tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IRepository<TasksManager> repository;
        private readonly IMapper mapper;

        public TasksController(IRepository<TasksManager> _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        public ActionResult<IEnumerable<TaskViewModel>> GetAllTasks()
        {
            return Ok(mapper.Map<IEnumerable<TaskViewModel>>(repository.GetAll()));
        }
        [HttpGet("{id}")]
        public ActionResult<TaskViewModel> GetById(int id)
        {
            var task = repository.GetById(id);
            if (task != null)
            {
                return Ok(mapper.Map<TaskViewModel>(task));
            }
            return NotFound();
        }
    }
}
