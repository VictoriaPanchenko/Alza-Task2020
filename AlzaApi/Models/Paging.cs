using Microsoft.AspNetCore.Mvc;

namespace AlzaApi.Models
{
    /// <summary>
    /// Model for paged requests
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Page size (number of products per page)
        /// </summary>
        [FromQuery(Name = "limit")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// Number of products to skip
        /// </summary>
        [FromQuery(Name = "offset")]
        public int Offset { get; set; }
    }
}
