using System;
using System.Collections.Generic;
using SystemEkspercki;
using SystemEkspercki.Db;
using SystemEkspercki.Mapped;
using NUnit.Framework;

namespace SystemEksperckiTests
{
    [TestFixture]
    public class MapperTests
    {
        [Test]
        public void GetElementsTest()
        {
            // Arrage
            IMapper mapper = new Mapper();
            List<ElementAndFactDb> elementsAndFacts = MapperTestHelper.CreateCorrectList();
            List<Element> elements = null;

            // Act
            elements = mapper.GetElements(elementsAndFacts);

            // Assert
            Assert.That(elements.Count, Is.EqualTo(2));
            Assert.That(elements[0].Facts.Count, Is.EqualTo(3));
            Assert.That(elements[1].Facts.Count, Is.EqualTo(2));
        }
    }
}
