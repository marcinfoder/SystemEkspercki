using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public interface IInferenceModule
    {
        List<Question> Questions { get; }

        List<Element> InferenceProces(List<Answer> answers);
    }
}