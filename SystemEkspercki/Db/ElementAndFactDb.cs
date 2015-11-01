using System;

namespace SystemEkspercki.Db
{
    public class ElementAndFactDb
    {
        public Guid ElementId { get; set; }
        public string ElementName { get; set; }
        public Guid FactId { get; set; }
        public string FactName { get; set; }
        public bool Value { get; set; }
    }
}