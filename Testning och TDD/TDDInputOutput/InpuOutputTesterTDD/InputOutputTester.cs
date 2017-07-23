using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInputOutput;
using System.IO;

namespace InpuOutputTesterTDD
{
    [TestClass]
    public class InputOutputTester
    {
        Writer writer;
        [TestInitialize]
        public void CreateWriter()
        {
            writer = new Writer("Robert", "Kalle", 76, 98);
        }
        
        [TestMethod]
        public void NameControll()
        {
            string actual = writer.FullNameGenerator("Tommy", "Forsberg");
            string expected = "Tommy Forsberg";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfFileIsCreated()
        {
           // Writer writer = new Writer("Robert", "Kalle", 76, 98);
            var file = "C://Users//Tommy//Desktop//TextFile.txt";
            //File.Create(directory + "//TextFile.txt");
            bool fileExist = File.Exists(file);
            Assert.IsTrue(fileExist);
        }

        [TestMethod]
        public void AdditionControll()
        {
            var actual = writer.Addition(2, 2);
            var expected = 4;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SubtractionControll()
        {
            var actual = writer.Subtractor(10, 8);
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationCheck()
        {
            var actual = writer.Multiplication(5, 5);
            var expected = 25;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void DivisionTest()
        {
            var actual = writer.Division(25, 5);
            var expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AssembleArrayTest()
        {
            //Writer writer = new Writer("Robert", "Robertsson", 76, 98);
            string[] array = writer.AssembleArray();
            Assert.IsNotNull(array);
        }

        [TestMethod]
        public void CheckWriteToFile()
        {
            var file = "C://Users//Tommy//Desktop//TextFile.txt";
            string[] testArray = new string[] { "Test"};
            writer.WriteToFile(testArray);
            var actualArray = File.ReadAllLines(file);
            string actual = actualArray[0];
            string expected = "Test";
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestReadFromFile()
        {
           // Writer writer = new Writer("Lars", "Larsson", 76, 98);
            string[] testArray = new string[] { "Test" };
            writer.WriteToFile(testArray);
            string[] actual = writer.ReadFromFile();
            Assert.IsNotNull(actual);
        }
    }
}
