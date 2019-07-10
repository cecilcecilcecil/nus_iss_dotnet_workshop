using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace NUnitTest
{
    [TestClass]
    public class ToDoListTest : ToDoList
    {
        private Tasks taskItem1;
        private Tasks taskItem2;
        private ToDoList TDL;

        [TestInitialize]
        [ExpectedException(typeof(ArgumentException))]
        public void setUp() 
        {

            //Comments from YY
            //Initialise Test Fixtures
            taskItem1 = new Tasks("Task Item 1 desc");
            taskItem2 = new Tasks("Task Item 2 desc");
            TDL = new ToDoList();
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
    }
}
