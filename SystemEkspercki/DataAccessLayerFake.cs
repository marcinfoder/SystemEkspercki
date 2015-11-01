using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    public class DataAccessLayerFake : IDataAccessLayer
    {
        private readonly IRandom random;

        public DataAccessLayerFake(IRandom random)
        {
            this.random = random;
        }

        public List<RuleAndQuestionDb> GetRulesAndQuestions()
        {
            List<RuleAndQuestionDb> rulesAndQuestions = new List<RuleAndQuestionDb>();

            int questionsToCreate = random.Next(10, 30);

            for (int i = 0; i < questionsToCreate; i++)
            {
                Guid questionId = Guid.NewGuid();
                Guid ruleId = Guid.NewGuid();

                int argumentsToCreate = random.Next()
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

                int factsToCreate = random.Next(10, 30);
                for (int j = 0; j < factsToCreate; j++)
                {
                    elementsAndFacts.Add(new ElementAndFactDb
                    {
                        ElementId = elementId,
                        ElementName = elementName,
                        FactId = Guid.NewGuid(),
                        FactName = ((factBaseNameFrom * i) + j).ToString(),
                        Value = random.Next(2) % 2 == 0
                    });
                }
            }

            return elementsAndFacts;
        }
    }
}
