using System;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class Answer
    {
        public Question Question { get; set; }
        public Guid QuestionId { get; set; }
        public bool? Value { get; set; }
    }
}