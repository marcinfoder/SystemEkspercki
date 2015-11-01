using System;

namespace SystemEkspercki.Db
{
    public class RuleDb
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid QuestionId { get; set; }
        public Guid CreatingFactId { get; set; }
    }
}
