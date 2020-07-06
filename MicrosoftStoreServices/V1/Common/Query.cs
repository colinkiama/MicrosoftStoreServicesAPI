namespace WindowsStoreServices.V1.Common
{
    /// <summary>
    /// Base query
    /// </summary>
    public abstract class Query
    {
        /// <summary>
        /// Gets the query name part of the URL
        /// </summary>
        public abstract string QueryName { get; }

        /// <summary>
        /// Build the URL of the query
        /// </summary>
        /// <returns>The generated URL</returns>
        public virtual string GetUrl()
        {
            return QueryName;
        }
    }
}
