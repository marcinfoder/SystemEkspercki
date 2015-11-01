using System;

namespace SystemEkspercki.Mapped
{
    public class Rule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Question Question { get; set; }
        public Guid CreatingFactId { get; set; }
    }
}
