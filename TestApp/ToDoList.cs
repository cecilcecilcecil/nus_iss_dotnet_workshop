using System;
using System.Collections.Generic;

namespace TestApp
{
    public class ToDoList
    {
        private Dictionary<String, Tasks> tasks = new Dictionary<String, Tasks>();

        public void addTask(Tasks task)
        {
            tasks.Add(task.getDescription(), task);
        }
        public void completeTask(String description)
        {
            // Add code here
        }
        public bool getStatus(String description)
        {
            return true;
        }
        public Tasks getTask(String description)
        {
            // Add code here
            return tasks[description];
        }
        public Tasks removeTask(String description)
        {
            // Add code here
            Tasks task = tasks[description];
            tasks.Remove(description);

            return task;
        }
        public Dictionary<String, Tasks> getAllTasks()
        {
            // Add code here
            return tasks;
        }
        public Dictionary<String, Tasks> getCompletedTasks()
        {
            // Add code here
            return null;
        }

        public bool getStatus()
        {
            throw new NotImplementedException();
        }
    }
}
