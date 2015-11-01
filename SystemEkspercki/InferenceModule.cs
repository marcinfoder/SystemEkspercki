using System;
using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class InferenceModule
    {
        private readonly IMapper mapper;
        private List<Element> elements; 

        public InferenceModule(IMapper mapper)
        {
            if (mapper == null)
            {
                throw new ArgumentNullException("mapper");
            }

            this.mapper = mapper;
        }
    }
}
