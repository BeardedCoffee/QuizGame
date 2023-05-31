namespace QuizGame.Tests;

public class FakeQuestionList : List<Question>
{
    public FakeQuestionList()
    {
        Add(new Question { QuestionText = "Question 1" });
        Add(new Question { QuestionText = "Question 2" });
        Add(new Question { QuestionText = "Question 3" });
    }
}