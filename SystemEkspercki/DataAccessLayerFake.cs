using System;
using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    public class DataAccessLayerFake : IDataAccessLayer
    {
        private readonly IRandom random;
        private readonly List<Guid> factsGuid;

        public DataAccessLayerFake() : this(new TrueRandom())
        {
        }

        public DataAccessLayerFake(IRandom random)
        {
            this.random = random;
            factsGuid = CreateFactsGuid();
        }

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
