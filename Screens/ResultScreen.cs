namespace QuizGame;

public abstract class ResultScreen
{
    protected List<Player> players;
    protected List<int> correctAnswers;
    protected List<int> wrongAnswers;
    protected List<int> totalAnswers;
    protected ILanguage currentLanguage;

    public ResultScreen(Player player, int correctAnswers, int wrongAnswers, int totalAnswers, ILanguage language)
    {
        this.players[0] = player;
        this.correctAnswers[0] = correctAnswers;
        this.wrongAnswers[0] = wrongAnswers;
        this.totalAnswers[0] = totalAnswers;
        currentLanguage = language;
    }

    public ResultScreen(List<Player> players, List<int> correctAnswers, List<int> wrongAnswers, List<int> totalAnswers, ILanguage language)
    {
        this.players = players;
        this.correctAnswers = correctAnswers;
        this.wrongAnswers = wrongAnswers;
        this.totalAnswers = totalAnswers;
        currentLanguage = language;
    }
    public abstract void DisplayResults();
}