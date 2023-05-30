namespace QuizGame;

public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public int DifficultyLevel { get; set; }
    }