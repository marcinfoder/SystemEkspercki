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
            List<ElementAndFactDb> elementsAndFacts = MapperTestHelper.CreateCorrectElementsAndFacts();
            List<Element> elements = null;

            // Act
            elements = mapper.GetElements(elementsAndFacts);

            // Assert
            Assert.That(elements.Count, Is.EqualTo(2));
            Assert.That(elements[0].Facts.Count, Is.EqualTo(3));
            Assert.That(elements[1].Facts.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetQuestionsTest()
        {
            // Arrage
            IMapper mapper = new Mapper();
            List<RuleAndQuestionDb> rulesAndQuestions = MapperTestHelper.CreateCorrectRulesAndQuestions();
            List<Question> questions = null;

            // Act
            questions = mapper.GetQuestions(rulesAndQuestions);

            // Assert
            Assert.That(questions.Count, Is.EqualTo(3));
            Assert.That(questions[0].Rule.Arguments.Count, Is.EqualTo(4));
            Assert.That(questions[1].Rule.Arguments.Count, Is.EqualTo(1));
            Assert.That(questions[2].Rule.Arguments.Count, Is.EqualTo(1));
        }
    }
}
