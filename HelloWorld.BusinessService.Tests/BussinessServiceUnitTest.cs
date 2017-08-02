﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using HelloWorld.BusinessService.Controllers;

namespace HelloWorld.BusinessService.Tests
{
    /// <summary>
    ///     Unit tests for  Hello World Business service    /// </summary>
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void TestHelloWorldMessage()
        {
            string expectedresult= "Hello World";
            HelloWorldController objHelloworlcontroller=new HelloWorldController();
            Assert.AreEqual(objHelloworlcontroller.Get(),
                       expectedresult);
        }


    }
  
}