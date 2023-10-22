using VaderSharp2;

namespace mis_421_assignment_3.Services
{

    public class SentimentAnalysisService
    {
        public double AnalyzeSentiment(List<string> textToExamine)
        {
            var analyzer = new SentimentIntensityAnalyzer();
            double postsTotal = 0;
            int nonZeroCount = 0;

            foreach (string post in textToExamine)
            {
                var results = analyzer.PolarityScores(post);
                postsTotal += results.Compound;
                if (results.Compound != 0) nonZeroCount++;
            }

            var score = nonZeroCount > 0 ? postsTotal / nonZeroCount : 0;
            return score;
        }
    }

}
