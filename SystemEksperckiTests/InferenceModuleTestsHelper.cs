using System;
using System.Collections.Generic;
using SystemEkspercki;
using SystemEkspercki.Mapped;

namespace SystemEksperckiTests
{
    public static class InferenceModuleTestsHelper
    {
        /// <summary>
        /// Get facts
        /// </summary>
        /// <returns></returns>
        public static List<Fact> GetFacts()
        {
            return new List<Fact>
            {
                new Fact
                {
                    Id = Guid.Parse("A0000000-0000-0000-0000-000000000000"),
                    Name = "A"
                },
                new Fact
                {
                    Id = Guid.Parse("B0000000-0000-0000-0000-000000000000"),
                    Name = "B"
                },
                new Fact
                {
                    Id = Guid.Parse("C0000000-0000-0000-0000-000000000000"),
                    Name = "C"
                },
                new Fact
                {
                    Id = Guid.Parse("D0000000-0000-0000-0000-000000000000"),
                    Name = "D"
                },
                new Fact
                {
                    Id = Guid.Parse("E0000000-0000-0000-0000-000000000000"),
                    Name = "E"
                },
                new Fact
                {
                    Id = Guid.Parse("F0000000-0000-0000-0000-000000000000"),
                    Name = "F"
                }
            };
        }

        /// <summary>
        /// Gets questions
        /// </summary>
        /// <returns></returns>
        public static List<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Content = "1",
                    Rule = new Rule
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                        Name = "11",
                        Arguments = new List<RuleArgument>
                        {
                            new RuleArgument
                            {
                                Id = Guid.Parse("B0000000-0000-0000-0000-000000000000"),
                                RequiredValue = true
                            },
                            new RuleArgument
                            {
                                Id = Guid.Parse("C0000000-0000-0000-0000-000000000000"),
                                RequiredValue = true
                            }
                        },
                        Target = new Fact
                        {
                            Id = Guid.Parse("A0000000-0000-0000-0000-000000000000")
                        }
                    }
                },
                new Question
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Content = "2",
                    Rule = new Rule
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                        Name = "22",
                        Arguments = new List<RuleArgument>
                        {
                            new RuleArgument
                            {
                                Id = Guid.Parse("F0000000-0000-0000-0000-000000000000"),
                                RequiredValue = true
                            }
                        },
                        Target = new Fact
                        {
                            Id = Guid.Parse("C0000000-0000-0000-0000-000000000000")
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Get elements
        /// </summary>
        /// <returns></returns>
        public static List<Element> GetElements()
        {
            return new List<Element>
            {
                new Element
                {
                    Id = Guid.Parse("00000000-1000-0000-0000-000000000000"),
                    Name = "1",
                    Facts = new List<FactAboutElement>
                    {
                        new FactAboutElement
                        {
                            Id = Guid.Parse("B0000000-0000-0000-0000-000000000000"),
                            Name = "B",
                            Value = true
                        },
                        new FactAboutElement
                        {
                            Id = Guid.Parse("F0000000-0000-0000-0000-000000000000"),
                            Name = "F",
                            Value = true
                        }
                    }
                },
                new Element
                {
                    Id = Guid.Parse("00000000-2000-0000-0000-000000000000"),
                    Name = "2",
                    Facts = new List<FactAboutElement>
                    {
                        new FactAboutElement
                        {
                            Id = Guid.Parse("E0000000-0000-0000-0000-000000000000"),
                            Name = "E",
                            Value = true
                        }
                    }
                }
            };
        }

        /// <summary>
        /// get answers
        /// </summary>
        /// <returns></returns>
        public static List<Answer> GetAnswers()
        {
            return new List<Answer>
            {
                new Answer
                {
                    QuestionId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Value = true
                }
            };
        }
    }
}