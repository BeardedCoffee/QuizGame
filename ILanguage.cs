namespace QuizGame;

public interface ILanguage
{
    string NewGame { get; }
    string AddPlayer { get; }
    string ShowStatistics { get; }
    string ShowHighscores { get; }
    string ChooseLanguage { get; }

    string GameConfiguration { get; }
    string SelectPlayers { get; }
    string ChooseDifficulty { get; }
    string ToggleTimeLimit { get; }
    string StartGame { get; }
    string PlayerSelection { get; }
    string SelectedPlayers { get; }
    string Max4Players { get; }
    string Min1Player { get; }
    string EnterUserPassword { get; }
    string InvalidPassword { get; }

    string TypeNameOfPlayer { get; }
    string InvalidName { get; }
    string NameNotAvailable { get; }
    string NameAvailable { get; }
    string EnterPassword { get; }
    string AddedPlayerSuccessfully { get; }

    string ChoosePlayer { get; }
    string PlayerStats { get; }
    string PlayerName { get; }
    string AnsweredQuestions { get; }
    string CorrectAnswers { get; }
    string WrongAnswers { get; }
    string MultiplayerWins { get; }

    string Highscores { get; }
    string ChooseCategory { get; }
    string ChooseMostQuestionsAnswered { get; }
    string ChooseMostCorrectAnswers { get; }
    string ChooseMostMultiplayerWins { get; }
    string HighscoreMostQuestions { get; }
    string HighscoreMostCorrectAnswers { get; }
    string HighscoreMostWins { get; }
    string MostQuestionsAnswered { get; }
    string MostCorrectAnswers { get; }
    string MostMultiplayerWins { get; }

    string LanguageSelection { get; }
    string InvalidLanguage { get; }
    string LanguageUpdatedTo { get; }

    string PressButtonToContinue { get; }
    string CanceledByUser { get; }
    string NoPlayersExisting { get; }
    string BackWithHashtag { get; }
    string Exit { get; }

    string Player { get; }

}