namespace FootballGame.Models
{
    public class Game
    {
        private Team _team1;

        private Team _team2;

        private Referee _referee;

        private Referee _firstAssistantReferee;

        private Referee _secondAssistantReferee;

        private Goal[] _goals;

        public Game(
            Team team1,
            Team team2,
            Referee referee,
            Referee firstAssistantReferee,
            Referee secondAssistantReferee,
            Goal[] goals)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            FirstAssistantReferee = firstAssistantReferee;
            SecondAssistantReferee = secondAssistantReferee;
            Goals = goals;
        }

        public Team Team1
        {
            get
            {
                return _team1;
            }
            private set
            {
                _team1 = value;
            }
        }

        public Team Team2
        {
            get
            {
                return _team2;
            }
            private set
            {
                _team2 = value;
            }
        }

        public Referee Referee
        {
            get
            {
                return _referee;
            }
            private set
            {
                _referee = value;
            }
        }

        public Referee FirstAssistantReferee
        {
            get
            {
                return _firstAssistantReferee;
            }
            private set
            {
                _firstAssistantReferee = value;
            }
        }

        public Referee SecondAssistantReferee
        {
            get
            {
                return _secondAssistantReferee;
            }
            private set
            {
                _secondAssistantReferee = value;
            }
        }

        public Goal[] Goals
        {
            get
            {
                return _goals;
            }
            private set
            {
                _goals = value;
            }
        }

        public GameResult GameResult
        {
            get
            {
                return CalculateGameResult();
            }
        }

        public Team? Winner
        {
            get
            {
                if(GameResult.Team1Score == GameResult.Team2Score)
                {
                    return null;
                }

                return GameResult.Team1Score > GameResult.Team2Score
                    ? Team1
                    : Team2;
            }
        }

        private GameResult CalculateGameResult()
        {
            int team1Score = 0;
            int team2Score = 0;

            foreach (Goal goal in Goals)
            {
                if(Team1.Players.Contains(goal.Player))
                {
                    if(goal.IsAuto)
                    {
                        team2Score += 1;
                    }
                    else
                    {
                        team1Score += 1;
                    }
                }

                if (Team2.Players.Contains(goal.Player))
                {
                    if (goal.IsAuto)
                    {
                        team1Score += 1;
                    }
                    else
                    {
                        team2Score += 1;
                    }
                }
            }

            return new GameResult(team1Score, team2Score);
        }
    }
}
