using System;
using System.Collections.Generic;
using SystemEkspercki.Db;

namespace SystemEksperckiTests
{
    public static class MapperTestHelper
    {
        public static List<ElementAndFactDb> CreateCorrectElementsAndFacts()
        {
            return new List<ElementAndFactDb>
            {
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("42A0AEF9-013F-40BC-A5D4-36437367D6E3")
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("8FDC2478-894D-436F-8B0B-216DCCF5490C")
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("534F4B12-F3DE-438C-961B-C4776D1FA05D"),
                    FactId = Guid.Parse("3B0EE13B-5DB5-4128-9523-B31982214BFE")
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("6C29DE9D-51A2-4163-B78D-32C03C8A3221"),
                    FactId = Guid.Parse("F8FBF13B-D236-4CC7-B063-2B4D0AA1524F")
                },
                new ElementAndFactDb
                {
                    ElementId = Guid.Parse("6C29DE9D-51A2-4163-B78D-32C03C8A3221"),
                    FactId = Guid.Parse("0B3F8EBA-1529-4C80-B8BE-95D4828B70D2")
                }
            };
        }

        public static List<RuleAndQuestionDb> CreateCorrectRulesAndQuestions()
        {
            return new List<RuleAndQuestionDb>
            {
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    QuestionId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    CreatingFactId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    RuleArgument = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2")
                },
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    QuestionId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    CreatingFactId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    RuleArgument = Guid.Parse("8B47ACBB-1CF0-48E0-9142-485DDB655E97")
                },
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    QuestionId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    CreatingFactId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    RuleArgument = Guid.Parse("55E97CBB-1CF0-48E0-9142-485DDB655E97")
                },
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    QuestionId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    CreatingFactId = Guid.Parse("97DBCF02-CA1D-4039-9BEC-0EC2443996C2"),
                    RuleArgument = Guid.Parse("48E0ACBB-1CF0-48E0-9142-485DDB655E97")
                },
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("8F7C593A-21AE-4218-BEEF-7857AD6F9DE0"),
                    QuestionId = Guid.Parse("8F7C593A-21AE-4218-BEEF-7857AD6F9DE0"),
                    CreatingFactId = Guid.Parse("8F7C593A-21AE-4218-BEEF-7857AD6F9DE0"),
                    RuleArgument = Guid.Parse("8F7C593A-21AE-4218-BEEF-7857AD6F9DE0")
                },
                new RuleAndQuestionDb
                {
                    RuleId = Guid.Parse("2AC7DB82-E72B-4370-BC6B-C1D7CA07EC23"),
                    QuestionId = Guid.Parse("2AC7DB82-E72B-4370-BC6B-C1D7CA07EC23"),
                    CreatingFactId = Guid.Parse("2AC7DB82-E72B-4370-BC6B-C1D7CA07EC23"),
                    RuleArgument = Guid.Parse("2AC7DB82-E72B-4370-BC6B-C1D7CA07EC23")
                },
            };
        }
    }
}