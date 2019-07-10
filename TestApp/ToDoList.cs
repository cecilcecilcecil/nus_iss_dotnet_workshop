using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class ToDoList
    {
        private Dictionary<String, Tasks> tasks = new Dictionary<String, Tasks>();

        public void addTask(Tasks task)
        {
            tasks.Add(Guid.NewGuid().ToString(), task);
        }
        public void completeTask(String description)
        {
            // Add code here
        }
        public bool getStatus(String description)
        {
            //Add code here
            return false;
        }
        public Tasks getTask(String description)
        {
            // Add code here
            return null;
        }
        public Tasks removeTask(String description)
        {
            // Add code here
            return null;
        }
        public List<Tasks> getAllTasks()
        {
            // Add code here
            return null;
        }
        public List<Tasks> getCompletedTasks()
        {
            // Add code here
            return null;
        }
    }
}
