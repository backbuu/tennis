using System;

namespace TennisLib
{
    public class Tennis
    {
        int scoreA;
        int scoreB;
        string[] scoreDisplay = { "LOVE", "15", "30", "40" };
        int scorePoint = 4;
        public string Score()
        {
            if (scoreA < scorePoint)
            {
                return scoreDisplay[scoreA] + "-" + scoreDisplay[scoreB];
            }
            return "WIN FOR A";
        }
        public void AGetPoint()
        {
            this.scoreA++;
        }
        public void BGetPoint()
        {
            this.scoreB++;
        }
    }
}
