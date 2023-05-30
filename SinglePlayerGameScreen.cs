namespace QuizGame;

using System.Threading;

public class SinglePlayerGameScreen
{
    private Player player;
    private List<Question> questions;
    private int difficultyLevel;
    private ILanguage currentLanguage;

    public SinglePlayerGameScreen(Player player, List<Question> questions, int difficultyLevel, ILanguage language)
    {
        this.player = player;
        this.questions = questions;
        this.difficultyLevel = difficultyLevel;
        currentLanguage = language;

        PlayGame();
    }

    public void PlayGame()
    {
        int wrongAnswersCount = 0;
        int correctAnswerCount = 0;
        int questionsAnsweredCount = 0;
        List<string> wrongAnswerSymbols = new List<string>();

        foreach (Question question in questions)
        {
            Console.WriteLine("Singleplayer");
            Console.WriteLine($"{currentLanguage.Player}: {player.Name}");
            Console.WriteLine(question.QuestionText);
            Console.WriteLine(currentLanguage.Answers);

            int selectedAnswerIndex = 0;
            bool isValidInput = false;

            do
            {
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if (i == selectedAnswerIndex)
                    {
                        Console.Write("-> ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(question.Answers[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {question.Answers[i]}");
                    }
                }

                Console.Write(currentLanguage.WrongAnswersAmount);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(string.Join(" ", wrongAnswerSymbols));
                Console.ResetColor();
                Console.WriteLine();

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedAnswerIndex = (selectedAnswerIndex - 1 + question.Answers.Count) % question.Answers.Count;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedAnswerIndex = (selectedAnswerIndex + 1) % question.Answers.Count;
                        break;
                    case ConsoleKey.Enter:
                        isValidInput = true;
                        break;
                }

                Console.Clear();
                Console.WriteLine("Multiplayer");
                Console.WriteLine($"{currentLanguage.Player}: {player.Name}");
                Console.WriteLine(question.QuestionText);
                Console.WriteLine(currentLanguage.Answers);

            } while (!isValidInput);

            int userAnswer = selectedAnswerIndex;

            if (userAnswer == question.CorrectAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(currentLanguage.Correct);
                Console.ResetColor();
                correctAnswerCount++;
            }
            else
            {
                wrongAnswersCount++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(currentLanguage.Wrong);
                Console.ResetColor();
                wrongAnswerSymbols.Add("[X]");

                if (wrongAnswersCount > 3)
                {
                    Console.WriteLine("Game Over!");
                    PrintPlayerResult(correctAnswerCount, wrongAnswersCount, questionsAnsweredCount);
                    return;
                }
            }
            Thread.Sleep(2000);
            Console.Clear();
        }

        questionsAnsweredCount++;

        PrintPlayerResult(correctAnswerCount, wrongAnswersCount, questionsAnsweredCount);
    }

    private void PrintPlayerResult(int correctAnswers, int wrongAnswers, int totalAnswers)
    {
        ResultScreen resultScreen = new SingleplayerResultScreen(player, correctAnswers, wrongAnswers, totalAnswers, currentLanguage);
        resultScreen.DisplayResults();
        return;
    }
}