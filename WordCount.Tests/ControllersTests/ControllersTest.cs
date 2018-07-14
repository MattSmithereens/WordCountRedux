using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCount.Controllers;
using WordCount.Models;
using System;

namespace WordCount.Tests.HomeControllersTests
{
    [TestClass]
    public class HomeControllersTest
    {
        [TestMethod]
        public void Index_ReturnsIndexPage_True()
        {
            HomeController testHomeController = new HomeController(); ;
            ActionResult indexView = testHomeController.Form();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
    }
}

