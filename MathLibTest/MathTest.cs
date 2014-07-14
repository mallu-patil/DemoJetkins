using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace MathLibTest
{
    [TestFixture]
    public class MathTest
    {

        [Test]
        public void TestAdd()
        {
            MathLib.Math obj = new MathLib.Math();

            Assert.AreEqual(obj.Add(10, 20), 30);
        }
        [Test]
        public void TestSub()
        {
            MathLib.Math obj = new MathLib.Math();
            Assert.AreEqual(obj.Sub(20, 20), 0);
        }
    }
}
