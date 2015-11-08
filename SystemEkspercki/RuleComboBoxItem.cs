using System;

namespace SystemEkspercki
{
    public class RuleComboBoxItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}