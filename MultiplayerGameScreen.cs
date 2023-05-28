namespace QuizGame;

using System.Threading;

public class MultiplayerGameScreen
{
    private List<Player> players;
    private List<Question> questions;
    private int difficultyLevel;
    private ILanguage currentLanguage;

    public MultiplayerGameScreen(List<Player> players, List<Question> questions, int difficultyLevel, ILanguage language)
    {
        this.players = players;
        this.questions = questions;
        this.difficultyLevel = difficultyLevel;
        currentLanguage = language;

        PlayGame();
    }

    public void PlayGame()
    {
        Console.WriteLine("Multiplayer-Modus");

        int totalQuestions = questions.Count;
        List<int> wrongAnswerCounterList = new List<int>();
        foreach (Player player in players)
        {
            wrongAnswerCounterList.Add(0);
        }

        while (questions.Count > 0)
        {
            foreach (Player currentPlayer in players)
            {
                Question currentQuestion = questions[0];

                Console.WriteLine($"{currentLanguage.Player}: {currentPlayer.Name}");
                Console.WriteLine(currentQuestion.QuestionText);
                Console.WriteLine("Antworten:");

                int currentPlayerNr = players.IndexOf(currentPlayer);

                int selectedAnswerIndex = 0;
                bool isValidInput = false;

                do
                {
                    for (int i = 0; i < currentQuestion.Answers.Count; i++)
                    {
                        if (i == selectedAnswerIndex)
                        {
                            Console.Write("-> ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(currentQuestion.Answers[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"   {currentQuestion.Answers[i]}");
                        }
                    }

                    Console.Write("Wrong answers: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < wrongAnswerCounterList[currentPlayerNr]; i++)
                    {
                        if (wrongAnswerCounterList[currentPlayerNr] != 0)
                        {
                            Console.Write("[X] ");
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine();

                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            selectedAnswerIndex = (selectedAnswerIndex - 1 + currentQuestion.Answers.Count) % currentQuestion.Answers.Count;
                            break;
                        case ConsoleKey.DownArrow:
                            selectedAnswerIndex = (selectedAnswerIndex + 1) % currentQuestion.Answers.Count;
                            break;
                        case ConsoleKey.Enter:
                            isValidInput = true;
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine($"{currentLanguage.Player}: {currentPlayer.Name}");
                    Console.WriteLine(currentQuestion.QuestionText);
                    Console.WriteLine("Antworten:");

                } while (!isValidInput);

                int userAnswer = selectedAnswerIndex;

                if (userAnswer == currentQuestion.CorrectAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Richtig!");
                    Console.ResetColor();
                    currentPlayer.CorrectAnswers++;
                }
                else
                {
                    wrongAnswerCounterList[currentPlayerNr]++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsch!");
                    Console.ResetColor();
                    currentPlayer.WrongAnswers++;

                    if (wrongAnswerCounterList[currentPlayerNr] > 3)
                    {
                        Console.WriteLine("Game Over!");
                        players.Remove(currentPlayer);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    }
                }

                currentPlayer.AnsweredQuestions++;

                questions.RemoveAt(0);

                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        Console.WriteLine("Spiel beendet!");
        PrintPlayerResults();
    }

    private void PrintPlayerResults()
    {
        Console.WriteLine("Endergebnisse:");

        foreach (Player player in players)
        {
            Console.WriteLine($"Spieler: {player.Name}");
            Console.WriteLine($"Richtige Antworten: {player.CorrectAnswers}");
            Console.WriteLine($"Falsche Antworten: {player.WrongAnswers}");
            Console.WriteLine();
        }
    }
}