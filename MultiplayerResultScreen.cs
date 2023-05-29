namespace QuizGame;

public class MultiplayerResultScreen
{
    List<Player> players;
    List<int> correctAnswers;
    List<int> wrongAnswers;
    List<int> totalAnswers;
    ILanguage currentLanguage;

    public MultiplayerResultScreen(List<Player> players, List<int> correctAnswers, List<int> wrongAnswers, List<int> totalAnswers, ILanguage language)
    {
        this.players = players;
        this.correctAnswers = correctAnswers;
        this.wrongAnswers = wrongAnswers;
        this.totalAnswers = totalAnswers;
        currentLanguage = language;

        ShowResults();
    }

    private void ShowResults()
    {
        Console.Clear();
        Console.WriteLine(currentLanguage.FinalResults);
        Console.WriteLine();

        int totalPlayers = players.Count;

        for (int place = 1; place <= totalPlayers; place++)
        {
            ResultSaver resultSaver = new ResultSaver();
            if(place == 1)
            {
            resultSaver.SaveResults(players[place-1].Name, totalAnswers[place-1], correctAnswers[place-1], wrongAnswers[place-1], true);
            }else
            {
            resultSaver.SaveResults(players[place-1].Name, totalAnswers[place-1], correctAnswers[place-1], wrongAnswers[place-1], false);
            }

            int highestCorrectAnswers = correctAnswers.Max();
            int highestIndex = correctAnswers.IndexOf(highestCorrectAnswers);

            Player player = players[highestIndex];
            int wrongAnswerCount = wrongAnswers[highestIndex];

            Console.WriteLine($"Platz {place}: {player.Name}");
            Console.WriteLine($"{currentLanguage.CorrectAnswers} {highestCorrectAnswers}");
            Console.WriteLine($"{currentLanguage.WrongAnswers} {wrongAnswerCount}");
            Console.WriteLine();

            correctAnswers[highestIndex] = -1;
        }

        Console.WriteLine(currentLanguage.PressButtonToContinue);
        Console.ReadKey();
        new HomeScreen(currentLanguage);
    }

}