using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    /// <summary>
    /// Inference module
    /// </summary>
    public class InferenceModule : IInferenceModule
    {
        /// <summary>
        /// readonly items
        /// </summary>
        private readonly IDataProvider dataProvider;

        /// <summary>
        /// Properies
        /// </summary>
        public List<Question> Questions { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataProvider"></param>
        public InferenceModule(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;

            Questions = this.dataProvider.GetQuestions();
        }
    }
}