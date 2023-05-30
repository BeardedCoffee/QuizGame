namespace QuizGame;

public class PlayerLoader
{
    private const string PlayerFilePath = "Data/players.csv";
    public PlayerLoader()
    {

    }

    public List<Player> LoadPlayers()
    {
        List<Player> players = new List<Player>();

        if (File.Exists(PlayerFilePath))
        {
            string[] lines = File.ReadAllLines(PlayerFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Player player = new Player
                {
                    Name = parts[0],
                    Password = parts[1],
                    AnsweredQuestions = int.Parse(parts[2]),
                    CorrectAnswers = int.Parse(parts[3]),
                    WrongAnswers = int.Parse(parts[4]),
                    MultiplayerWins = int.Parse(parts[5])
                };
                players.Add(player);
            }
        }
        return players;
    }

}