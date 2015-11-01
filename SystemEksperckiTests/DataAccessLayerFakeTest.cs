using System.Collections.Generic;
using System.Linq;
using SystemEkspercki;
using SystemEkspercki.Db;
using NUnit.Framework;

namespace SystemEksperckiTests
{
    [TestFixture]
    class DataAccessLayerFakeTest
    {
        [Test]
        public void GetElementsAndFactsTest()
        {
            // Arrage
            IRandom random = new RandomForTest();
            IDataAccessLayer dataAccessLayer = new DataAccessLayerFake(random);
            List<ElementAndFactDb> elementsAndFacts = null;

            // Act
            elementsAndFacts = dataAccessLayer.GetElementsAndFacts();

            // Assert
            Assert.That(elementsAndFacts.Count, Is.EqualTo(25));
            Assert.That(elementsAndFacts.GroupBy(e => e.ElementId).Count(), Is.EqualTo(5));
            Assert.That(elementsAndFacts.GroupBy(f => f.FactId).Count(), Is.EqualTo(25));
        }
    }
}