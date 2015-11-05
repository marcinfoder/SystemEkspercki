using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class InferenceLogger : IInferenceLogger
    {
        private readonly StringBuilder stringBuilder;
        private int indentDepth;
        private string indent;

        public InferenceLogger()
        {
            stringBuilder = new StringBuilder();
        }

        public void StartOfInferenceProces()
        {
            stringBuilder.AppendLine(Indent() + "Rozpoczęto proces wnioskowania\n");
            IncreaseIndent();
        }

        public void AddingElement(Element element)
        {
        }

        public void NotAddingElement(Element element)
        {
        }

        public void EndOfInferenceProces()
        {
            stringBuilder.AppendLine(Indent() + "Zakończono proces wnioskowania\n");
            DecreaseIndent();

            if (indentDepth != 0)
            {
                throw new Exception("Po zakończeniu procesu wnioskowania wcięcie powinno być równe 0.");
            }
        }

        public string GetString()
        {
            return stringBuilder.ToString();
        }

        public void ProcessingElement(Element element)
        {
            stringBuilder.AppendLine(Indent() + string.Format("Przetwarzanie elementu: {0}\n", element.Name));
            IncreaseIndent();
        }

        public void EndOfProcessingElement(Element element)
        {
            stringBuilder.AppendLine(Indent() + string.Format("Koniec przetwarzania elementu: {0}\n", element.Name));
            DecreaseIndent();
        }

        public void LookingForFact(Question question)
        {
        }

        public void ElementHasAnswer(Element element, Question question)
        {
        }

        public void ElementDoesnotHaveAnswer(Element element, Question question)
        {
        }


        public void ProcessingAnswer(Answer answer)
        {
            stringBuilder.AppendLine(Indent() + string.Format("Sprawdzanie czy element pasuje do odpowiedzi, która uruchamia regułę: {0}\n", answer.Question.Rule.Name));
            IncreaseIndent();
        }

        public void EndOfProcessingAnswer(Answer answer)
        {
            stringBuilder.AppendLine(Indent() + string.Format("Zakończono sprawdzanie czy element pasuje do odpowiedzi, która uruchamia regułę: {0}\n", answer.Question.Rule.Name));
            DecreaseIndent();
        }

        public void ElementMatchAnswer()
        {
            stringBuilder.AppendLine(Indent() + "Element pasuje do odpowiedzi\n");
        }

        public void ElementNotMatchAnswer()
        {
            stringBuilder.AppendLine(Indent() + "Element nie pasuje do odpowiedzi\n");
        }

        private string Indent()
        {
            return indent;
        }

        private void IncreaseIndent()
        {
            indentDepth++;
            indent += "    ";
        }

        private void DecreaseIndent()
        {
            indentDepth--;
            indent.Remove(indent.Length - 4);
        }
    }
}