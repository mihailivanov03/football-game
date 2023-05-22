namespace FootballGame.Models
{
    public abstract class Person
    {
        private string _name;

        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            private set
            {
                _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
