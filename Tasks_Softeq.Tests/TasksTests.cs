using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tasks_Softeq.Tests
{
    [TestClass]
    public class TasksTests
    {
        [TestMethod]
        public void Task1()
        {
            double[] expected = { 1132.856, 123.456, 97.575, 9323.456, -17.344, 56.856 };
            Tasks obj = new Tasks();
            double[] actual = obj.Task_1(new string[] { "6", "-7", "0", "1,234", "10", "-4", "3" });

            for (int i = 0; i < 6; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }
        [TestMethod]
        public void Task2_1500returned()
        {
            double expected = 1500.000;
            Tasks obj = new Tasks();
            double actual = obj.Task_2(new string[] { "4 4", "3000", "3000", "1000", "1000" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_2000returned()
        {
            double expected = 2000.000;
            Tasks obj = new Tasks();
            double actual = obj.Task_2(new string[] { "4 6", "2000", "2000", "1000", "1000" });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_75returned()
        {
            int expected = 75;
            Tasks obj = new Tasks();
            double actual = obj.Task_3("3 5 13");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_81returned()
        {
            int expected = 81;
            Tasks obj = new Tasks();
            double actual = obj.Task_3("3 4 12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_0returned()
        {
            int expected = 0;
            Tasks obj = new Tasks();
            double actual = obj.Task_3("100 0 12");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4_7returned()
        {
            int expected = 7;
            Tasks obj = new Tasks();
            int actual = obj.Task_4("7returned.txt");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4_5returned()
        {
            int expected = 5;
            Tasks obj = new Tasks();
            int actual = obj.Task_4("5returned.txt");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4_8returned()
        {
            int expected = 8;
            Tasks obj = new Tasks();
            int actual = obj.Task_4("8returned.txt");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task4_24returned()
        {
            int expected = 24;
            Tasks obj = new Tasks();
            int actual = obj.Task_4("24returned.txt");

            Assert.AreEqual(expected, actual);
        }
    }
}
