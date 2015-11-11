using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private readonly Stopwatch stopwatch;

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
            this.stopwatch = new Stopwatch();

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
            stopwatch.Start();
            logger.RemovingEmptyAnswers();
            int count = answers.Count;
            int removed = answers.RemoveAll(a => a.Value == null);
            logger.RemovedAnswers(count, removed);

            if (!answers.Any())
            {
                logger.ThereAreNotAnyAnswers();
                log = logger.GetString();
                return new List<Element>();
            }

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
                        logger.EndOfProcessingAnswer(answer);
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
            logger.Result(results.Count, Elements.Count, stopwatch.Elapsed.TotalMilliseconds.ToString());
            
            log = logger.GetString();
            stopwatch.Stop();
            stopwatch.Reset();
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

            logger.ElementDoesnotHaveAnswer(element, question);
            logger.CheckingIfElementCanBeCreated();
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
                Fact fact = Facts.Find(f => ruleArgument.Id == f.Id);
                logger.CheckingForArgument(fact);

                FactAboutElement factAboutElement = FindFactAboutElementWhichIsRuleArgument(element, ruleArgument);

                if (factAboutElement == null)
                {
                    Question answeringQuestion = FindQuestionForGivenFact(ruleArgument.Id);

                    if (answeringQuestion == null)
                    {
                        return false;
                    }

                    logger.SearchingForAnswer(element, answeringQuestion);
                    if (SearchForAnswer(element, answeringQuestion, ruleArgument.RequiredValue))
                    {
                        factAboutElement = FindFactAboutElementWhichIsRuleArgument(element, ruleArgument);
                    }
                }

                if (factAboutElement.Value != ruleArgument.RequiredValue)
                {
                    logger.ArgumentDoesNotMatch(ruleArgument);
                    return false;
                }
                logger.ArgumentMatch(ruleArgument);
            }

            FactAboutElement factAboutElementNew = new FactAboutElement
            {
                Id = question.Rule.Target.Id,
                Name = question.Rule.Target.Name,
                Value = value
            };

            logger.AddingFact(factAboutElementNew);
            element.Facts.Add(factAboutElementNew);
            logger.EnfOfCheckingIfFactCanBeAdded();
            return true;
        }
    }
}