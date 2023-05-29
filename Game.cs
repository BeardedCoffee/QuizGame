namespace QuizGame;

public class Game
{
    private List<Player> players;
    private int difficultyLevel;
    private int timeLimit;
    private ILanguage currentLanguage;
    private List<Question> selectedQuestions;

    public Game(List<Player> playerSelection, int difficultyLevel, int timeLimit, ILanguage language)
    {
        players = playerSelection;
        this.difficultyLevel = difficultyLevel;
        this.timeLimit = timeLimit;
        currentLanguage = language;
        selectedQuestions = GetAllQuestionsAndSelect();
        selectedQuestions = Shuffle(selectedQuestions);
        StartGame();
    }

    public void StartGame()
    {
        Console.Clear();
        if (players.Count == 1)
        {
            new SinglePlayerGameScreen(players[0], selectedQuestions, difficultyLevel, currentLanguage);
        }
        else
        {
            new MultiplayerGameScreen(players, selectedQuestions, difficultyLevel, currentLanguage);
        }
    }

    private List<Question> GetAllQuestionsAndSelect()
    {
        QuestionSelector questionSelector = new QuestionSelector(currentLanguage);
        selectedQuestions = questionSelector.GetQuestions(difficultyLevel);

        return selectedQuestions;
    }

    private List<Question> Shuffle(List<Question> questions)
    {
        Random random = new Random();

        int n = questions.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Question value = questions[k];
            questions[k] = questions[n];
            questions[n] = value;
        }

        return questions;
    }
}