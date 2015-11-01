using System;
using System.Text;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class InferenceLogger : IInferenceLogger
    {
        private readonly StringBuilder stringBuilder;
        private int indentDepth;

        public InferenceLogger()
        {
            stringBuilder = new StringBuilder();
        }

        public void StartOfInferenceProces()
        {
            stringBuilder.AppendLine("Rozpoczęto proces wnioskowania.");
            indentDepth++;
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
            stringBuilder.AppendLine("Zakończono proces wnioskowania.");

            if (indentDepth != 0)
            {
                throw new Exception("Po zakończeniu procesu wnioskowania wcięcie powinno być równe 0.");
            }
        }

        public string GetString()
        {
            return stringBuilder.ToString();
        }
    }
}