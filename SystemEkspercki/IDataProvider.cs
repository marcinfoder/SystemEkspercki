using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public interface IDataProvider
    {
        List<Element> GetElements();
        List<Question> GetQuestions();
    }
}
