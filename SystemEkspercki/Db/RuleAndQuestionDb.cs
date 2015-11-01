using System;

namespace SystemEkspercki.Db
{
    public class RuleAndQuestionDb
    {
        public Guid RuleId { get; set; }
        public string RuleName { get; set; }
        public Guid QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string QuestionContent { get; set; }
        public Guid CreatingFactId { get; set; }
        public Guid RuleArgument { get; set; }
        public bool ArgumentRequiredValue { get; set; }
    }
}
