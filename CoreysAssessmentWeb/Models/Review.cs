using Newtonsoft.Json;

namespace CoreysAssessmentWeb.Models
{
    public class Review
    {
        [JsonProperty("review")] 
        public string Content { get; set; }

        [JsonProperty("starRating")]
        public int StarRating { get; set; }
    }
}
