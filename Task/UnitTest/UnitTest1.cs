using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SingleValueTest()
        {
            Assert.AreEqual(42, Body.Result("42"));
        }

        [TestMethod]
        public void EmptyValueTest()
        {
            Assert.AreEqual(0, Body.Result("4 2"));
        }

        [TestMethod]
        public void LimitLeftTest()
        {
            Assert.AreEqual(-1000, Body.Result("-1001"));
        }

        [TestMethod]
        public void LimitRightTest()
        {
            Assert.AreEqual(1000, Body.Result("1001"));
        }

        [TestMethod]
        public void SpaceTest()
        {
            Assert.AreEqual(44, Body.Result(" 42 + 5 - 3"));
        }
    }
}
