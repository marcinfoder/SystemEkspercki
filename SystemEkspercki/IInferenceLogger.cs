using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public interface IInferenceLogger
    {
        void StartOfInferenceProces();
        void ProcessingAnswer(Answer answer, Question question);
        void EndOfProcessingAnswer(Answer answer, Question question);
        void ProcessingElement(Element element);
        void EndOfProcessingElement(Element element);
        void LookingForFact(Question question);
        void ElementHasAnswer(Element element, Question question);
        void ElementDoesnotHaveAnswer(Element element, Question question);
        void AddingElement(Element element);
        void NotAddingElement(Element element);
        void EndOfInferenceProces();

        string GetString();
    }
}