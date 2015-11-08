using System;
using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    /// <summary>
    /// IDataAccessLayer interface.
    /// </summary>
    public interface IDataAccessLayer
    {
        List<RuleAndQuestionDb> SelectRulesAndQuestions();
        List<ElementAndFactDb> SelectElementsAndFacts();
        List<FactDb> SelectFacts();
        Guid InsertFact(string name);
        void DeleteFact(Guid guid);
        void UpdateFact(Guid guid, string newName);

        Guid[] InsertRule(string questionContent, string ruleName, Guid creatingFactGuid, Dictionary<Guid, bool> arguments);
    }
}