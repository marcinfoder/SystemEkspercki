using System;

namespace SystemEkspercki
{
    public class FactComboBoxItem
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}