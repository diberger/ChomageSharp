using System;
using System.Collections.Generic;
using BusinessLayer;
using ChomageLibrary.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChomageTest
{
    [TestClass]
    public class UnitTest
    {

        private BusinessManager businessManager;

        [TestInitialize]
        public void init()
        {
            this.businessManager = BusinessManager.Instance;
        }

        [TestMethod]
        public void TestAddEmployee()
        {
            Employee expected = new Employee("Baptiste", "Andrieux", new DateTime(), 5, "JE DAB SI CA MARCHE");

            businessManager.addEmployee(expected);
            //// lecture des clients
            List<Employee> employees = businessManager.GetAllEmployee();

            Assert.AreEqual(expected, employees[0]);
        }
    }
}
