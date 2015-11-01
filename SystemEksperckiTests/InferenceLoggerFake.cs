using SystemEkspercki;
using SystemEkspercki.Mapped;

namespace SystemEksperckiTests
{
    public class InferenceLoggerFake : IInferenceLogger
    {
        public void StartOfInferenceProces()
        {
        }

        public void ProcessingAnswer(Answer answer, Question question)
        {
        }

        public void AddingElement(Element element)
        {
        }

        public void NotAddingElement(Element element)
        {
        }

        public void EndOfInferenceProces()
        {
        }

        public string GetString()
        {
            return string.Empty;
        }
    }
}