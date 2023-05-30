namespace QuizGame;

public class AddPlayerScreen
{
    private ILanguage currentLanguage;
    private const string PlayerFilePath = "Data/players.csv";

    public AddPlayerScreen(ILanguage language)
    {
        currentLanguage = language;
        ShowAddPlayerScreenGetResponse();
    }

    public void ShowAddPlayerScreenGetResponse()
    {
        Console.WriteLine(currentLanguage.AddPlayer);
        Console.WriteLine("------------------");
        Console.WriteLine(currentLanguage.BackWithHashtag);

        string playerName = ReadInput(currentLanguage.TypeNameOfPlayer, currentLanguage);
        if (playerName == "#")
        {
            new HomeScreen(currentLanguage);
            return;
        }

        if (string.IsNullOrEmpty(playerName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(currentLanguage.InvalidName);
            Console.ResetColor();
            ShowAddPlayerScreenGetResponse();
            return;
        }

        if (IsPlayerNameTaken(playerName))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(currentLanguage.NameNotAvailable);
            Console.ResetColor();
            ShowAddPlayerScreenGetResponse();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(currentLanguage.NameAvailable);
        Console.ResetColor();

        string password = ReadInput(currentLanguage.EnterPassword, currentLanguage, maskInput: true);
        if (password == "#")
        {
            new HomeScreen(currentLanguage);
            return;
        }

        Player newPlayer = new Player { Name = playerName, Password = password };
        AddPlayer(newPlayer);

        Console.WriteLine(currentLanguage.AddedPlayerSuccessfully);
        Console.WriteLine();
        Console.WriteLine(currentLanguage.PressButtonToContinue);
        Console.ReadKey();
        new HomeScreen(currentLanguage);
        return;
    }

    private static string ReadInput(string message, ILanguage currentLanguage, bool maskInput = false)
    {
        Console.Write(message);

        string input = "";

        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (keyInfo.Key == ConsoleKey.Backspace)
            {
                if (input.Length > 0)
                {
                    input = input.Substring(0, input.Length - 1);
                    Console.Write("\b \b");
                }
            }
            else
            {
                if (keyInfo.KeyChar == '#')
                {
                    new HomeScreen(currentLanguage);
                }
                else
                {
                    input += keyInfo.KeyChar;
                    if (maskInput)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(keyInfo.KeyChar);
                    }
                }
            }
        }
        while (true);

        return input;
    }

    private static bool IsPlayerNameTaken(string playerName)
    {
        if (!File.Exists(PlayerFilePath))
            return false;

        string[] lines = File.ReadAllLines(PlayerFilePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string existingPlayerName = parts[0];
            if (existingPlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }

    public static void AddPlayer(Player player)
    {
        string playerData = $"{player.Name},{player.Password},0,0,0,0";
        File.AppendAllText(PlayerFilePath, playerData + Environment.NewLine);
    }
}