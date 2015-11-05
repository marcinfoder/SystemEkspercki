using System;
using System.Collections.Generic;
using System.Linq;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    /// <summary>
    /// Data access layer fake
    /// </summary>
    public class DataAccessLayerFake : IDataAccessLayer
    {
        /// <summary>
        /// read only items
        /// </summary>
        private readonly IRandom random;
        private readonly List<Guid> factsGuid;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataAccessLayerFake() : this(new TrueRandom())
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="random"></param>
        public DataAccessLayerFake(IRandom random)
        {
            this.random = random;
            factsGuid = CreateFactsGuid();
        }

        /// <summary>
        /// Gets RuleAndQuestionDb
        /// </summary>
        /// <returns></returns>
        public List<RuleAndQuestionDb> GetRulesAndQuestions()
        {
            List<RuleAndQuestionDb> rulesAndQuestions = new List<RuleAndQuestionDb>();

            int questionsToCreate = factsGuid.Count;

            for (int i = 0; i < questionsToCreate; i++)
            {
                Guid questionId = Guid.NewGuid();
                Guid ruleId = Guid.NewGuid();
                Guid creatingFactId = factsGuid[i];

                for (int j = 0; j < factsGuid.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    rulesAndQuestions.Add(new RuleAndQuestionDb
                    {
                        RuleId = ruleId,
                        QuestionId = questionId,
                        QuestionContent = "lala",
                        CreatingFactId = creatingFactId,
                        RuleArgument = factsGuid[j],
                        ArgumentRequiredValue = random.Next(2) % 2 == 0
                    });
                }
            }

            return rulesAndQuestions;
        }

        /// <summary>
        /// Gets ElementAndFactDb
        /// </summary>
        /// <returns></returns>
        public List<ElementAndFactDb> GetElementsAndFacts()
        {
            List<ElementAndFactDb> elementsAndFacts = new List<ElementAndFactDb>();

            int elementsToCreate = random.Next(10, 30);
            int factBaseNameFrom = elementsToCreate * 10;
            for (int i = 0; i < elementsToCreate; i++)
            {
                Guid elementId = Guid.NewGuid();
                string elementName = i.ToString();

                for (int j = 0; j < factsGuid.Count; j++)
                {
                    elementsAndFacts.Add(new ElementAndFactDb
                    {
                        ElementId = elementId,
                        ElementName = elementName,
                        FactId = factsGuid[j],
                        FactName = ((factBaseNameFrom * i) + j).ToString(),
                        Value = random.Next(2) % 2 == 0
                    });
                }
            }

            return elementsAndFacts;
        }

        /// <summary>
        /// Gets facts
        /// </summary>
        /// <returns></returns>
        public List<FactDb> GetFacts()
        {
            return factsGuid.Select(f => new FactDb
            {
                Id = f,
                Name = "nana"
            }).ToList();
        }

        /// <summary>
        /// Create list of Guid
        /// </summary>
        /// <returns></returns>
        private List<Guid> CreateFactsGuid()
        {
            List<Guid> guids = new List<Guid>();

            int count = random.Next(10, 30);
            for (int i = 0; i < count; i++)
            {
                guids.Add(Guid.NewGuid());
            }

            return guids;
        }
    }
}