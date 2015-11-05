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
                return "Server=.;Database=myDataBase;Trusted_Connection=True;";
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
    }
}