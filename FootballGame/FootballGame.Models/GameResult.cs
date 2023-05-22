namespace FootballGame.Models
{
    public class GameResult
    {
        public int Team1Score { get; set; }

        public int Team2Score { get; set; }

        public Boolean IsDraw { get; set; }

        public GameResult(int team1Score, int team2Score)
        {
            Team1Score = team1Score;
            Team2Score = team2Score;
            IsDraw = Team1Score == Team2Score;
        }
    }
}
