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
