using System;
using System.Collections.Generic;
using System.Data;
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
        public List<RuleAndQuestionDb> SelectRulesAndQuestions()
        {
            List<RuleAndQuestionDb> rulesAndQuestions  = new List<RuleAndQuestionDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectRulesAndQuestions, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rulesAndQuestions.Add(new RuleAndQuestionDb
                        {
                            RuleId = (Guid) reader["RuleId"],
                            RuleName = (string) reader["RuleName"],
                            QuestionId = (Guid) reader["QuestionId"],
                            QuestionName = (string) reader["QuestionName"],
                            QuestionContent = (string) reader["QuestionContent"],
                            CreatingFactId = (Guid) reader["RuleCreatingFactId"],
                            CreatingFactName = (string) reader["RuleCreatingFactName"],
                            RuleArgument = (Guid) reader["RuleArgument"],
                            ArgumentRequiredValue = (bool) reader["ArgumentRequiredValue"]
                        });
                    }
                }
            }

            return rulesAndQuestions;
        }

        /// <summary>
        /// Get elements
        /// </summary>
        /// <returns></returns>
        public List<ElementAndFactDb> SelectElementsAndFacts()
        {
            List<ElementAndFactDb> elementsAndFacts = new List<ElementAndFactDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectElementsAndFacts, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        elementsAndFacts.Add(new ElementAndFactDb
                        {
                            ElementId = (Guid) reader["ElementId"],
                            ElementName = (string) reader["ElementName"],
                            FactId = (Guid) reader["ElementId"],
                            FactName = (string) reader["ElementName"],
                            Value = (bool) reader["Value"]
                        });
                    }
                }
            }

            return elementsAndFacts;
        }

        /// <summary>
        /// Get facts
        /// </summary>
        /// <returns></returns>
        public List<FactDb> SelectFacts()
        {
            List<FactDb> elementsAndFacts = new List<FactDb>();

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.SelectFacts, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        elementsAndFacts.Add(new FactDb
                        {
                            Id = (Guid) reader["FactId"],
                            Name = (string) reader["FactName"]
                        });
                    }
                }
            }

            return elementsAndFacts;
        }

        /// <summary>
        /// Add new fact
        /// </summary>
        /// <param name="name"></param>
        public Guid InsertFact(string name)
        {
            Guid guid;

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.InsertFact, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar)
                {
                    Size = 128,
                    Value = name
                });

                SqlParameter outputParameter = command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier);
                outputParameter.Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                guid = (Guid)outputParameter.Value;
            }

            return guid;
        }

        /// <summary>
        /// Delete fact
        /// </summary>
        /// <param name="guid"></param>
        public void DeleteFact(Guid guid)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.DeleteFact, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier).Value = guid;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        /// <summary>
        /// Update fact
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="newName"></param>
        public void UpdateFact(Guid guid, string newName)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.UpdateFact, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier).Value = guid;

                var parameter = command.Parameters.Add("@NewName", SqlDbType.NVarChar);
                parameter.Value = newName;
                parameter.Size = 128;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}