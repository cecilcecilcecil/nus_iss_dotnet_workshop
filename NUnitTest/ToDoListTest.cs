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

        private Tasks taskItem1;
        private Tasks taskItem2;
        private ToDoList TDL;

        [TestInitialize]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUp() 
        {

            //Comments from YY
            //Initialise Test Fixtures
            taskItem1 = new Tasks("Task Item 1 desc");
            taskItem2 = new Tasks("Task Item 2 desc");
            TDL = new ToDoList();
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
            taskItem1 = null;
            taskItem2 = null;
            TDL = null;
        }

        [TestMethod]
        public void TestAddTask()
        {
            //Add Item to ToDoList
            TDL.addTask(taskItem1);

            //Check ToDoList size is equal to the number of ToDoList added
            Assert.AreEqual(1, TDL.getAllTasks().Count);

            //Check ToDoList equals to the ToDoList specify
            Assert.AreEqual(taskItem1, TDL.getTask(taskItem1.getDescription()));

        }

        [TestMethod]
        public void TestgetStatus()
        {
            ToDoList todoList = new ToDoList();

            Tasks getstatus = new Tasks("test");
            todoList.addTask(getstatus);
            Assert.IsTrue(todoList.getStatus()== true);
            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void TestgetUpdate()
        {

            Assert.Fail("Not implemented yet");
        }


        [TestMethod]
        public void TestRemoveTask()
        {
            //Add Item to ToDoList
            TDL.addTask(taskItem1);
            TDL.addTask(taskItem2);

            //Check ToDoList size is equal to the number of ToDoList added
            Assert.AreEqual(2, TDL.getAllTasks().Count);

            // Remove 1 item in To Do List
            Tasks taskRemove = TDL.removeTask(taskItem1.getDescription()); // remove testItem1

            // Check the removed item in To Do List is the task item to remove.
            Assert.AreEqual(taskRemove.getDescription(), taskItem1.getDescription());

            //Check ToDoList size after 1 item is removed
            Assert.AreEqual(1, TDL.getAllTasks().Count);

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
