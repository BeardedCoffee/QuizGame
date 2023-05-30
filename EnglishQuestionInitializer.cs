namespace QuizGame;

public class EnglishQuestionInitializer : QuestionInitializer
{
    public EnglishQuestionInitializer()
    {

    }

    public override List<Question> Initialize()
    {
        List<Question> questions = new List<Question>();

        Question question1 = new Question
        {
            QuestionText = "What is the capital of France?",
            Answers = new List<string> { "Berlin", "Paris", "London", "Rome" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question1);

        Question question2 = new Question
        {
            QuestionText = "What color is a ripe banana?",
            Answers = new List<string> { "Yellow", "Green", "Red", "Brown" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question2);

        Question question3 = new Question
        {
            QuestionText = "Who wrote the book 'Harry Potter and the Philosopher's Stone'?",
            Answers = new List<string> { "J.K. Rowling", "Stephenie Meyer", "George R.R. Martin", "C.S. Lewis" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question3);

        Question question4 = new Question
        {
            QuestionText = "How many planets are there in our solar system?",
            Answers = new List<string> { "7", "8", "9", "10" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question4);

        Question question5 = new Question
        {
            QuestionText = "Which planet is the largest in our solar system?",
            Answers = new List<string> { "Mars", "Venus", "Jupiter", "Saturn" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question5);

        Question question6 = new Question
        {
            QuestionText = "What language is spoken in Brazil?",
            Answers = new List<string> { "Spanish", "English", "Portuguese", "French" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question6);

        Question question7 = new Question
        {
            QuestionText = "Who invented the light bulb?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Benjamin Franklin" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question7);

        Question question8 = new Question
        {
            QuestionText = "How many legs does a spider have?",
            Answers = new List<string> { "4", "6", "8", "10" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question8);

        Question question9 = new Question
        {
            QuestionText = "What is the capital of Germany?",
            Answers = new List<string> { "Berlin", "Munich", "Hamburg", "Cologne" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question9);

        Question question10 = new Question
        {
            QuestionText = "Who discovered gravity?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Stephen Hawking" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question10);

        Question question11 = new Question
        {
            QuestionText = "How many seconds are in a minute?",
            Answers = new List<string> { "30", "60", "90", "120" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question11);

        Question question12 = new Question
        {
            QuestionText = "Which instrument has keys and pedals?",
            Answers = new List<string> { "Guitar", "Piano", "Violin", "Trumpet" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question12);

        Question question13 = new Question
        {
            QuestionText = "What is the capital of Italy?",
            Answers = new List<string> { "Rome", "Milan", "Venice", "Florence" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question13);

        Question question14 = new Question
        {
            QuestionText = "How many players are on the field in a soccer team?",
            Answers = new List<string> { "8", "9", "10", "11" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question14);

        Question question15 = new Question
        {
            QuestionText = "Who developed the theory of relativity?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question15);

        Question question16 = new Question
        {
            QuestionText = "How many continents are there on Earth?",
            Answers = new List<string> { "3", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question16);

        Question question17 = new Question
        {
            QuestionText = "How many days are there in a year?",
            Answers = new List<string> { "365", "366", "364", "360" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question17);

        Question question18 = new Question
        {
            QuestionText = "Who painted the Mona Lisa?",
            Answers = new List<string> { "Pablo Picasso", "Leonardo da Vinci", "Vincent van Gogh", "Michelangelo" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question18);

        Question question19 = new Question
        {
            QuestionText = "What is the capital of Spain?",
            Answers = new List<string> { "Barcelona", "Madrid", "Valencia", "Seville" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question19);

        Question question20 = new Question
        {
            QuestionText = "What is the capital of Canada?",
            Answers = new List<string> { "Toronto", "Vancouver", "Montreal", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question20);

        Question question21 = new Question
        {
            QuestionText = "What is the chemical formula for water?",
            Answers = new List<string> { "CO2", "H2O", "NaCl", "C6H12O6" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question21);

        Question question22 = new Question
        {
            QuestionText = "Who wrote the book 'The Odyssey'?",
            Answers = new List<string> { "Homer", "William Shakespeare", "Mark Twain", "Friedrich Nietzsche" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question22);

        Question question23 = new Question
        {
            QuestionText = "How many teeth does an adult human usually have?",
            Answers = new List<string> { "28", "30", "32", "36" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question23);

        Question question24 = new Question
        {
            QuestionText = "What is the capital of Australia?",
            Answers = new List<string> { "Sydney", "Melbourne", "Canberra", "Brisbane" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question24);

        Question question25 = new Question
        {
            QuestionText = "What color is an emerald?",
            Answers = new List<string> { "Red", "Green", "Blue", "Yellow" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question25);

        Question question26 = new Question
        {
            QuestionText = "Who designed the first US flag?",
            Answers = new List<string> { "George Washington", "Thomas Jefferson", "Benjamin Franklin", "Betsy Ross" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question26);

        Question question27 = new Question
        {
            QuestionText = "Which continent is the largest?",
            Answers = new List<string> { "Asia", "Africa", "North America", "South America" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question27);

        Question question28 = new Question
        {
            QuestionText = "Which country has the most population?",
            Answers = new List<string> { "China", "India", "United States", "Russia" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question28);

        Question question29 = new Question
        {
            QuestionText = "Who painted the artwork 'The Last Supper'?",
            Answers = new List<string> { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question29);

        Question question30 = new Question
        {
            QuestionText = "How many kilometers are in a mile?",
            Answers = new List<string> { "1.6", "2.2", "3.5", "5.0" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question30);

        Question question31 = new Question
        {
            QuestionText = "Who invented the phonograph record?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Emile Berliner" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question31);

        Question question32 = new Question
        {
            QuestionText = "What is the capital of China?",
            Answers = new List<string> { "Beijing", "Shanghai", "Hong Kong", "Guangzhou" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question32);

        Question question33 = new Question
        {
            QuestionText = "How many eyes does a bee have?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question33);

        Question question34 = new Question
        {
            QuestionText = "Who invented the hieroglyphic script?",
            Answers = new List<string> { "Egyptians", "Greeks", "Romans", "Persians" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question34);

        Question question35 = new Question
        {
            QuestionText = "What is the capital of South Korea?",
            Answers = new List<string> { "Seoul", "Busan", "Incheon", "Daegu" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question35);

        Question question36 = new Question
        {
            QuestionText = "How many letters are there in the German alphabet?",
            Answers = new List<string> { "25", "26", "27", "28" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question36);

        Question question37 = new Question
        {
            QuestionText = "Which ocean is located between Europe and North America?",
            Answers = new List<string> { "Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question37);

        Question question38 = new Question
        {
            QuestionText = "Who invented the first successful steam locomotive?",
            Answers = new List<string> { "George Stephenson", "James Watt", "Robert Fulton", "Thomas Edison" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question38);

        Question question39 = new Question
        {
            QuestionText = "What is the capital of Canada?",
            Answers = new List<string> { "Toronto", "Vancouver", "Montreal", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question39);

        Question question40 = new Question
        {
            QuestionText = "Which river flows through Paris?",
            Answers = new List<string> { "Rhine", "Thames", "Seine", "Danube" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question40);

        Question question41 = new Question
        {
            QuestionText = "How many players are on the field in a baseball team?",
            Answers = new List<string> { "8", "9", "10", "11" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question41);

        Question question42 = new Question
        {
            QuestionText = "Which continent has the most countries?",
            Answers = new List<string> { "Asia", "Africa", "Europe", "South America" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question42);

        Question question43 = new Question
        {
            QuestionText = "How many states are there in the USA?",
            Answers = new List<string> { "45", "48", "50", "52" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question43);

        Question question44 = new Question
        {
            QuestionText = "Who wrote the book 'The Little Prince'?",
            Answers = new List<string> { "Antoine de Saint-Exupéry", "Victor Hugo", "Marcel Proust", "Émile Zola" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question44);

        Question question45 = new Question
        {
            QuestionText = "How many prime numbers are there between 1 and 10?",
            Answers = new List<string> { "2", "3", "4", "5" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question45);

        Question question46 = new Question
        {
            QuestionText = "Which country has the longest coastline?",
            Answers = new List<string> { "Canada", "Russia", "Indonesia", "Australia" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question46);

        Question question47 = new Question
        {
            QuestionText = "Who wrote the novel '1984'?",
            Answers = new List<string> { "George Orwell", "Ernest Hemingway", "F. Scott Fitzgerald", "Aldous Huxley" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question47);

        Question question48 = new Question
        {
            QuestionText = "What is the capital of Russia?",
            Answers = new List<string> { "Moscow", "Saint Petersburg", "Kazan", "Yekaterinburg" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question48);

        Question question49 = new Question
        {
            QuestionText = "How many years are in a decade?",
            Answers = new List<string> { "5", "10", "20", "100" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question49);

        Question question50 = new Question
        {
            QuestionText = "Who invented the television?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Philo Farnsworth" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question50);

        Question question51 = new Question
        {
            QuestionText = "What is the capital of France?",
            Answers = new List<string> { "Paris", "Marseille", "Lyon", "Toulouse" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question51);

        Question question52 = new Question
        {
            QuestionText = "How many milliliters are in a liter?",
            Answers = new List<string> { "100", "250", "500", "1000" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question52);

        Question question53 = new Question
        {
            QuestionText = "Which planet is the second largest in our solar system?",
            Answers = new List<string> { "Mars", "Venus", "Jupiter", "Saturn" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question53);

        Question question54 = new Question
        {
            QuestionText = "Who was the first person to successfully perform a manned spaceflight?",
            Answers = new List<string> { "Yuri Gagarin", "Neil Armstrong", "Buzz Aldrin", "Alan Shepard" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question54);

        Question question55 = new Question
        {
            QuestionText = "How many colors are in a rainbow?",
            Answers = new List<string> { "4", "6", "7", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question55);

        Question question56 = new Question
        {
            QuestionText = "What is the capital of South Africa?",
            Answers = new List<string> { "Johannesburg", "Cape Town", "Pretoria", "Durban" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question56);

        Question question57 = new Question
        {
            QuestionText = "Which is the largest planet in our solar system?",
            Answers = new List<string> { "Mars", "Jupiter", "Saturn", "Neptune" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question57);

        Question question58 = new Question
        {
            QuestionText = "Who composed Symphony No. 9?",
            Answers = new List<string> { "Ludwig van Beethoven", "Johann Sebastian Bach", "Wolfgang Amadeus Mozart", "Johannes Brahms" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question58);

        Question question59 = new Question
        {
            QuestionText = "What is the capital of Argentina?",
            Answers = new List<string> { "Buenos Aires", "Córdoba", "Rosario", "Mendoza" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question59);

        Question question60 = new Question
        {
            QuestionText = "How many legs does a spider have?",
            Answers = new List<string> { "4", "6", "8", "10" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question60);

        Question question61 = new Question
        {
            QuestionText = "What is the color of a ripe banana?",
            Answers = new List<string> { "Green", "Yellow", "Red", "Blue" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question61);

        Question question62 = new Question
        {
            QuestionText = "What is the capital of Egypt?",
            Answers = new List<string> { "Cairo", "Alexandria", "Luxor", "Giza" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question62);

        Question question63 = new Question
        {
            QuestionText = "How many seconds are there in a minute?",
            Answers = new List<string> { "30", "45", "60", "90" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question63);

        Question question64 = new Question
        {
            QuestionText = "Who painted the artwork 'The Scream'?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Edvard Munch", "Salvador Dalí" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question64);

        Question question65 = new Question
        {
            QuestionText = "How many countries are there in the European Union?",
            Answers = new List<string> { "15", "20", "25", "28" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question65);

        Question question66 = new Question
        {
            QuestionText = "Who wrote the book 'The Metamorphosis'?",
            Answers = new List<string> { "Franz Kafka", "Hermann Hesse", "Thomas Mann", "Friedrich Nietzsche" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question66);

        Question question67 = new Question
        {
            QuestionText = "How many continents are there on Earth?",
            Answers = new List<string> { "4", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question67);

        Question question68 = new Question
        {
            QuestionText = "What is the capital of Spain?",
            Answers = new List<string> { "Barcelona", "Madrid", "Valencia", "Seville" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question68);

        Question question69 = new Question
        {
            QuestionText = "How many planets are there in our solar system?",
            Answers = new List<string> { "6", "7", "8", "9" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question69);

        Question question70 = new Question
        {
            QuestionText = "Who wrote the novel 'The Lord of the Rings'?",
            Answers = new List<string> { "J.R.R. Tolkien", "C.S. Lewis", "George R.R. Martin", "J.K. Rowling" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question70);

        Question question71 = new Question
        {
            QuestionText = "What is the capital of Italy?",
            Answers = new List<string> { "Rome", "Milan", "Naples", "Turin" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question71);

        Question question72 = new Question
        {
            QuestionText = "How many players are on the court in a volleyball team?",
            Answers = new List<string> { "4", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question72);

        Question question73 = new Question
        {
            QuestionText = "Which country has the longest wall in the world?",
            Answers = new List<string> { "China", "Germany", "USA", "Russia" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question73);

        Question question74 = new Question
        {
            QuestionText = "Who developed the theory of relativity?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Max Planck" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question74);

        Question question75 = new Question
        {
            QuestionText = "How many seconds are there in an hour?",
            Answers = new List<string> { "30", "45", "60", "90" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question75);

        Question question76 = new Question
        {
            QuestionText = "What is the capital of Brazil?",
            Answers = new List<string> { "Rio de Janeiro", "São Paulo", "Brasília", "Salvador" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question76);

        Question question77 = new Question
        {
            QuestionText = "How many teeth does an adult human usually have?",
            Answers = new List<string> { "20", "24", "28", "32" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question77);

        Question question78 = new Question
        {
            QuestionText = "Who painted the Mona Lisa?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Claude Monet" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question78);

        Question question79 = new Question
        {
            QuestionText = "What is the capital of Australia?",
            Answers = new List<string> { "Sydney", "Melbourne", "Brisbane", "Canberra" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question79);

        Question question80 = new Question
        {
            QuestionText = "How many legs does an insect have?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question80);

        Question question81 = new Question
        {
            QuestionText = "Who wrote the book 'Harry Potter and the Philosopher's Stone'?",
            Answers = new List<string> { "J.R.R. Tolkien", "C.S. Lewis", "George R.R. Martin", "J.K. Rowling" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question81);

        Question question82 = new Question
        {
            QuestionText = "What is the capital of China?",
            Answers = new List<string> { "Beijing", "Shanghai", "Hong Kong", "Guangzhou" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question82);

        Question question83 = new Question
        {
            QuestionText = "How many provinces does Canada have?",
            Answers = new List<string> { "5", "8", "10", "13" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question83);

        Question question84 = new Question
        {
            QuestionText = "Who stole the Mona Lisa?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Salvador Dalí", "Vincenzo Peruggia" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question84);

        Question question85 = new Question
        {
            QuestionText = "What is the capital of the United Kingdom?",
            Answers = new List<string> { "London", "Manchester", "Liverpool", "Birmingham" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question85);

        Question question86 = new Question
        {
            QuestionText = "How many grams are there in a kilogram?",
            Answers = new List<string> { "100", "250", "500", "1000" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question86);

        Question question87 = new Question
        {
            QuestionText = "Which country has the largest area?",
            Answers = new List<string> { "Russia", "Canada", "China", "USA" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question87);

        Question question88 = new Question
        {
            QuestionText = "Who painted the painting 'The Night'?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Edvard Munch", "Rembrandt" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question88);

        Question question89 = new Question
        {
            QuestionText = "What is the capital of Canada?",
            Answers = new List<string> { "Toronto", "Montreal", "Vancouver", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question89);

        Question question90 = new Question
        {
            QuestionText = "How many time zones are there in the world?",
            Answers = new List<string> { "12", "20", "24", "30" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question90);

        Question question91 = new Question
        {
            QuestionText = "Who wrote the novel 'The Catcher in the Rye'?",
            Answers = new List<string> { "George Orwell", "Ernest Hemingway", "J.D. Salinger", "F. Scott Fitzgerald" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question91);

        Question question92 = new Question
        {
            QuestionText = "What is the capital of Canada?",
            Answers = new List<string> { "Toronto", "Montreal", "Vancouver", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question92);

        Question question93 = new Question
        {
            QuestionText = "How many states are there in the USA?",
            Answers = new List<string> { "45", "48", "50", "52" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question93);

        Question question94 = new Question
        {
            QuestionText = "Who wrote the book 'The Little Prince'?",
            Answers = new List<string> { "Antoine de Saint-Exupéry", "Victor Hugo", "Gustave Flaubert", "Émile Zola" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question94);

        Question question95 = new Question
        {
            QuestionText = "How many eyes does a bee have?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question95);

        Question question96 = new Question
        {
            QuestionText = "What is the capital of Sweden?",
            Answers = new List<string> { "Stockholm", "Gothenburg", "Malmo", "Uppsala" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question96);

        Question question97 = new Question
        {
            QuestionText = "How many kilometers are there in a mile?",
            Answers = new List<string> { "1", "1.6", "2", "2.5" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question97);

        Question question98 = new Question
        {
            QuestionText = "Who painted the painting 'Sunflowers'?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Claude Monet", "Salvador Dalí" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question98);

        return questions;
    }

}