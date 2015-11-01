using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class DataProvider : IDataProvider
    {
        private readonly IDataAccessLayer dataAccessLayer;
        private readonly IMapper mapper;

        public DataProvider(IDataAccessLayer dataAccessLayer, IMapper mapper)
        {
            this.dataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }

        public List<Element> GetElements()
        {
            var dbEntities = dataAccessLayer.GetElementsAndFacts();
            return mapper.GetElements(dbEntities);
        }

        public List<Question> GetQuestions()
        {
            var dbEntities = dataAccessLayer.GetRulesAndQuestions();
            return mapper.GetQuestions(dbEntities);
        }
    }
}
