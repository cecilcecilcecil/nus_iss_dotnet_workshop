using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace NUnitTest
{
    [TestClass]
    public class ToDoListTest : ToDoList
    {
        private ToDoList toDoList;
        private Tasks task1;

        [TestInitialize]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUp() 
        {
            toDoList = new ToDoList
            {
                UserList = new List<User>()
            };

            task1 = new Tasks("test");
        }

        [TestCleanup]
        [ExpectedException(typeof(ArgumentException))]
        public void tearDown()
        {
            // Uninitialise test Fixtures
        }

        [TestMethod]
        public void TestAddTask()
        {
            //Given
            ToDoList todoList = new ToDoList();

            //When
            Tasks newTask = new Tasks("test");
            todoList.addTask(newTask);

            //Then
            List<Tasks> taskList = todoList.getAllTasks();

            foreach (var task in taskList)
            {
                if (task.getDescription() == newTask.getDescription())
                {
                    Console.WriteLine(task.getDescription());
                }
            }

            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void TestgetStatus()
        {
            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void TestRemoveTask()
        {
            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void TestGetCompletedTasks()
        {
            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void Test_AddUserToToDoList_Success()
        {
            //Given
            User user = CreateNewUser();

            //When
            bool success = toDoList.AddUserToToDoList(user, toDoList);

            //Then
            Assert.IsTrue(success);
            Assert.IsNotNull(toDoList.UserList);
            Assert.IsTrue(toDoList.UserList.Count == 1);
        }

        [TestMethod]
        public void Test_AddNullUserToToDoList_Failure()
        {
            //Given
            User user = null;

            //When
            bool success = toDoList.AddUserToToDoList(user, toDoList);
            
            //Then
            Assert.IsFalse(success);
            Assert.IsNotNull(toDoList.UserList);
            Assert.IsTrue(toDoList.UserList.Count == 0);
        }

        [TestMethod]
        public void Test_AssignUserToTask_Success()
        {
            //Given
            User user = CreateNewUser();

            //When
            bool success = task1.AssignUserToTask("test", task1);

            //Then
            Assert.IsTrue(success);
            Assert.IsNotNull(task1.AssignedUser);
            Assert.IsTrue(task1.AssignedUser == "test");
        }

        public User CreateNewUser()
        {
            User user = new User
            {
                Name = "David",
                UserId = Guid.NewGuid().ToString()
            };

            return user;
        }
    }
}
