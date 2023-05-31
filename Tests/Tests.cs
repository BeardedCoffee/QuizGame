using Xunit;
using QuizGame;

namespace QuizGame.Tests
{
    public class Tests
    {
        [Fact]
        public void TestEnglishQuestionInitializer()
        {
            // Arrange
            QuestionInitializer initializer = new EnglishQuestionInitializer();


            // Act
            List<Question> actualQuestions = initializer.Initialize();

            // Assert
            Assert.NotEmpty(actualQuestions);
        }

        [Fact]
        public void TestGermanQuestionInitializer()
        {
            // Arrange
            QuestionInitializer initializer = new GermanQuestionInitializer();


            // Act
            List<Question> actualQuestions = initializer.Initialize();

            // Assert
            Assert.NotEmpty(actualQuestions);
        }

        [Fact]
        public void TestAddPlayer()
        {
            // Arrange
            string playerName = "Test";
            string password = "password";
            string expectedPlayerData = "Test,password,0,0,0,0";
            string[] backup = File.ReadAllLines("Data/players.csv");

            // Act
            AddPlayerScreen.AddPlayer(new Player { Name = playerName, Password = password });

            // Assert
            string[] lines = File.ReadAllLines("Data/players.csv");
            string lastLine = lines[lines.Length - 1];
            Assert.Equal(expectedPlayerData, lastLine);

            lines = backup;

            File.WriteAllLines("Data/players.csv", lines);
        }

        [Fact]
        public void TestLoadPlayers()
        {
            // Arrange
            PlayerLoader playerLoader = new PlayerLoader();
            string filePath = "testPlayersFile.csv";

            string testData = "John,Doe,10,8,2,3\nJane,Smith,15,12,3,7";
            File.WriteAllText(filePath, testData);

            // Act
            List<Player> players = playerLoader.LoadPlayers();

            // Assert
            Assert.NotNull(players);
            Assert.Equal(2, players.Count);

            Player player1 = players[0];
            Assert.Equal("John", player1.Name);
            Assert.Equal("Doe", player1.Password);
            Assert.Equal(10, player1.AnsweredQuestions);
            Assert.Equal(8, player1.CorrectAnswers);
            Assert.Equal(2, player1.WrongAnswers);
            Assert.Equal(3, player1.MultiplayerWins);

            Player player2 = players[1];
            Assert.Equal("Jane", player2.Name);
            Assert.Equal("Smith", player2.Password);
            Assert.Equal(15, player2.AnsweredQuestions);
            Assert.Equal(12, player2.CorrectAnswers);
            Assert.Equal(3, player2.WrongAnswers);
            Assert.Equal(7, player2.MultiplayerWins);

            File.WriteAllText(filePath, string.Empty);
        }

        [Fact]
        public void TestGetQuestions()
        {
            // Arrange
            ILanguage language = new German();
            QuestionSelector questionSelector = new QuestionSelector(language);
            int difficultyLevel = 1;

            // Act
            List<Question> result = questionSelector.GetQuestions(difficultyLevel);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TestGetSelectedLanguage_Valid()
        {
            // Arrange
            int selectedOption = 0;
            ILanguage expectedLanguage = new German();

            // Act
            ILanguage selectedLanguage = ChooseLanguageScreen.GetSelectedLanguage(selectedOption);

            // Assert
            Assert.NotNull(selectedLanguage);
            Assert.IsType<German>(selectedLanguage);
            Assert.Equal(expectedLanguage.GetType(), selectedLanguage.GetType());
        }

        [Fact]
        public void TestGetSelectedLanguage_Invalid()
        {
            // Arrange
            int selectedOption = 999;

            // Act
            ILanguage selectedLanguage = ChooseLanguageScreen.GetSelectedLanguage(selectedOption);

            // Assert
            Assert.Null(selectedLanguage);
        }

        [Fact]
        public void TestGetAllQuestionsAndSelect()
        {
            // Arrange
            var game = new Game(null, 1, 0, new German());

            // Act
            List<Question> questions = game.GetAllQuestionsAndSelect();

            // Assert
            Assert.NotNull(questions);
            Assert.NotEmpty(questions);
        }

        [Fact]
        public void TestShuffle()
        {
            // Arrange
            var game = new Game(null, 1, 0, new German());
            List<Question> questions = new FakeQuestionList();

            // Act
            List<Question> shuffledQuestions = game.Shuffle(questions);

            // Assert
            Assert.Equal(questions.Count, shuffledQuestions.Count);
            Assert.NotEqual(questions[0], shuffledQuestions[0]);
            Assert.NotEqual(questions[1], shuffledQuestions[1]);
            Assert.NotEqual(questions[2], shuffledQuestions[2]);
        }

        [Fact]
        public void TestSaveResults()
        {
            // Arrange
            ResultSaver resultSaver = new ResultSaver();
            string playerName = "Test";
            int answeredQuestions = 10;
            int correctAnswers = 8;
            int wrongAnswers = 2;
            bool winner = true;
            string[] backup = File.ReadAllLines("Data/players.csv");

            // Act
            resultSaver.SaveResults(playerName, answeredQuestions, correctAnswers, wrongAnswers, winner);

            // Assert
            string[] playerLines = File.ReadAllLines("Data/players.csv");
            string targetPlayerLine = playerLines.FirstOrDefault(line => line.StartsWith(playerName + ","));

            string[] playerData = targetPlayerLine.Split(',');

            int newAnsweredQuestions = int.Parse(playerData[2]);
            int newCorrectAnswers = int.Parse(playerData[3]);
            int newWrongAnswers = int.Parse(playerData[4]);
            int newMultiplayerWins = int.Parse(playerData[5]);

            Assert.Equal(answeredQuestions, newAnsweredQuestions);
            Assert.Equal(correctAnswers, newCorrectAnswers);
            Assert.Equal(wrongAnswers, newWrongAnswers);
            Assert.Equal(winner ? 1 : 0, newMultiplayerWins);


            File.WriteAllLines("Data/players.csv", backup);
        }
    }
}
