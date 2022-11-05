using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManagerAsp.Net.Models
{
    public class StartDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TasksManager task = (TasksManager)validationContext.ObjectInstance;
            if (task.StartTime < DateTime.Now)
            {
                return new ValidationResult("Start Time can't be in the past");
            }
            else return ValidationResult.Success;
               
        }
    }
}
