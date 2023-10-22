using System.ComponentModel;

namespace mis_421_assignment_3.Models
{
    public class ActorDetailsVM
    {
        public Actor Actor { get; set; }
        public List<RedditPost> RedditPosts { get; set; }
        public double SentimentScore { get; set; }

        public string OverallSentiment
        {
            get
            {
                if (SentimentScore > 0)
                    return "Positive";
                else if (SentimentScore < 0)
                    return "Negative";
                else
                    return "Neutral";
            }
        }
    }
}
