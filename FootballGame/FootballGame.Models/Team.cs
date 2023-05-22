namespace FootballGame.Models
{
    public class Team
    {
        public const int MinTeamSize = 11;
        public const int MaxTeamSize = 22;

        private Coach _coach;

        private FootballPlayer[] _players;

        public string Name { get; private set; }

        public Coach Coach
        {
            get
            {
                return _coach;
            }
            private set
            {
                _coach = value;
            }
        }

        public FootballPlayer[] Players
        {
            get
            {
                return _players;
            }
            private set
            {
                if(value == null)
                    throw new ArgumentNullException("value");

                if (value.Length < MinTeamSize || value.Length > MaxTeamSize)
                    throw new ArgumentException("Team size must be between 11 and 22");

                _players = value;
            }
        }

        public int AveragePlayerAge
        {
            get
            {
                return CalculateAveragePlayerAge();
            }
        }

        public Team(string name, Coach coach, FootballPlayer[] players)
        {
            Name = name;
            Coach = coach;
            Players = players;
        }

        private int CalculateAveragePlayerAge()
        {
            int totalAge = 0;

            for (int i = 0; i < Players.Length; i++)
            {
                totalAge += Players[i].Age;
            }

            return totalAge / Players.Length;
        }
    }
}
