namespace SystemEkspercki
{
    /// <summary>
    /// DataAccessLayerStrings class.
    /// </summary>
    public static class DataAccessLayerStrings
    {
        /// <summary>
        /// Gets the connection string to database.
        /// </summary>
        public static string ExpertDbConnectionString
        {
            get
            {
                return "Server=.;Database=Expert;Integrated Security=SSPI";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string SelectRulesAndQuestions
        {
            get
            {
                return "selectRulesAndQuestions";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string SelectElementsAndFacts
        {
            get
            {
                return "selectElementsAndFacts";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string SelectFacts
        {
            get
            {
                return "selectFacts";
            }
        }
        
        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string InsertFact
        {
            get
            {
                return "insertFact";
            }
        }
        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string DeleteFact
        {
            get
            {
                return "deleteFact";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string UpdateFact
        {
            get
            {
                return "updateFact";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string InsertRule
        {
            get
            {
                return "insertRule";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string InsertElement
        {
            get
            {
                return "insertElement";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string DeleteRule
        {
            get
            {
                return "deleteRule";
            }
        }

        /// <summary>
        /// Stored procedure name
        /// </summary>
        public static string DeleteElement
        {
            get
            {
                return "deleteElement";
            }
        }
    }
}