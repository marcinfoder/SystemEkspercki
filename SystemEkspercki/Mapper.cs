using System;
using System.Collections.Generic;
using SystemEkspercki.Db;
using SystemEkspercki.Mapped;

namespace SystemEkspercki
{
    public class Mapper : IMapper
    {
        /// <summary>
        /// Create elements list
        /// </summary>
        /// <returns></returns>
        public List<Element> GetElements(List<ElementAndFactDb> elementsAndFacts)
        {
            List<Element> elements = new List<Element>();

            foreach (ElementAndFactDb elementAndFact in elementsAndFacts)
            {
                bool isFound = false;
                foreach (Element element in elements)
                {
                    if (elementAndFact.ElementId == element.Id)
                    {
                        element.Facts.Add(new FactAboutElement
                        {
                            Id = elementAndFact.FactId,
                            Name = elementAndFact.FactName,
                            Value = elementAndFact.Value
                        });

                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    elements.Add(NewElement(elementAndFact));
                }
            }

            return elements;
        }

        /// <summary>
        /// Adds new element to list
        /// </summary>
        /// <param name="elementAndFact"></param>
        /// <returns></returns>
        private Element NewElement(ElementAndFactDb elementAndFact)
        {
            return new Element
            {
                Id = elementAndFact.ElementId,
                Name = elementAndFact.ElementName,
                Facts = new List<FactAboutElement>
                {
                    new FactAboutElement
                    {
                        Id = elementAndFact.FactId,
                        Name = elementAndFact.FactName,
                        Value = elementAndFact.Value
                    }
                }
            };
        }
    }
}