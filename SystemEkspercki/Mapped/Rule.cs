using System;
using System.Collections.Generic;

namespace SystemEkspercki.Mapped
{
    public class Rule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<RuleArgument> Arguments { get; set; }
        public Guid CreatingFact { get; set; }
    }
}
