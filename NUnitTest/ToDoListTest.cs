using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace NUnitTest
{
    [TestClass]
    public class ToDoListTest : ToDoList
    {
        [TestInitialize]
        [ExpectedException(typeof(ArgumentException))]
        public void setUp() 
        {
            
            //Initialise Test Fixtures
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


            Assert.Fail("Not implemented yet");
        }

        [TestMethod]
        public void TestGetCompletedTasks()
        {
            Assert.Fail("Not implemented yet");
        }
    }
}
