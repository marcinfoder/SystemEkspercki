using System;
using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEksperckiTests
{
    public static class MapperTestHelper
    {
        public static List<ElementAndFactDb> CreateCorrectList()
        {
            return new List<ElementAndFactDb>
            {
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("42A0AEF9-013F-40BC-A5D4-36437367D6E3"),
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("8FDC2478-894D-436F-8B0B-216DCCF5490C"),
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("3B0EE13B-5DB5-4128-9523-B31982214BFE"),
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("6C29DE9D-51A2-4163-B78D-32C03C8A3221"),
                    FactId = Guid.Parse("F8FBF13B-D236-4CC7-B063-2B4D0AA1524F"),
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("6C29DE9D-51A2-4163-B78D-32C03C8A3221"),
                    FactId = Guid.Parse("0B3F8EBA-1529-4C80-B8BE-95D4828B70D2"),
                }
            };
        }
    }
}
