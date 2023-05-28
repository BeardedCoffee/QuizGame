namespace QuizGame;
public class Program
{
    public static void Main(string[] args)
    {
        ILanguage startLanguage = new English();
        HomeScreen screen = new HomeScreen(startLanguage);
    }
}