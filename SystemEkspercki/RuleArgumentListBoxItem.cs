using System;

namespace SystemEkspercki
{
    public class RuleArgumentListBoxItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}