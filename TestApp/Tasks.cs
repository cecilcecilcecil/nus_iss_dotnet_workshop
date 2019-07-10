using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Tasks : ToDoList
    {
        private String description = null;
        private bool isComplete { get; set; } = false;
        //hi


        public Tasks(String description)
        {
            this.description = description;
        }

        public Tasks(String description, bool isComplete)
        {
            this.description = description;
            this.isComplete = isComplete;
        }

        public String getDescription()
        {
            return description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
    }
}
