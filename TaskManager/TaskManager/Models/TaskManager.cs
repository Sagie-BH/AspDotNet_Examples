using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerAsp.Net.Models;
using TaskManagerAsp.Net.Models.ValidationAttributes;

namespace TaskManager.Models
{
    public class TasksManager
    {
        public int Id { get; set; }
        [Required]
        [StartDateValidation]
        public DateTime StartTime { get; set; }
        [Required]
        [EndDateValidation]
        public DateTime EndTime { get; set; }
        [Required]
        public bool Done { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Title length must be less than 255")]
        public string Title { get; set; }
        [Required]
        [Range(0,100)]
        public int Priority { get; set; }
    }
}
