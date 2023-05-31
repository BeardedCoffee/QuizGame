namespace QuizGame;

public class SingleplayerResultScreen : ResultScreen
    {
        public SingleplayerResultScreen(Player player, int correctAnswers, int wrongAnswers, int totalAnswers, ILanguage language)
            : base(player, correctAnswers, wrongAnswers, totalAnswers, language)
        {
        }

        public override void DisplayResults()
        {
            ResultSaver resultSaver = new ResultSaver();
            resultSaver.SaveResults(players[0].Name, totalAnswers[0], correctAnswers[0], wrongAnswers[0], false);

            Console.Clear();
            Console.WriteLine(currentLanguage.FinalResults);
            Console.WriteLine();

            Console.WriteLine($"{currentLanguage.Player} {players[0].Name}");
            Console.WriteLine($"{currentLanguage.CorrectAnswers} {correctAnswers[0]}");
            Console.WriteLine($"{currentLanguage.WrongAnswers} {wrongAnswers[0]}");
            Console.WriteLine();
            Console.WriteLine(currentLanguage.PressButtonToContinue);
            Console.ReadKey();
            new HomeScreen(currentLanguage);
        }
    }