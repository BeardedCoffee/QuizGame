namespace QuizGame;

public class ChooseLanguageScreen
{
    private ILanguage currentLanguage;
    private static Dictionary<ConsoleKey, ILanguage> languageOptions = new Dictionary<ConsoleKey, ILanguage>
        {
            { ConsoleKey.D, new German() },
            { ConsoleKey.E, new English() }
        };

    public ChooseLanguageScreen(ILanguage language)
    {
        currentLanguage = language;
        ChooseLanguageScreenProcessInput();
    }

    private void ChooseLanguageScreenProcessInput()
    {
        Console.WriteLine(currentLanguage.LanguageSelection);
        Console.WriteLine("------------------");
        Console.WriteLine(currentLanguage.BackWithHashtag);
        Console.WriteLine();

        int selectedOption = 0;

        do
        {
            Console.Clear();
            Console.WriteLine(currentLanguage.LanguageSelection);
            Console.WriteLine("------------------");
            Console.WriteLine(currentLanguage.BackWithHashtag);
            Console.WriteLine();

            PrintLanguageOptions(selectedOption);

            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key == ConsoleKey.UpArrow && selectedOption > 0)
            {
                selectedOption--;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow && selectedOption < languageOptions.Count - 1)
            {
                selectedOption++;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                ILanguage selectedLanguage = GetSelectedLanguage(selectedOption);
                if (selectedLanguage != null)
                {
                    Console.Clear();
                    UpdateLanguage(selectedLanguage);
                    Console.WriteLine();
                    Console.WriteLine(currentLanguage.PressButtonToContinue);
                    Console.ReadKey();
                    new HomeScreen(currentLanguage);
                    return;
                }
            }
            else if (keyInfo.KeyChar == '#')
            {
                new HomeScreen(currentLanguage);
                return;
            }
            else
            {
                Console.WriteLine(currentLanguage.InvalidLanguage);
            }
        } while (true);
    }

    private static void PrintLanguageOptions(int selectedOption)
    {
        int index = 0;
        foreach (var option in languageOptions)
        {
            if (index == selectedOption)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-> " + option.Value.GetType().Name);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("   " + option.Value.GetType().Name);
            }
            index++;
        }
    }

    public static ILanguage GetSelectedLanguage(int selectedOption)
    {
        int index = 0;
        foreach (var option in languageOptions)
        {
            if (index == selectedOption)
            {
                return option.Value;
            }
            index++;
        }
        return null;
    }

    private void UpdateLanguage(ILanguage language)
    {
        currentLanguage = language;
    }
}