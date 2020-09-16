using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoullete_Rajpal;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //for testing the russian form class
            Russiannn rsn = new Russiannn();
            
            UnitTestCase customLogic = new UnitTestCase();
            var result = customLogic.AddTwoPostiveNumber(10, 20);
            Assert.IsTrue(result == 30);
        }
        [TestMethod()]
        public void CheckClassMethod()
        {
            OneClass oc = new OneClass();
            var abc = oc.LoopRjShot(5);
            if (abc>=5)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
