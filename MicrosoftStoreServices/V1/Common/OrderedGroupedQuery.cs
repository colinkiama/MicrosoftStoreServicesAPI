using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStoreServices.V1.Common
{
    /// <summary>
    /// Base ordered and grouped query
    /// </summary>
    /// <typeparam name="TOrderBy">OrderBy Enum Type</typeparam>
    /// <typeparam name="TGroupBy">GroupBy Enum Type</typeparam>
    public abstract class OrderedGroupedQuery<TOrderBy, TGroupBy> : OrderedQuery<TOrderBy>
        where TOrderBy : struct
        where TGroupBy : struct
    {
        /// <summary>
        /// 
        /// </summary>
        public List<TGroupBy> GroupBy { get; set; }

        /// <summary>
        /// Build the URL of the query
        /// </summary>
        /// <returns>The generated URL</returns>
        public override string GetUrl()
        {
            var sb = new StringBuilder(base.GetUrl());

            if (GroupBy != null && GroupBy.Any())
            {
                var value = string.Join(",", GroupBy.Select(s => s.AsString()));
                sb.Append($"&groupby={value}");
            }

            return sb.ToString();
        }
    }
}
