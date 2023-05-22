using FootballGame.Models;

public class Program
{
    public static void Main()
    {
        FootballPlayer[] players1 = new FootballPlayer[]
        {
           new Goalkeeper("Player1", 1, 20, 1.84f),
           new Defender("Player2", 2, 20, 1.84f),
           new Defender("Player3", 3, 20, 1.84f),
           new Defender("Player4", 4, 20, 1.84f),
           new Defender("Player5", 5, 20, 1.84f),
           new Midfield("Player6", 6, 20, 1.84f),
           new Midfield("Player7", 7, 20, 1.84f),
           new Midfield("Player8", 8, 20, 1.84f),
           new Striker("Player9", 9, 20, 1.84f),
           new Striker("Player10", 10, 20, 1.84f),
           new Striker("Player11", 11, 20, 1.84f),
        };

        FootballPlayer[] players2 = new FootballPlayer[]
        {
           new Goalkeeper("Player1", 1, 20, 1.84f),
           new Defender("Player2", 2, 20, 1.84f),
           new Defender("Player3", 3, 20, 1.84f),
           new Defender("Player4", 4, 20, 1.84f),
           new Defender("Player5", 5, 20, 1.84f),
           new Midfield("Player6", 6, 20, 1.84f),
           new Midfield("Player7", 7, 20, 1.84f),
           new Midfield("Player8", 8, 20, 1.84f),
           new Striker("Player9", 9, 20, 1.84f),
           new Striker("Player10", 10, 20, 1.84f),
           new Striker("Player11", 11, 20, 1.84f),
        };

        Coach coach1 = new Coach("Coach1", 39);
        Coach coach2 = new Coach("Coach2", 42);

        Referee referee = new Referee("Referee1", 24);
        Referee assistantReferee1 = new Referee("Referee2", 28);
        Referee assistantReferee2 = new Referee("Referee3", 26);


        Team firstTeam = new Team("Team 1", coach1, players1);
        Team secondTeam = new Team("Team 2", coach2, players2);

        Goal[] goals = new Goal[]
        {
            new Goal(5, firstTeam.Players[3]),
            new Goal(41, firstTeam.Players[3]),
            new Goal(92, secondTeam.Players[5])
        };

        Game game = new Game(
            firstTeam, 
            secondTeam, 
            referee, 
            assistantReferee1, 
            assistantReferee2,
            goals);

        if (game.GameResult.IsDraw)
        {
            Console.WriteLine("The game is a draw");
        } else
        {
            Console.WriteLine($"The winner is {game.Winner?.Name}");
        }

        Console.WriteLine($"{game.Team1.Name} {game.GameResult.Team1Score}:{game.GameResult.Team2Score} {game.Team2.Name}");
    }
}