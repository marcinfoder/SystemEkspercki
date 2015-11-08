using System;
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
            elementsAndFacts = dataAccessLayer.SelectElementsAndFacts();

            // Assert
            Assert.That(elementsAndFacts.Count, Is.EqualTo(25));
            Assert.That(elementsAndFacts.GroupBy(e => e.ElementId).Count(), Is.EqualTo(5));
            Assert.That(elementsAndFacts.GroupBy(f => f.FactId).Count(), Is.EqualTo(5));
        }

        [Test]
        public void GetGetRulesAndQuestionsTest()
        {
            // Arrage
            IRandom random = new RandomForTest();
            IDataAccessLayer dataAccessLayer = new DataAccessLayerFake(random);
            List<RuleAndQuestionDb> rulesAndQuestions = null;
            Guid someArgument = Guid.Empty;

            // Act
            rulesAndQuestions = dataAccessLayer.SelectRulesAndQuestions();
            someArgument = rulesAndQuestions.First().RuleArgument;

            // Assert
            Assert.That(rulesAndQuestions.Count, Is.EqualTo(20));
            Assert.That(rulesAndQuestions.GroupBy(c => c.CreatingFactId).Count(), Is.EqualTo(5));
            Assert.That(rulesAndQuestions.GroupBy(q => q.QuestionId).Count(), Is.EqualTo(5));
            Assert.That(rulesAndQuestions.GroupBy(q => q.RuleId).Count(), Is.EqualTo(5));
            Assert.That(rulesAndQuestions.Count(a => a.RuleArgument == someArgument), Is.EqualTo(4));
        }
    }
}