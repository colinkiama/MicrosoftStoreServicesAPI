using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsStoreServices.V1.Common.Enums;

namespace WindowsStoreServices.V1.Common
{
    /// <summary>
    /// Base ordered query
    /// </summary>
    /// <typeparam name="TOrderBy">OrderBy Enum Type</typeparam>
    public abstract class OrderedQuery<TOrderBy> : Query
        where TOrderBy : struct
    {
        /// <summary>
        /// Gets or sets the product ID of the app/IAP for which you are retrieving data.
        /// </summary>
        public string ApplicationId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime? StartDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// 
        /// </summary>
        public DateTime? EndDate { get; set; } = DateTime.MaxValue;

        /// <summary>
        /// 
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AggregationLevels? AggregationLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Tuple<TOrderBy, OrderByDirections>> OrderBy { get; set; }

        /// <summary>
        /// Build the URL of the query
        /// </summary>
        /// <returns>The generated URL</returns>
        public override string GetUrl()
        {
            var sb = new StringBuilder();

            sb.Append($"{QueryName}?applicationId={ApplicationId}");

            if (StartDate.HasValue)
                sb.Append($"&startDate={StartDate.Value.ToString("MM/dd/yyyy")}");

            if (EndDate.HasValue)
                sb.Append($"&endDate={EndDate.Value.ToString("MM/dd/yyyy")}");

            if (Top.HasValue)
                sb.Append($"&top={Top.Value}");

            if (Skip.HasValue)
                sb.Append($"&skip={Skip.Value}");

            if (!string.IsNullOrEmpty(Filter))
                sb.Append($"&filter={Filter}");

            if (AggregationLevel.HasValue)
                sb.Append($"&aggregationLevel={AggregationLevel.Value.AsString()}");

            if (OrderBy != null && OrderBy.Any())
            {
                var value = string.Join(",", OrderBy.Select(o => $"{o.Item1.AsString()} {o.Item2.AsString()}"));
                sb.Append($"orderBy={value}");
            }

            return sb.ToString();
        }
    }
}
