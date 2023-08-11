using System.Collections.Generic;

namespace CoreysAssessment.Models
{
    public class Review
    {
        public string? ReviewTime { get; set; }
        public string? ReviewerID { get; set; }
        public string? Asin { get; set; }
        public Dictionary<string, string>? Style { get; set; }
        public string? ReviewerName { get; set; }
        public string? ReviewText { get; set; }
        public string? Summary { get; set; }
        public List<string>? Image { get; set; }
    }
}
