﻿using System;
using System.Text;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class InferenceLogger : IInferenceLogger
    {
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
            indent = indent.Remove(indent.Length - 4);
        }

        private readonly StringBuilder stringBuilder;
        private int indentDepth;
        private string indent;

        public InferenceLogger()
        {
            stringBuilder = new StringBuilder();
            indent = string.Empty;
            indentDepth = 0;
        }

        public void StartOfInferenceProces()
        {
            stringBuilder.AppendLine(Indent() + "Rozpoczęto proces wnioskowania");
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
            DecreaseIndent();
            stringBuilder.AppendLine(Indent() + "Zakończono proces wnioskowania");

            if (indentDepth != 0)
            {
                throw new Exception("Po zakończeniu procesu wnioskowania wcięcie powinno być równe 0.");
            }
        }

        public string GetString()
        {
            string log =  stringBuilder.ToString();
            stringBuilder.Clear();
            return log;
        }

        public void ProcessingElement(Element element)
        {
            stringBuilder.AppendLine(Indent() + string.Format("Przetwarzanie elementu: {0}", element.Name));
            IncreaseIndent();
        }

        public void EndOfProcessingElement(Element element)
        {
            DecreaseIndent();
            stringBuilder.AppendLine(Indent() + string.Format("Koniec przetwarzania elementu: {0}", element.Name));
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
            stringBuilder.AppendLine(Indent() + string.Format("Sprawdzanie czy element pasuje do odpowiedzi, która uruchamia regułę: {0}", answer.Question.Rule.Name));
            IncreaseIndent();
        }

        public void EndOfProcessingAnswer(Answer answer)
        {
            DecreaseIndent();
            stringBuilder.AppendLine(Indent() + string.Format("Zakończono sprawdzanie czy element pasuje do odpowiedzi, która uruchamia regułę: {0}", answer.Question.Rule.Name));
        }

        public void ElementMatchAnswer()
        {
            stringBuilder.AppendLine(Indent() + "Element pasuje do odpowiedzi");
        }

        public void ElementNotMatchAnswer()
        {
            stringBuilder.AppendLine(Indent() + "Element nie pasuje do odpowiedzi");
        }

        public void Result(int count, int all, string time)
        {
            stringBuilder.Append(Indent() + string.Format("Znaleziono {0} z {1} pasujących elementów w czasie {2} [ms]", count, all, time));
        }

        public void RemovingEmptyAnswers()
        {
            stringBuilder.AppendLine("Usuwanie pytań, na które nie udzielono odpowiedzi");
        }

        public void RemovedAnswers(int before, int after)
        {
            stringBuilder.AppendLine(string.Format("Usuwanięto {0} z {1} pytań", after, before));
        }

        public void ThereAreNotAnyAnswers()
        {
            stringBuilder.AppendLine("Nie ma żadnych pytań!");
        }
    }
}