using System;
using System.Collections.Generic;

namespace SystemEkspercki.Mapped
{
    public class Element
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<FactAboutElement> Facts { get; set; }
    }
}