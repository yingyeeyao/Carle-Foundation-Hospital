using NUnit.Framework;
using ConsoleApp1;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    public class Tests
    {
        string originalString = "[VICTOR],[ECHO],[BRAVO],[BRAVO],[OSCAR],[ECHO],[PAPA],[BRAVO]";
        List<string> originalList = new List<string>(); 
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testduplicates()
        {
            originalList.AddRange(originalString.Split(','));
            Program p = new Program();
            var duplicates = p.CheckforDuplicates(originalList);
            Assert.AreEqual(2, duplicates.ToList().Count());
        }

        [Test]
        public void TestContain1()
        {
            originalList.AddRange(originalString.Split(','));
            Program p = new Program();
            var duplicates = p.CheckforDuplicates(originalList);
            Assert.IsTrue(duplicates.Contains("[ECHO]"));
        }

        [Test]
        public void TestContain2()
        {
            originalList.AddRange(originalString.Split(','));
            Program p = new Program();
            var duplicates = p.CheckforDuplicates(originalList);
            Assert.IsTrue(duplicates.Contains("[BRAVO]"));
        }
    }
}