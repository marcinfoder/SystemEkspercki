using System;
using System.Collections.Generic;
using SystemEkspercki.Db;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class Mapper : IMapper
    {
        /// <summary>
        /// Create elements list
        /// </summary>
        /// <returns></returns>
        public List<Element> GetElements(List<ElementAndFactDb> elementsAndFacts)
        {
            List<Element> elements = new List<Element>();

            foreach (ElementAndFactDb elementAndFact in elementsAndFacts)
            {
                bool isFound = false;
                foreach (Element element in elements)
                {
                    if (elementAndFact.ElementId == element.Id)
                    {
                        element.Facts.Add(new FactAboutElement
                        {
                            Id = elementAndFact.FactId,
                            Name = elementAndFact.FactName,
                            Value = elementAndFact.Value
                        });

                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    elements.Add(NewElement(elementAndFact));
                }
            }

            return elements;
        }

        /// <summary>
        /// Gets questions
        /// </summary>
        /// <param name="rulesAndQuestions"></param>
        /// <returns></returns>
        public List<Question> GetQuestions(List<RuleAndQuestionDb> rulesAndQuestions)
        {
            List<Question> questions = new List<Question>();

            foreach (RuleAndQuestionDb ruleAndQuestion in rulesAndQuestions)
            {
                bool isFound = false;
                foreach (Question question in questions)
                {
                    if (question.Id == ruleAndQuestion.QuestionId)
                    {
                        question.Rule.Arguments.Add(new RuleArgument
                        {
                            Id = ruleAndQuestion.RuleArgument,
                            RequiredValue = ruleAndQuestion.ArgumentRequiredValue
                        });

                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    questions.Add(NewQuestion(ruleAndQuestion));
                }
            }

            return questions;
        }

        /// <summary>
        /// Return new element to list
        /// </summary>
        /// <param name="elementAndFact"></param>
        /// <returns></returns>
        private Element NewElement(ElementAndFactDb elementAndFact)
        {
            return new Element
            {
                Id = elementAndFact.ElementId,
                Name = elementAndFact.ElementName,
                Facts = new List<FactAboutElement>
                {
                    new FactAboutElement
                    {
                        Id = elementAndFact.FactId,
                        Name = elementAndFact.FactName,
                        Value = elementAndFact.Value
                    }
                }
            };
        }

        /// <summary>
        /// Return new question
        /// </summary>
        /// <param name="ruleAndQuestion"></param>
        /// <returns></returns>
        private Question NewQuestion(RuleAndQuestionDb ruleAndQuestion)
        {
            return new Question
            {
                Id = ruleAndQuestion.QuestionId,
                Content = ruleAndQuestion.QuestionContent,
                Rule = new Rule
                {
                    Id = ruleAndQuestion.RuleId,
                    Name = ruleAndQuestion.RuleName,
                    CreatingFact = ruleAndQuestion.CreatingFactId,
                    Arguments = new List<RuleArgument>
                    {
                        new RuleArgument
                        {
                            Id = ruleAndQuestion.RuleArgument,
                            RequiredValue = ruleAndQuestion.ArgumentRequiredValue
                        }
                    }
                }
            };
        }
    }
}