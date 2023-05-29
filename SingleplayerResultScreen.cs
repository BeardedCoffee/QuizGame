namespace QuizGame;

public class SingleplayerResultScreen
{
    Player player;
    int correctAnswers;
    int wrongAnswers;
    int totalAnswers;
    ILanguage currentLanguage;

    public SingleplayerResultScreen(Player player, int correctAnswers, int wrongAnswers, int totalAnswers, ILanguage language)
    {
        this.player = player;
        this.correctAnswers = correctAnswers;
        this.wrongAnswers = wrongAnswers;
        this.totalAnswers = totalAnswers;
        currentLanguage = language;

        ShowResults();
    }

    private void ShowResults()
    {
        ResultSaver resultSaver =  new ResultSaver();
        resultSaver.SaveResults(player.Name, totalAnswers, correctAnswers, wrongAnswers, false);

        Console.Clear();
        Console.WriteLine(currentLanguage.FinalResults);
        Console.WriteLine();

        Console.WriteLine($"{currentLanguage.Player} {player.Name}");
        Console.WriteLine($"{currentLanguage.CorrectAnswers} {correctAnswers}");
        Console.WriteLine($"{currentLanguage.WrongAnswers} {wrongAnswers}");
        Console.WriteLine();
        Console.WriteLine(currentLanguage.PressButtonToContinue);
        Console.ReadKey();
        new HomeScreen(currentLanguage);
    }

}