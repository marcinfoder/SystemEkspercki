﻿using SystemEkspercki;
using SystemEkspercki.Mapped;

namespace SystemEksperckiTests
{
    public class InferenceLoggerFake : IInferenceLogger
    {
        public void StartOfInferenceProces()
        {
        }

        public void ProcessingAnswer(Answer answer)
        {
        }

        public void EndOfProcessingAnswer(Answer answer)
        {
        }

        public void ProcessingElement(Element element)
        {
        }

        public void EndOfProcessingElement(Element element)
        {
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

        public void ElementMatchAnswer()
        {
        }

        public void ElementNotMatchAnswer()
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


        public void LogResult(int count, int all)
        {
        }

        public void Result(int result, int all, string time)
        {
        }

        public void RemovingEmptyAnswers()
        {
        }

        public void RemovedAnswers(int before, int after)
        {
        }

        public void ThereAreNotAnyAnswers()
        {
        }


        public void SearchingForAnswer(Element element, Question question)
        {
        }

        public void CheckingForArgument(RuleArgument ruleArgument)
        {
        }

        public void ArgumentDoesNotMatch(RuleArgument ruleArgument)
        {
        }

        public void ArgumentMatch(RuleArgument ruleArgument)
        {
        }

        public void AddingFact(FactAboutElement factAboutElementNew)
        {
        }


        public void CheckingForArgument(Fact fact)
        {
        }


        public void CheckingIfElementCanBeCreated()
        {
            throw new System.NotImplementedException();
        }


        public void EnfOfCheckingIfFactCanBeAdded()
        {
            throw new System.NotImplementedException();
        }
    }
}