using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Lab1;

namespace UnitTestProject1
{
    
    [TestClass]
    public class ManagerTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            Manager man = new Manager();
            man.Id = 7;
            man.Id.Should().Be(7);
            Assert.AreEqual(7,man.Id);

            man.StartDate=DateTime.Parse("1/12/2015");

            man.StartDate.Should().HaveDay(12);
            man.StartDate.Should().HaveMonth(1);
            man.StartDate.Should().HaveYear(2015);

           /* Assert.AreEqual(12, man.StartDate.Day);
            Assert.AreEqual(1, man.StartDate.Month);
            Assert.AreEqual(2015, man.StartDate.Month);*/
            
           
            man.EndDate = DateTime.Parse("8/10/2017");

            man.EndDate.Should().HaveDay(10);
            man.EndDate.Should().HaveMonth(8);
            man.EndDate.Should().HaveYear(2017);

          /* Assert.AreEqual(10, man.EndDate.Day);
            Assert.AreEqual(8, man.EndDate.Month);
            Assert.AreEqual(2017, man.EndDate.Year);
          */ 
            man.Salary = 700;
            man.Salary.Should().Be(700);
            Assert.AreEqual(700, man.Salary);
            
        }
    }
}
