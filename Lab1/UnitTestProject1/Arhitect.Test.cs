using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Lab1;
namespace UnitTestProject1
{
    
    [TestClass]
    public class Arhitect1
    {     

        [TestMethod]
        public void TestMethod1()
        {
            Arhitect arh = new Arhitect();

            arh.Id = 50;
            arh.Id.Should().Be(50);
            Assert.AreEqual(50, arh.Id);

            arh.StartDate = DateTime.Parse("1/12/2015");

            arh.StartDate.Should().HaveDay(12);
            arh.StartDate.Should().HaveMonth(1);
            arh.StartDate.Should().HaveYear(2015);

            /*Assert.AreEqual(12, arh.StartDate.Day);
            Assert.AreEqual(1, arh.StartDate.Month);
            Assert.AreEqual(2015, arh.StartDate.Month);
            */
            arh.EndDate = DateTime.Parse("8/10/2018");

            arh.EndDate.Should().HaveDay(10);
            arh.EndDate.Should().HaveMonth(8);
            arh.EndDate.Should().HaveYear(2018);

            /*Assert.AreEqual(10, arh.EndDate.Day);
            Assert.AreEqual(8, arh.EndDate.Month);
            Assert.AreEqual(2018, arh.EndDate.Month);*/

            arh.Salary = 700;
            arh.Salary.Should().Be(700);
            Assert.AreEqual(700, arh.Salary);
            
        }
    }
}
