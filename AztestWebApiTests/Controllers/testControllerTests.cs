using Microsoft.VisualStudio.TestTools.UnitTesting;
using AztestWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace AztestWebApi.Controllers.Tests
{
    [TestClass()]
    public class testControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            var ctrl = new testController();
            var cloudDevOps = ctrl.Get().GetEnumerator();
            cloudDevOps.MoveNext();
            Assert.IsNotNull(cloudDevOps);
            Assert.AreEqual("Azure DevOps".ToLower(), cloudDevOps.Current.ToLower());
        }
    }
}