using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneFinch.ReactiveExtensions.Examples.Tests
{
    [TestClass]
    public class BasicsTests
    {
        [TestMethod]
        public void Example01Test()
        {
            var item = 1;
            Assert.AreEqual(1, item);
        }
    }
}