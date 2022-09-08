using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebApplication7.Controllers;
using WebApplication7.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            EmployeeController controller = new EmployeeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add()
        {
            EmployeeController controller = new EmployeeController();
            ViewResult result = controller.Add(0) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
