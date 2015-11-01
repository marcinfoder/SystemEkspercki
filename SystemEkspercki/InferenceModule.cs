using System;
using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class InferenceModule : IInferenceModule
    {
        private readonly IDataProvider dataProvider;

        public InferenceModule(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;

            Questions = dataProvider.GetQuestions();
        }

        public List<Question> Questions { get; private set; }
    }
}
