﻿using System;
using System.Collections.Generic;
using System.Linq;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    /// <summary>
    /// Inference module
    /// </summary>
    public class InferenceModule : IInferenceModule
    {
        /// <summary>
        /// readonly items
        /// </summary>
        private readonly IDataProvider dataProvider;

        private readonly IInferenceLogger logger;

        /// <summary>
        /// Properies
        /// </summary>
        public List<Question> Questions { get; private set; }

        public List<Element> Elements { get; private set; }

        public List<Fact> Facts { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataProvider"></param>
        /// <param name="logger"></param>
        public InferenceModule(IDataProvider dataProvider, IInferenceLogger logger)
        {
            this.dataProvider = dataProvider;
            this.logger = logger;

            Questions = this.dataProvider.GetQuestions();
            Elements = this.dataProvider.GetElements();
            Facts = this.dataProvider.GetFacts();
        }

        /// <summary>
        /// Start inferencing
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        public List<Element> InferenceProces(List<Answer> answers, out string log)
        {
            answers.RemoveAll(a => a.Value == null);
            answers.ForEach(a => a.Question = FindQuestionForGivenAnswer(a));
            List<Element> results = new List<Element>();

            logger.StartOfInferenceProces();
            foreach (Element element in Elements)
            {
                logger.ProcessingElement(element);
                bool isResult = true;

                foreach (Answer answer in answers)
                {
                    logger.ProcessingAnswer(answer);
                    if (Answer(element, answer.Question, (bool)answer.Value))
                    {
                        logger.ElementMatchAnswer();
                    }
                    else
                    {
                        logger.ElementNotMatchAnswer();
                        isResult = false;
                        break;
                    }

                    logger.EndOfProcessingAnswer(answer);
                }

                if (isResult)
                {
                    logger.AddingElement(element);
                    results.Add(element);
                }
                else
                {
                    logger.NotAddingElement(element);
                }

                logger.EndOfProcessingElement(element);
            }

            logger.EndOfInferenceProces();
            log = logger.GetString();
            return results;
        }

        /// <summary>
        /// Check if element is good for a given answer to a question
        /// </summary>
        /// <param name="element"></param>
        /// <param name="question"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool Answer(Element element, Question question, bool value)
        {
            logger.LookingForFact(question);
            var factAboutElement = FindFactAboutElementWhichIsQuestionSubject(element, question);

            if (factAboutElement != default(FactAboutElement))
            {
                logger.ElementHasAnswer(element, question);
                return value == factAboutElement.Value;
            }

            return SearchForAnswer(element, question, value);
        }

        /// <summary>
        /// finds fact about element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="question"></param>
        /// <returns></returns>
        private FactAboutElement FindFactAboutElementWhichIsQuestionSubject(Element element, Question question)
        {
            return element.Facts.Find(f => f.Id == question.Rule.Target.Id);
        }

        /// <summary>
        /// Gets question for an answer
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        private Question FindQuestionForGivenAnswer(Answer answer)
        {
            return Questions.Find(q => q.Id == answer.QuestionId);
        }

        /// <summary>
        /// Finds question for given fact
        /// </summary>
        /// <param name="factId"></param>
        /// <returns></returns>
        private Question FindQuestionForGivenFact(Guid factId)
        {
            return Questions.Find(q => q.Rule.Target.Id == factId);
        }

        /// <summary>
        /// Find fact about element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="ruleArgument"></param>
        /// <returns></returns>
        private FactAboutElement FindFactAboutElementWhichIsRuleArgument(Element element, RuleArgument ruleArgument)
        {
            return element.Facts.Find(fae => fae.Id == ruleArgument.Id);
        }

        /// <summary>
        /// SearchForAnswer
        /// </summary>
        /// <param name="element"></param>
        /// <param name="question"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool SearchForAnswer(Element element, Question question, bool value)
        {
            foreach (RuleArgument ruleArgument in question.Rule.Arguments)
            {
                FactAboutElement factAboutElement = FindFactAboutElementWhichIsRuleArgument(element, ruleArgument);

                if (factAboutElement == null)
                {
                    Question answeringQuestion = FindQuestionForGivenFact(ruleArgument.Id);

                    if (answeringQuestion == null)
                    {
                        return false;
                    }

                    if (SearchForAnswer(element, answeringQuestion, ruleArgument.RequiredValue))
                    {
                        factAboutElement = FindFactAboutElementWhichIsRuleArgument(element, ruleArgument);
                    }
                }

                if (factAboutElement.Value != ruleArgument.RequiredValue)
                {
                    return false;
                }
            }

            element.Facts.Add(new FactAboutElement
            {
                Id = question.Rule.Target.Id,
                Name = question.Rule.Target.Name,
                Value = value
            });
            return true;
        }
    }
}