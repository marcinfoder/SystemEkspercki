using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    /// <summary>
    /// IDataAccessLayer interface.
    /// </summary>
    public interface IDataAccessLayer
    {
        List<RuleAndQuestionDb> GetRulesAndQuestions();
        List<ElementAndFactDb> GetElementsAndFacts();
        List<FactDb> GetFacts();
    }
}