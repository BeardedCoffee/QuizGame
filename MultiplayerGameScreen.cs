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
        int totalQuestions = questions.Count;

        List<Player> activePlayers = new List<Player>(); 
        foreach(Player p in players)
        {
            activePlayers.Add(p);
        }

        List<int> wrongAnswerCounterList = new List<int>();
        List<int> correctAnswrCounterList = new List<int>();
        List<int> questionsAnsweredCounterList = new List<int>();
        foreach (Player player in activePlayers)
        {
            wrongAnswerCounterList.Add(0);
            correctAnswrCounterList.Add(0);
            questionsAnsweredCounterList.Add(0);
        }

        while (questions.Count > 0)
        {
            foreach (Player currentPlayer in activePlayers)
            {
                if (currentPlayer is not null)
                {
                    Question currentQuestion = questions[0];

                    Console.WriteLine("Multiplayer");
                    Console.WriteLine($"{currentLanguage.Player}: {currentPlayer.Name}");
                    Console.WriteLine(currentQuestion.QuestionText);
                    Console.WriteLine(currentLanguage.Answers);

                    int currentPlayerNr = activePlayers.IndexOf(currentPlayer);

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

                        Console.Write(currentLanguage.WrongAnswersAmount);
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
                        Console.WriteLine("Multiplayer");
                        Console.WriteLine($"{currentLanguage.Player}: {currentPlayer.Name}");
                        Console.WriteLine(currentQuestion.QuestionText);
                        Console.WriteLine(currentLanguage.Answers);

                    } while (!isValidInput);

                    int userAnswer = selectedAnswerIndex;

                    if (userAnswer == currentQuestion.CorrectAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(currentLanguage.Correct);
                        Console.ResetColor();
                        correctAnswrCounterList[currentPlayerNr]++;
                    }
                    else
                    {
                        wrongAnswerCounterList[currentPlayerNr]++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(currentLanguage.Wrong);
                        Console.ResetColor();

                        if (wrongAnswerCounterList[currentPlayerNr] > 3)
                        {
                            Console.WriteLine(currentLanguage.GameOver);
                            activePlayers[activePlayers.IndexOf(currentPlayer)] = null;
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                    }

                    questionsAnsweredCounterList[currentPlayerNr]++;

                    questions.RemoveAt(0);

                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            if (activePlayers.Count(player => player != null) == 0)
            {
                PrintPlayerResults(correctAnswrCounterList, wrongAnswerCounterList, questionsAnsweredCounterList);
            }
        }

        PrintPlayerResults(correctAnswrCounterList, wrongAnswerCounterList, questionsAnsweredCounterList);
    }

    private void PrintPlayerResults(List<int> correctAnswers, List<int> wrongAnswers, List<int> totalAnswers)
    {
        new MultiplayerResultScreen(players, correctAnswers, wrongAnswers, totalAnswers, currentLanguage);
    }
}