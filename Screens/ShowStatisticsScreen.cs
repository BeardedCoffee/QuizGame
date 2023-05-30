namespace QuizGame;

public class ShowStatisticsScreen
{
    private ILanguage currentLanguage;
    private static List<Player> players;
    private bool playerListScreen;
    private bool showPlayerStatsScreen;
    private int selectedOption;

    public ShowStatisticsScreen(ILanguage language)
    {
        currentLanguage = language;
        selectedOption = 0;
        LoadPlayers();
        ShowStatisticsHomeScreenProcessInput();
    }

    private void ShowStatisticsHomeScreenProcessInput()
    {
        playerListScreen = true;
        showPlayerStatsScreen = false;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentLanguage.PlayerStats);
            Console.WriteLine("-------------------");
            Console.WriteLine(currentLanguage.BackWithHashtag);
            Console.WriteLine(currentLanguage.ChoosePlayer);

            ConsoleKeyInfo keyInfo;

            do
            {
                if (playerListScreen)
                {
                    Console.Clear();
                    Console.WriteLine(currentLanguage.PlayerStats);
                    Console.WriteLine("---------------------------");

                    for (int i = 0; i < players.Count; i++)
                    {
                        if (i == selectedOption)
                        {
                            Console.Write("-> ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(players[i].Name);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("   " + players[i].Name);
                        }
                    }
                }
                else if (showPlayerStatsScreen)
                {
                    Console.Clear();
                    Console.WriteLine(currentLanguage.PlayerStats);
                    Console.WriteLine("-------------------");
                    Player selectedPlayer = players[selectedOption];
                    Console.WriteLine($"{currentLanguage.PlayerName} {selectedPlayer.Name}");
                    Console.WriteLine($"{currentLanguage.AnsweredQuestions} {selectedPlayer.AnsweredQuestions}");
                    Console.WriteLine($"{currentLanguage.CorrectAnswers} {selectedPlayer.CorrectAnswers}");
                    Console.WriteLine($"{currentLanguage.WrongAnswers} {selectedPlayer.WrongAnswers}");
                    Console.WriteLine($"{currentLanguage.MultiplayerWins} {selectedPlayer.MultiplayerWins}");
                    Console.WriteLine("\n------------------------------------");
                    Console.WriteLine(currentLanguage.PressButtonToContinue);
                    Console.ReadKey(intercept: true);

                    playerListScreen = true;
                    showPlayerStatsScreen = false;
                    break;
                }

                keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(currentLanguage.CanceledByUser);
                    return;
                }
                else if (keyInfo.KeyChar == '#')
                {
                    if (playerListScreen)
                    {
                        new HomeScreen(currentLanguage);
                        return;
                    }
                    else if (showPlayerStatsScreen)
                    {
                        playerListScreen = true;
                        showPlayerStatsScreen = false;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow && selectedOption > 0)
                {
                    selectedOption--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && selectedOption < players.Count - 1)
                {
                    selectedOption++;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (playerListScreen)
                    {
                        playerListScreen = false;
                        showPlayerStatsScreen = true;
                    }
                }
            } while (true);
        }
    }

    private static void LoadPlayers()
    {
        PlayerLoader playerLoader = new PlayerLoader();
        players = playerLoader.LoadPlayers();
    }
}