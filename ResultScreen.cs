namespace QuizGame;

public abstract class ResultScreen
    {
        protected Player player;
        protected int correctAnswers;
        protected int wrongAnswers;
        protected int totalAnswers;
        protected ILanguage currentLanguage;

        public ResultScreen(Player player, int correctAnswers, int wrongAnswers, int totalAnswers, ILanguage language)
        {
            this.player = player;
            this.correctAnswers = correctAnswers;
            this.wrongAnswers = wrongAnswers;
            this.totalAnswers = totalAnswers;
            currentLanguage = language;
        }

        public abstract void DisplayResults();
    }