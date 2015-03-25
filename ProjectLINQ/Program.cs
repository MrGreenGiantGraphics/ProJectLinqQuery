using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToDo> todoList = new List<ToDo>
            {
                new ToDo("David","Clean the Car", false, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-1)),
                new ToDo("Mike","Clean the Dishes", true, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-2)),
                new ToDo("Sue","Watch the Program", false, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-2)),
                new ToDo("Allen","Paint the House", true, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-4)),
                new ToDo("Smith","Make the Pizza", false, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-2)),
                new ToDo("Chuck","Build the desk", true, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-1))
            };

            Console.WriteLine("Task read out page");

            // Get the True or False states
            var getData1 = todoList.Where(to => to.isCompleted == true);
            // Get The Users that have specific charters in in there name.
            var getData2 = todoList.Where(to => to.Task.Contains("Program"));
            // Get The Users that have only 4 letters in there name.
            var getData3 = todoList.Where(to => to.users.Length == 4);
            // Get Task that was started more then 8 days ago
            var getData4 = todoList.Where(to => to.dateStart < DateTime.Now.AddDays(-8));
            // Get Task that was Completed less then 2 days ago
            var getData5 = todoList.Where(to => to.dateEnd >= DateTime.Now.AddDays(-2));
            // Get The Users that have more then 5 letters in there name.
            var getData6 = todoList
                .OrderByDescending(to => to.users)
                .Where(to => to.users.Length == 5);
            // Loop thru the List of Tasks
            foreach (var g in getData2)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("Name: {0}", g.users);
                Console.WriteLine("Task: {0}", g.Task);
                Console.WriteLine("Is Completed?: {0}", g.isCompleted);
                Console.WriteLine("Task Started: {0}", g.dateStart);
                Console.WriteLine("Task Ended: {0}", g.dateEnd);
            }

            Console.ReadLine();
        }
    }
}
