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
        public static string SelectRules
        {
            get
            {
                return "selectRules";
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
    }
}