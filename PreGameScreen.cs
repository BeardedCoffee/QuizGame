namespace QuizGame;

using System.Text;

public class PreGameScreen
{
    private ILanguage currentLanguage;
    private const string PlayerFilePath = "players.csv";
    private static List<Player> players;
    private bool[] selectedPlayers;
    private int currentDifficultyLevel;
    private int currentTimeLimitIndex;
    private readonly int[] timeLimits = { 0, 20, 15, 10 };

    public PreGameScreen(ILanguage language)
    {
        currentLanguage = language;
        players = new List<Player>();
        LoadPlayers();
        selectedPlayers = new bool[players.Count];
        currentDifficultyLevel = 1;
        currentTimeLimitIndex = 0;

        ShowPreGameScreenGetResponse();
    }

    private static void LoadPlayers()
    {
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

    public void ShowPreGameScreenGetResponse()
    {
        Console.WriteLine(currentLanguage.GameConfiguration);
        Console.WriteLine("----------------");

        string[] options = new string[]
        {
        currentLanguage.SelectPlayers,
        $"{currentLanguage.ChooseDifficulty} [{currentDifficultyLevel}]",
        $"{currentLanguage.ToggleTimeLimit} [{GetTimeLimitString()}]",
        currentLanguage.StartGame
        };

        int selectedOption = 0;
        bool exitScreen = false;
        bool startGame = false;

        while (!exitScreen)
        {
            Console.Clear();
            Console.WriteLine(currentLanguage.GameConfiguration);
            Console.WriteLine("----------------");
            ShowOptions(options, selectedOption);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Oem2:
                    exitScreen = true;
                    break;
                case ConsoleKey.UpArrow:
                    selectedOption = (selectedOption - 1 + options.Length) % options.Length;
                    break;
                case ConsoleKey.DownArrow:
                    selectedOption = (selectedOption + 1) % options.Length;
                    break;
                case ConsoleKey.Enter:
                    switch (selectedOption)
                    {
                        case 0:
                            ShowPlayerSelection();
                            break;
                        case 1:
                            currentDifficultyLevel = (currentDifficultyLevel % 3) + 1;
                            options[1] = $"{currentLanguage.ChooseDifficulty} [{currentDifficultyLevel}]";
                            break;
                        case 2:
                            ToggleTimeLimit();
                            options[2] = $"{currentLanguage.ToggleTimeLimit} [{GetTimeLimitString()}]";
                            break;
                        case 3:
                            startGame = StartGame();
                            break;
                    }
                    break;
            }
        }

        if (startGame)
        {
            new HomeScreen(currentLanguage);
            return;
        }
    }

    private void ShowOptions(string[] options, int selectedOption)
    {
        for (int i = 0; i < options.Length; i++)
        {
            if (i == selectedOption)
            {
                Console.Write("-> ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(options[i]);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("   " + options[i]);
            }
        }
    }

    public void ShowPlayerSelection()
    {
        Console.Clear();
        Console.WriteLine(currentLanguage.PlayerSelection);
        Console.WriteLine("----------------");

        string[] options = new string[players.Count];

        for (int i = 0; i < players.Count; i++)
        {
            options[i] = $"{i + 1}. {players[i].Name}";
        }

        int selectedOption = 0;
        int selectedPlayerCount = 0;
        bool exitScreen = false;

        while (!exitScreen)
        {
            Console.Clear();
            Console.WriteLine(currentLanguage.PlayerSelection);
            Console.WriteLine("----------------");
            ShowOptions(options, selectedOption);

            Console.WriteLine();
            Console.WriteLine(currentLanguage.SelectedPlayers);
            ShowSelectedPlayers(selectedPlayers);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Escape:
                    exitScreen = true;
                    break;
                case ConsoleKey.Oem2:
                    exitScreen = true;
                    break;
                case ConsoleKey.UpArrow:
                    selectedOption = (selectedOption - 1 + options.Length) % options.Length;
                    break;
                case ConsoleKey.DownArrow:
                    selectedOption = (selectedOption + 1) % options.Length;
                    break;
                case ConsoleKey.Enter:
                    if (selectedPlayers[selectedOption])
                    {
                        selectedPlayers[selectedOption] = false;
                        selectedPlayerCount--;
                    }
                    else
                    {
                        if (selectedPlayerCount < 4)
                        {
                            string password = ReadInput(currentLanguage.EnterUserPassword, currentLanguage, maskInput: true);
                            if (password == "#")
                            {
                                return;
                            }

                            if (VerifyPlayerPassword(selectedOption, password))
                            {
                                selectedPlayers[selectedOption] = true;
                                selectedPlayerCount++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(currentLanguage.InvalidPassword);
                                Console.ResetColor();
                                Console.WriteLine(currentLanguage.PressButtonToContinue);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(currentLanguage.Max4Players);
                            Console.ResetColor();
                            Console.WriteLine(currentLanguage.PressButtonToContinue);
                            Console.ReadKey();
                        }
                    }
                    break;
            }
        }
    }

    private void ShowSelectedPlayers(bool[] selectedPlayers)
    {
        for (int i = 0; i < selectedPlayers.Length; i++)
        {
            if (selectedPlayers[i])
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("- " + players[i].Name);
                Console.ResetColor();
            }
        }
    }

    private bool VerifyPlayerPassword(int playerIndex, string password)
    {
        Player player = players[playerIndex];
        return player.Password == password;
    }

    private static string ReadInput(string message, ILanguage currentLanguage, bool maskInput = false)
    {
        Console.Write(message);
        if (maskInput)
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (key.Key != ConsoleKey.Backspace)
                {
                    input.Append(key.KeyChar);
                    Console.Write(maskInput ? "*" : key.KeyChar.ToString());
                }
            }
            return input.ToString();
        }
        else
        {
            return Console.ReadLine();
        }
    }

    private void ToggleTimeLimit()
    {
        currentTimeLimitIndex = (currentTimeLimitIndex + 1) % timeLimits.Length;
    }

    private string GetTimeLimitString()
    {
        int timeLimit = timeLimits[currentTimeLimitIndex];
        return timeLimit == 0 ? "X" : $"{timeLimit}";
    }

    private bool StartGame()
    {
        List<Player> playerSelection = new List<Player>();
        for (int i = 0; i < selectedPlayers.Length; i++)
        {
            if (selectedPlayers[i])
            {
                playerSelection.Add(players[i]);
            }
        }

        if (playerSelection.Count > 0)
        {
            new Game(playerSelection, currentDifficultyLevel, timeLimits[currentTimeLimitIndex], currentLanguage);
            return true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(currentLanguage.Min1Player);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(currentLanguage.PressButtonToContinue);
            Console.ReadKey();
            return false;
        }

    }
}