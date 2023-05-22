namespace FootballGame.Models
{
    public class Goal
    {
        private int _minute;

        private FootballPlayer _player;

        private bool _isAuto;

        public Goal(int minute, FootballPlayer player, bool isAuto = false)
        {
            Minute = minute;
            Player = player;
            IsAuto = isAuto;
        }

        public int Minute
        {
            get
            {
                return _minute;
            }
            private set
            {
                _minute = value;
            }
        }

        public FootballPlayer Player
        {
            get
            {
                return _player;
            }
            private set
            {
                _player = value;
            }
        }

        public bool IsAuto
        {
            get
            {
                return _isAuto;
            }
            private set
            {
                _isAuto = value;
            }
        }
    }
}
