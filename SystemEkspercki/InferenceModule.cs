using System;
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
        }

        /// <summary>
        /// Start inferencing
        /// </summary>
        /// <param name="answers"></param>
        /// <returns></returns>
        public List<Element> InferenceProces(List<Answer> answers)
        {
            List<Element> results = new List<Element>();

            logger.StartOfInferenceProces();
            foreach (Answer answer in answers)
            {
                Question question = GetAnswerQuestion(answer);

                logger.ProcessingAnswer(answer, question);
                foreach (Element element in Elements)
                {
                    logger.ProcessingElement(element);
                    if (answer.Value != null && Answer(element, question, (bool) answer.Value))
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

                logger.EndOfProcessingAnswer(answer, question);
            }

            logger.EndOfInferenceProces();
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
            var factAboutElement = element.Facts.Find(f => f.Id == question.Rule.CreatingFact);

            if (factAboutElement != default(FactAboutElement))
            {
                logger.ElementHasAnswer(element, question);
                return value == factAboutElement.Value;
            }

            return SearchForAnswer(element, question, value);
        }

        /// <summary>
        /// Gets question for an answer
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        private Question GetAnswerQuestion(Answer answer)
        {
            return Questions.Find(q => q.Id == answer.QuestionId);
        }

        private Question GetAnsweringQuestion(Guid factId)
        {
            return Questions.Find(q => q.Rule.CreatingFact == factId);
        }

        private bool SearchForAnswer(Element element, Question question, bool value)
        {
            foreach (RuleArgument ruleArgument in question.Rule.Arguments)
            {
                FactAboutElement factAboutElement = element.Facts.Find(fae => fae.Id == ruleArgument.Id);

                if (factAboutElement == null)
                {
                    Question answeringQuestion = GetAnsweringQuestion(ruleArgument.Id);

                    if (answeringQuestion == null)
                    {
                        return false;
                    }

                    if (SearchForAnswer(element, question, ruleArgument.RequiredValue))
                    {
                        factAboutElement = element.Facts.Find(fae => fae.Id == ruleArgument.Id);
                    }
                }

                if (factAboutElement.Value != ruleArgument.RequiredValue)
                {
                    return false;
                }
            }

            element.Facts.Add(new FactAboutElement
            {
                Id = question.Rule.CreatingFact,
                Name = string.Empty, // find element and assign name
                Value = value
            });
            return true;
        }
    }
}