using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    /// <summary>
    /// IDataAccessLayer interface.
    /// </summary>
    public interface IDataAccessLayer
    {
        List<RuleDb> GetRules();
        List<ElementAndFactDb> GetElementsAndFacts();
    }
}