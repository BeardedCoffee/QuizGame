namespace QuizGame;

public class ResultSaver
{
    private const string PlayerFilePath = "Data/players.csv";

    public ResultSaver()
    {

    }

    public void SaveResults(string playerName, int answeredQuestions, int correctAnswers, int wrongAnswers, bool winner)
    {
        string[] playerLines = File.ReadAllLines(PlayerFilePath);
        string targetPlayerLine = playerLines.FirstOrDefault(line => line.StartsWith(playerName + ","));

        string[] playerData = targetPlayerLine.Split(',');

        int previousAnsweredQuestions = int.Parse(playerData[2]);
        int previousCorrectAnswers = int.Parse(playerData[3]);
        int previousWrongAnswers = int.Parse(playerData[4]);
        int previousMultiplayerWins = int.Parse(playerData[5]);

        int newAnsweredQuestions = previousAnsweredQuestions + answeredQuestions;
        int newCorrectAnswers = previousCorrectAnswers + correctAnswers;
        int newWrongAnswers = previousWrongAnswers + wrongAnswers;
        int newMultiplayerWins = previousMultiplayerWins;

        if (winner)
        {
            newMultiplayerWins++;
        }

        string updatedPlayerLine = $"{playerData[0]},{playerData[1]},{newAnsweredQuestions},{newCorrectAnswers},{newWrongAnswers},{newMultiplayerWins}";

        int targetPlayerIndex = Array.IndexOf(playerLines, targetPlayerLine);
        playerLines[targetPlayerIndex] = updatedPlayerLine;

        File.WriteAllLines(PlayerFilePath, playerLines);
    }

}
