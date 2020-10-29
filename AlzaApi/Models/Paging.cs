using Microsoft.AspNetCore.Mvc;

namespace AlzaApi.Models
{
    public class Paging
    {
        [FromQuery(Name = "limit")]
        public int Limit { get; set; } = 10;

        [FromQuery(Name = "offset")]
        public int Offset { get; set; }
    }
}
