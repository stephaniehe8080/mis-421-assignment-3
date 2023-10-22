using System.ComponentModel;

namespace mis_421_assignment_3.Models
{
    public class RedditPost
    {
        [DisplayName("Reddit Post")]
        public string Content { get; set; }
        [DisplayName("Sentiment Score")]
        public double SentimentScore { get; set; }
    }
}
