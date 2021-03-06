﻿using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    /// <summary>
    /// Data provider
    /// </summary>
    public class DataProvider : IDataProvider
    {
        /// <summary>
        /// readonly
        /// </summary>
        private readonly IDataAccessLayer dataAccessLayer;
        private readonly IMapper mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataAccessLayer"></param>
        /// <param name="mapper"></param>
        public DataProvider(IDataAccessLayer dataAccessLayer, IMapper mapper)
        {
            this.dataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets elements
        /// </summary>
        /// <returns></returns>
        public List<Element> GetElements()
        {
            var dbEntities = dataAccessLayer.SelectElementsAndFacts();
            return mapper.GetElements(dbEntities);
        }

        /// <summary>
        /// Gets questions
        /// </summary>
        /// <returns></returns>
        public List<Question> GetQuestions()
        {
            var dbEntities = dataAccessLayer.SelectRulesAndQuestions();
            return mapper.GetQuestions(dbEntities);
        }

        /// <summary>
        /// Gets facts
        /// </summary>
        /// <returns></returns>
        public List<Fact> GetFacts()
        {
            var dbEntities = dataAccessLayer.SelectFacts();
            return mapper.GetFacts(dbEntities);
        }
    }
}