namespace FootballGame.Models
{
    public abstract class FootballPlayer : Person
    {
        private int _number;

        private double _height;

        public int Number
        {
            get
            {
                return _number;
            }
            private set
            {
                _number = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            private set
            {
                _height = value;
            }
        }

        public FootballPlayer(
            string name, 
            int age, 
            int number, 
            double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
