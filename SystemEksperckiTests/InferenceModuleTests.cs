using System.Collections.Generic;
using System.Linq;
using SystemEkspercki;
using NUnit.Framework;
using Rhino.Mocks;

namespace SystemEksperckiTests
{
    [TestFixture]
    public class InferenceModuleTests
    {
        [Test]
        public void SearchForAnswerTest()
        {
            // Arrange
            IDataProvider dataProvider = MockRepository.GenerateMock<IDataProvider>();
            dataProvider.Stub(a => a.GetFacts()).Return(InferenceModuleTestsHelper.GetFacts());
            dataProvider.Stub(a => a.GetElements()).Return(InferenceModuleTestsHelper.GetElements());
            dataProvider.Stub(a => a.GetQuestions()).Return(InferenceModuleTestsHelper.GetQuestions());
            IInferenceModule inferenceModule = new InferenceModule(dataProvider, new InferenceLoggerFake());
            List<Answer> answers = InferenceModuleTestsHelper.GetAnswers();

            // Act
            var result = inferenceModule.InferenceProces(answers);

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result.First().Facts.Count, Is.EqualTo(4));
        }
    }
}