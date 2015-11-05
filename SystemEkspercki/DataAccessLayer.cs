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
        public List<RuleAndQuestionDb> GetRulesAndQuestions()
        {
            List<RuleAndQuestionDb> rulesAndQuestions  = new List<RuleAndQuestionDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectRulesAndQuestions, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    rulesAndQuestions.Add(new RuleAndQuestionDb
                    {
                        RuleId = (Guid)reader["RuleId"],
                        RuleName = (string)reader["RuleName"],
                        QuestionId = (Guid)reader["QuestionId"],
                        QuestionName = (string)reader["QuestionName"],
                        QuestionContent = (string)reader["QuestionContent"],
                        CreatingFactId = (Guid)reader["RuleCreatingFactId"],
                        RuleArgument = (Guid)reader["RuleArgument"],
                        ArgumentRequiredValue = (bool)reader["ArgumentRequiredValue"]
                    });
                }
            }

            return rulesAndQuestions;
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

        /// <summary>
        /// Get facts
        /// </summary>
        /// <returns></returns>
        public List<FactDb> GetFacts()
        {
            List<FactDb> elementsAndFacts = new List<FactDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectFacts, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    elementsAndFacts.Add(new FactDb
                    {
                        Id = (Guid)reader["FactId"],
                        Name = (string)reader["FactName"]
                    });
                }
            }

            return elementsAndFacts;
        }
    }
}