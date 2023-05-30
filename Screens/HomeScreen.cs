namespace QuizGame;

public class HomeScreen
{
    private ILanguage currentLanguage;
    public HomeScreen(ILanguage language)
    {
        currentLanguage = language;
        int response = ShowHomeScreenGetResponse();
        ReactToResponse(response);
    }

    public int ShowHomeScreenGetResponse()
    {

        int selectedOption = 0;
        string[] options = { currentLanguage.NewGame, currentLanguage.AddPlayer, currentLanguage.ShowStatistics,
                            currentLanguage.ShowHighscores, currentLanguage.ChooseLanguage, currentLanguage.Exit};

        while (true)
        {
            Console.Clear();
            Console.WriteLine("-----QuizGame-----");
            Console.WriteLine("------------------");

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

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedOption > 0)
            {
                selectedOption--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedOption < options.Length - 1)
            {
                selectedOption++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return selectedOption + 1;
            }
        }
    }

    private void ReactToResponse(int response)
    {

        switch (response)
        {
            case 1:
                new PreGameScreen(currentLanguage);
                break;
            case 2:
                new AddPlayerScreen(currentLanguage);
                break;
            case 3:
                new ShowStatisticsScreen(currentLanguage);
                break;
            case 4:
                new ShowHighscoresScreen(currentLanguage);
                break;
            case 5:
                new ChooseLanguageScreen(currentLanguage);
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:
                new HomeScreen(currentLanguage);
                break;
        }

    }


}
