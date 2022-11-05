using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManagerAsp.Net.Models.ValidationAttributes
{
    public class EndDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TasksManager task = (TasksManager)validationContext.ObjectInstance;
            if (task.StartTime > task.EndTime)
            {
                return new ValidationResult("End Time must be after start time");
            }
            else return ValidationResult.Success;
        }
    }
}
