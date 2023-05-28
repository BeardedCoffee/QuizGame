namespace QuizGame;

public class QuestionSelector
{
    private ILanguage currentLanguage;

    public QuestionSelector(ILanguage language)
    {
        currentLanguage = language;
    }

    public List<Question> GetQuestions(int difficultyLevel)
    {
        List<Question> allQuestions = new List<Question>();
        List<Question> selectedQuestions = new List<Question>();

        if (currentLanguage is German)
        {
            GermanQuestionInitializer initializer = new GermanQuestionInitializer();
            allQuestions = initializer.Initialize();
        }
        else if (currentLanguage is English)
        {
            EnglishQuestionInitializer initializer = new EnglishQuestionInitializer();
            allQuestions = initializer.Initialize();
        }

        foreach (Question question in allQuestions)
        {
            if (question.DifficultyLevel == difficultyLevel)
            {
                selectedQuestions.Add(question);
            }
        }

        return selectedQuestions;
    }

}