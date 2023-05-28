namespace QuizGame;

public class Player
{
    public string Name { get; set; }
    public string Password { get; set; }
    public int AnsweredQuestions { get; set; }
    public int CorrectAnswers { get; set; }
    public int WrongAnswers { get; set; }
    public int MultiplayerWins { get; set; }
}