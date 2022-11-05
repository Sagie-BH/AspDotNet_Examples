using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerAsp.Net.ViewModels
{
    public class TaskViewModel
    {
        public string Title { get; set; }
        //public int Priority { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public bool Done { get; set; }
    }
}
