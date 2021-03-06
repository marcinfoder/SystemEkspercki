﻿using System;
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
                            FactId = (Guid) reader["FactId"],
                            FactName = (string) reader["FactName"],
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

        /// <summary>
        /// InsertRule
        /// </summary>
        /// <param name="questionContent"></param>
        /// <param name="ruleName"></param>
        /// <param name="creatingFactGuid"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public Guid[] InsertRule(string questionContent, string ruleName, Guid creatingFactGuid, Dictionary<Guid, bool> arguments)
        {
            Guid ruleId, questionId;

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.InsertRule, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter questionContentPar = command.Parameters.Add("@QuestionContent", SqlDbType.NVarChar);
                questionContentPar.Value = questionContent;
                questionContentPar.Size = 128;

                SqlParameter ruleNamePar = command.Parameters.Add("@RuleName", SqlDbType.NVarChar);
                ruleNamePar.Value = ruleName;
                ruleNamePar.Size = 32;

                command.Parameters.Add("@CreatingFactGuid", SqlDbType.UniqueIdentifier).Value = creatingFactGuid;

                SqlParameter ruleIdPar = command.Parameters.Add("@RuleId", SqlDbType.UniqueIdentifier);
                ruleIdPar.Direction = ParameterDirection.Output;

                SqlParameter questionIdPar = command.Parameters.Add("@QuestionId", SqlDbType.UniqueIdentifier);
                questionIdPar.Direction = ParameterDirection.Output;

                DataTable ruleArgs = new DataTable("RuleArgs");
                ruleArgs.Columns.Add("FactId", typeof(Guid));
                ruleArgs.Columns.Add("Value", typeof(bool));

                foreach (var arg in arguments)
                {
                    ruleArgs.Rows.Add(arg.Key, arg.Value);
                }

                command.Parameters.Add("@RuleArgs", SqlDbType.Structured).Value = ruleArgs;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                ruleId = (Guid)ruleIdPar.Value;
                questionId = (Guid)questionIdPar.Value;
            }

            return new Guid[]
            {
                ruleId,
                questionId
            };
        }

        /// <summary>
        /// Insert element
        /// </summary>
        /// <param name="elementName"></param>
        /// <param name="factsAboutElement"></param>
        /// <returns></returns>
        public Guid InsertElement(string elementName, Dictionary<Guid, bool> factsAboutElement)
        {
            Guid elementGuid;

            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.InsertElement, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter elementNamePar = command.Parameters.Add("@ElementName", SqlDbType.NVarChar);
                elementNamePar.Value = elementName;
                elementNamePar.Size = 128;

                SqlParameter elementIdPar = command.Parameters.Add("@ElementId", SqlDbType.UniqueIdentifier);
                elementIdPar.Direction = ParameterDirection.Output;

                DataTable factsAboutElementPar = new DataTable("@FactsAboutElement");
                factsAboutElementPar.Columns.Add("FactId", typeof(Guid));
                factsAboutElementPar.Columns.Add("Value", typeof(bool));

                foreach (var arg in factsAboutElement)
                {
                    factsAboutElementPar.Rows.Add(arg.Key, arg.Value);
                }

                command.Parameters.Add("@FactsAboutElement", SqlDbType.Structured).Value = factsAboutElementPar;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                elementGuid = (Guid)elementIdPar.Value;
            }

            return elementGuid;
        }

        /// <summary>
        /// delete rule
        /// </summary>
        /// <param name="guid"></param>
        public void DeleteRule(Guid guid)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.DeleteRule, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier).Value = guid;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        /// <summary>
        /// delete element
        /// </summary>
        /// <param name="guid"></param>
        public void DeleteElement(Guid guid)
        {
            using (SqlConnection connection = new SqlConnection(DataAccessLayerStrings.ExpertDbConnectionString))
            {
                SqlCommand command = new SqlCommand(DataAccessLayerStrings.DeleteElement, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Guid", SqlDbType.UniqueIdentifier).Value = guid;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}