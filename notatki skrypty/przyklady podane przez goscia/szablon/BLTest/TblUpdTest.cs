using BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DAC;
using System.Collections.Generic;

namespace BLTest
{
    
    
    /// <summary>
    ///This is a test class for TblUpdTest and is intended
    ///to contain all TblUpdTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TblUpdTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetElement
        ///</summary>
        [TestMethod()]
        public void GetElementTest()
        {
            int Nr = 12; // TODO: Initialize to an appropriate value
            // Table1 expected = null; // TODO: Initialize to an appropriate value
            String expected = "zzzz12"; 
            Table1 actual;
            actual = TblUpd.GetElement(Nr);
            Assert.AreEqual(expected, actual.name,"Niepoprwana nazwa elementu o wskazanej nazwie");
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            List<Table1> expected = null; // TODO: Initialize to an appropriate value
            List<Table1> actual;
            actual = TblUpd.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
