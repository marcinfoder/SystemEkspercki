using System.Collections.Generic;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public interface IInferenceModule
    {
        List<Question> Questions { get; }
        List<Element> Elements { get; }
        List<Fact> Facts { get; }
        List<Element> InferenceProces(List<Answer> answers, out string log);
    }
}