using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SystemEkspercki.Db;

namespace SystemEkspercki
{
    /// <summary>
    /// DataAccessLayer class.
    /// </summary>
    public class DataAccessLayer : IDataAccessLayer
    {
        /// <summary>
        /// Get rules from database
        /// </summary>
        /// <returns></returns>
        public List<RuleDb> GetRules()
        {
            List<RuleDb> rules  = new List<RuleDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectRules, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    rules.Add(new RuleDb
                    {
                        CreatingFactId = (Guid)reader["RuleCreatingFactId"],
                        Id = (Guid)reader["RuleId"],
                        Name = (string)reader["RuleName"],
                        QuestionId = (Guid)reader["RuleQuestionId"]
                    });
                }
            }

            return rules;
        }

        /// <summary>
        /// Get elements
        /// </summary>
        /// <returns></returns>
        public List<ElementAndFactDb> GetElementsAndFacts()
        {
            List<ElementAndFactDb> elementsAndFacts = new List<ElementAndFactDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectElementsAndFacts, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    elementsAndFacts.Add(new ElementAndFactDb
                    {
                        ElementId = (Guid)reader["ElementId"],
                        ElementName = (string)reader["ElementName"],
                        FactId = (Guid)reader["ElementId"],
                        FactName = (string)reader["ElementName"],
                        Value = (bool)reader["Value"]
                    });
                }
            }

            return elementsAndFacts;
        }
    }
}