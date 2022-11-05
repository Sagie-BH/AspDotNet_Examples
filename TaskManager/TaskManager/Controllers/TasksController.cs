using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManagerAsp.Net.Controllers
{
    public class TasksController : Controller
    {
        private readonly IRepository<TasksManager> _taskRepositoryService;
        public TasksController(IRepository<TasksManager> taskRepositoryService)
        {
            this._taskRepositoryService = taskRepositoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View(_taskRepositoryService.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewTask(TasksManager task)
        {
            if (ModelState.IsValid)
            {
                if(_taskRepositoryService.Create(task))
                {
                    return View("Index");
                }
                else
                {
                    return View("Index", task);
                }
            }
            else return View("Index");
        }
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                bool deleted = _taskRepositoryService.Delete(id);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(TasksManager task)
        {
            if (ModelState.IsValid)
            {
                if (_taskRepositoryService.Update(task))
                {
                    return View("Index");
                }
                else
                {
                    return View("Edit", task);
                }
            }
            else return View("Edit", task);
        }
        public ActionResult Details(TasksManager task)
        {
            return View(task);
        }
    }
}
