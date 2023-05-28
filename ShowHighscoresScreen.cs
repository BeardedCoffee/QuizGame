namespace QuizGame;

public class ShowHighscoresScreen
{
    private ILanguage currentLanguage;
    private const string PlayerFilePath = "players.csv";
    private static List<Player> players;
    private int selectedOption;

    public ShowHighscoresScreen(ILanguage language)
    {
        currentLanguage = language;
        selectedOption = 0;
        LoadPlayers();
        ShowHighscoresHomeScreenProcessInput();
    }

    public void ShowHighscoresHomeScreenProcessInput()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentLanguage.Highscores);
            Console.WriteLine("----------");
            Console.WriteLine(currentLanguage.BackWithHashtag);
            Console.WriteLine(currentLanguage.ChooseCategory);

            string[] options = new string[]
            {
                    currentLanguage.ChooseMostQuestionsAnswered,
                    currentLanguage.ChooseMostCorrectAnswers,
                    currentLanguage.ChooseMostMultiplayerWins
            };

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("-> ");
                    Console.WriteLine(options[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("   " + options[i]);
                }
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine(currentLanguage.CanceledByUser);
                return;
            }
            else if (keyInfo.KeyChar == '#')
            {
                new HomeScreen(currentLanguage);
                return;
            }
            else if (keyInfo.Key == ConsoleKey.UpArrow && selectedOption > 0)
            {
                selectedOption--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedOption < options.Length - 1)
            {
                selectedOption++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                break;
            }
        }

        Console.Clear();
        switch (selectedOption)
        {
            case 0:
                Console.WriteLine(currentLanguage.HighscoreMostQuestions);
                Console.WriteLine("--------------------------------------");
                List<Player> sortedPlayersByAnsweredQuestions = players.OrderByDescending(p => p.AnsweredQuestions).ToList();
                DisplayHighscores(sortedPlayersByAnsweredQuestions, selectedOption, currentLanguage);
                break;
            case 1:
                Console.WriteLine(currentLanguage.HighscoreMostCorrectAnswers);
                Console.WriteLine("---------------------------------");
                List<Player> sortedPlayersByCorrectAnswers = players.OrderByDescending(p => p.CorrectAnswers).ToList();
                DisplayHighscores(sortedPlayersByCorrectAnswers, selectedOption, currentLanguage);
                break;
            case 2:
                Console.WriteLine(currentLanguage.HighscoreMostWins);
                Console.WriteLine("-----------------------");
                List<Player> sortedPlayersByMultiplayerWins = players.OrderByDescending(p => p.MultiplayerWins).ToList();
                DisplayHighscores(sortedPlayersByMultiplayerWins, selectedOption, currentLanguage);
                break;
        }

        Console.WriteLine(currentLanguage.PressButtonToContinue);
        Console.ReadKey();
        new ShowHighscoresScreen(currentLanguage);
    }

    private static void LoadPlayers()
    {
        players = new List<Player>();

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
    }

    private static void DisplayHighscores(List<Player> sortedPlayers, int selectedOption, ILanguage currentLanguage)
    {
        if (sortedPlayers.Count == 0)
        {
            Console.WriteLine(currentLanguage.NoPlayersExisting);
            Console.WriteLine("\n------------------------------------");
            return;
        }

        for (int i = 0; i < sortedPlayers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sortedPlayers[i].Name}");

            switch (selectedOption)
            {
                case 0:
                    Console.WriteLine($"{currentLanguage.AnsweredQuestions} {sortedPlayers[i].AnsweredQuestions}");
                    break;
                case 1:
                    Console.WriteLine($"{currentLanguage.CorrectAnswers} {sortedPlayers[i].CorrectAnswers}");
                    break;
                case 2:
                    Console.WriteLine($"{currentLanguage.MultiplayerWins} {sortedPlayers[i].MultiplayerWins}");
                    break;
            }

            Console.WriteLine("------------------------------------");
        }
    }
}

