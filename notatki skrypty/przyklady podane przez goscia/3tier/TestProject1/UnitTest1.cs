using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizLay;
using DataLay;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IQueryable<zespoly> iz =  BizService.GetZesp("A");
            zespoly z = iz.Single();
            Assert.AreEqual(6, z.NR_ZESP, " jest źle");

        }

         [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(true); 

        }
    }
}
