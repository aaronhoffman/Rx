using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoneFinch.ReactiveExtensions.Examples.Tests
{
    [TestClass]
    public class BasicsTests
    {
        [TestMethod]
        public void Example01Test()
        {
            var target = new Basics();

            target.Example01();
        }
    }
}