using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMS.Controllers;
using System;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Index()
        {

        //Arrange

            HomeController controller = new HomeController();


        //Act
        ViewResult result = controller.Index()   as ViewResult;

        //Assert
        Assert.IsNotNull(result);

        }

        public void About()
        {

            //Arrange

            HomeController controller = new HomeController();


            //Act
            ViewResult result = controller.About() as ViewResult;

            //Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);

        }

        public void Contact()
        {

            //Arrange

            HomeController controller = new HomeController();


            //Act
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            Assert.AreEqual("Your contact page..", result.ViewBag.Message);

        }

    }
}
