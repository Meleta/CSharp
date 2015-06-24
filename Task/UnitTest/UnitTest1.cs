using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputErrorTest()
        {
            Assert.AreEqual(0, Body.Result("dsdfsgd"));
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

        [TestMethod]
        public void NegativeNumberTest()
        {
            Assert.AreEqual(-333, Body.Result("-333"));
        }

        [TestMethod]
        public void NullTest()
        {
            Assert.AreEqual(0, Body.Result(null));
        }
    }
}
