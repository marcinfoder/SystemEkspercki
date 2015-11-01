using System.Collections.Generic;
using SystemEkspercki.Db;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public interface IMapper
    {
        List<Element> GetElements(List<ElementAndFactDb> elementsAndFacts);
    }
}