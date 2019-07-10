using System;
using System.Collections.Generic;

namespace TestApp
{
    public class ToDoList
    {
        private Dictionary<String, Tasks> tasks = new Dictionary<String, Tasks>();
        public List<User> UserList { get; set; }

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

        public bool AddUserToToDoList (User user, ToDoList toDoList)
        {
            bool success = false;

            if (user != null)
            {
                toDoList.UserList.Add(user);

                success = true;

                return success;
            }

            return success;
        }

        public bool AssignUserToTask(string userId, Tasks task)
        {
            bool success = false;

            if (string.IsNullOrEmpty(userId))
            {
                return success;
            }

            task.AssignedUser = userId;

            success = true;

            return success;
        }
    }
}
