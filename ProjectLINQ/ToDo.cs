using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    public class ToDo
    {
        public string users { get; set; }
        public string Task { get; set; }
        public bool isCompleted { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public ToDo(string users, string task, bool isCompleted, DateTime dateStart, DateTime dateEnd)
        {
            this.users = users;
            this.Task = task;
            this.isCompleted = isCompleted;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;

        }
    }
}
