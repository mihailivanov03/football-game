﻿namespace FootballGame.Models
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(
            string name,
            int age,
            int number,
            double height)
            : base(name, age, number, height) { }
    }
}
