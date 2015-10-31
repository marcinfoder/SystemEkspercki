using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace SystemEksperckiTests
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void AssertOneIsEqualToOne()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
