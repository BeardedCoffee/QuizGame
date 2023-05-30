namespace QuizGame;

public class GermanQuestionInitializer : QuestionInitializer
{
    public GermanQuestionInitializer()
    {

    }

    public override List<Question> Initialize()
    {
        List<Question> questions = new List<Question>();

        Question question1 = new Question
        {
            QuestionText = "Wie lautet die Hauptstadt von Frankreich?",
            Answers = new List<string> { "Berlin", "Paris", "London", "Rom" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question1);

        Question question2 = new Question
        {
            QuestionText = "Welche Farbe hat eine reife Banane?",
            Answers = new List<string> { "Gelb", "Grün", "Rot", "Braun" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question2);

        Question question3 = new Question
        {
            QuestionText = "Wer schrieb das Buch 'Harry Potter und der Stein der Weisen'?",
            Answers = new List<string> { "J.K. Rowling", "Stephenie Meyer", "George R.R. Martin", "C.S. Lewis" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question3);

        Question question4 = new Question
        {
            QuestionText = "Wie viele Planeten hat unser Sonnensystem?",
            Answers = new List<string> { "7", "8", "9", "10" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question4);

        Question question5 = new Question
        {
            QuestionText = "Welcher Planet ist der größte in unserem Sonnensystem?",
            Answers = new List<string> { "Mars", "Venus", "Jupiter", "Saturn" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question5);

        Question question6 = new Question
        {
            QuestionText = "Welche Sprache spricht man in Brasilien?",
            Answers = new List<string> { "Spanisch", "Englisch", "Portugiesisch", "Französisch" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question6);

        Question question7 = new Question
        {
            QuestionText = "Wer hat die erste Glühbirne erfunden?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Benjamin Franklin" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question7);

        Question question8 = new Question
        {
            QuestionText = "Wie viele Beine hat eine Spinne?",
            Answers = new List<string> { "4", "6", "8", "10" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question8);

        Question question9 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Deutschland?",
            Answers = new List<string> { "Berlin", "München", "Hamburg", "Köln" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question9);

        Question question10 = new Question
        {
            QuestionText = "Wer hat die Schwerkraft entdeckt?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Stephen Hawking" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question10);

        Question question11 = new Question
        {
            QuestionText = "Wie viele Sekunden hat eine Minute?",
            Answers = new List<string> { "30", "60", "90", "120" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question11);

        Question question12 = new Question
        {
            QuestionText = "Welches Instrument hat Tasten und Pedale?",
            Answers = new List<string> { "Gitarre", "Klavier", "Geige", "Trompete" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question12);

        Question question13 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Italien?",
            Answers = new List<string> { "Rom", "Mailand", "Venedig", "Florenz" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question13);

        Question question14 = new Question
        {
            QuestionText = "Wie viele Spieler sind in einer Fußballmannschaft auf dem Spielfeld?",
            Answers = new List<string> { "8", "9", "10", "11" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question14);

        Question question15 = new Question
        {
            QuestionText = "Wer hat die Relativitätstheorie entwickelt?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question15);

        Question question16 = new Question
        {
            QuestionText = "Wie viele Kontinente gibt es auf der Erde?",
            Answers = new List<string> { "3", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question16);

        Question question17 = new Question
        {
            QuestionText = "Wie viele Tage hat ein Jahr?",
            Answers = new List<string> { "365", "366", "364", "360" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question17);

        Question question18 = new Question
        {
            QuestionText = "Wer hat die Mona Lisa gemalt?",
            Answers = new List<string> { "Pablo Picasso", "Leonardo da Vinci", "Vincent van Gogh", "Michelangelo" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question18);

        Question question19 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Spanien?",
            Answers = new List<string> { "Barcelona", "Madrid", "Valencia", "Sevilla" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question19);

        Question question20 = new Question
        {
            QuestionText = "Wie lautet die Hauptstadt von Kanada?",
            Answers = new List<string> { "Toronto", "Vancouver", "Montreal", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question20);

        Question question21 = new Question
        {
            QuestionText = "Was ist die chemische Formel für Wasser?",
            Answers = new List<string> { "CO2", "H2O", "NaCl", "C6H12O6" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question21);

        Question question22 = new Question
        {
            QuestionText = "Wer hat das Buch 'Die Odyssee' geschrieben?",
            Answers = new List<string> { "Homer", "William Shakespeare", "Mark Twain", "Friedrich Nietzsche" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question22);

        Question question23 = new Question
        {
            QuestionText = "Wie viele Zähne hat ein erwachsener Mensch normalerweise?",
            Answers = new List<string> { "28", "30", "32", "36" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question23);

        Question question24 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Australien?",
            Answers = new List<string> { "Sydney", "Melbourne", "Canberra", "Brisbane" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question24);

        Question question25 = new Question
        {
            QuestionText = "Welche Farbe hat ein Smaragd?",
            Answers = new List<string> { "Rot", "Grün", "Blau", "Gelb" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question25);

        Question question26 = new Question
        {
            QuestionText = "Wer hat die erste US-amerikanische Flagge entworfen?",
            Answers = new List<string> { "George Washington", "Thomas Jefferson", "Benjamin Franklin", "Betsy Ross" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question26);

        Question question27 = new Question
        {
            QuestionText = "Welcher Kontinent ist der größte?",
            Answers = new List<string> { "Asien", "Afrika", "Nordamerika", "Südamerika" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question27);

        Question question28 = new Question
        {
            QuestionText = "Welches Land hat die meisten Einwohner?",
            Answers = new List<string> { "China", "Indien", "Vereinigte Staaten", "Russland" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question28);

        Question question29 = new Question
        {
            QuestionText = "Wer hat das Gemälde 'Die letzte Abendmahl' gemalt?",
            Answers = new List<string> { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question29);

        Question question30 = new Question
        {
            QuestionText = "Wie viele Kilometer sind in einer Meile?",
            Answers = new List<string> { "1.6", "2.2", "3.5", "5.0" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question30);

        Question question31 = new Question
        {
            QuestionText = "Wer hat die Schallplatte erfunden?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Emile Berliner" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question31);

        Question question32 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von China?",
            Answers = new List<string> { "Peking", "Shanghai", "Hongkong", "Guangzhou" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question32);

        Question question33 = new Question
        {
            QuestionText = "Wie viele Augen hat eine Biene?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question33);

        Question question34 = new Question
        {
            QuestionText = "Wer hat die Schriftsprache hieroglyphen erfunden?",
            Answers = new List<string> { "Ägypter", "Griechen", "Römer", "Perser" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question34);

        Question question35 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Südkorea?",
            Answers = new List<string> { "Seoul", "Busan", "Incheon", "Daegu" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question35);

        Question question36 = new Question
        {
            QuestionText = "Wie viele Buchstaben hat das deutsche Alphabet?",
            Answers = new List<string> { "25", "26", "27", "28" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question36);

        Question question37 = new Question
        {
            QuestionText = "Welcher Ozean liegt zwischen Europa und Nordamerika?",
            Answers = new List<string> { "Atlantischer Ozean", "Pazifischer Ozean", "Indischer Ozean", "Arktischer Ozean" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question37);

        Question question38 = new Question
        {
            QuestionText = "Wer hat die erste erfolgreiche Dampflokomotive erfunden?",
            Answers = new List<string> { "George Stephenson", "James Watt", "Robert Fulton", "Thomas Edison" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question38);

        Question question39 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Kanada?",
            Answers = new List<string> { "Toronto", "Vancouver", "Montreal", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question39);

        Question question40 = new Question
        {
            QuestionText = "Welcher Fluss fließt durch Paris?",
            Answers = new List<string> { "Rhein", "Themse", "Seine", "Donau" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question40);

        Question question41 = new Question
        {
            QuestionText = "Wie viele Spieler sind in einer Baseballmannschaft auf dem Spielfeld?",
            Answers = new List<string> { "8", "9", "10", "11" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question41);

        Question question42 = new Question
        {
            QuestionText = "Welcher Kontinent hat die meisten Länder?",
            Answers = new List<string> { "Asien", "Afrika", "Europa", "Südamerika" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question42);

        Question question43 = new Question
        {
            QuestionText = "Wie viele Bundesstaaten hat die USA?",
            Answers = new List<string> { "45", "48", "50", "52" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question43);

        Question question44 = new Question
        {
            QuestionText = "Wer hat das Buch 'Der kleine Prinz' geschrieben?",
            Answers = new List<string> { "Antoine de Saint-Exupéry", "Victor Hugo", "Marcel Proust", "Émile Zola" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question44);

        Question question45 = new Question
        {
            QuestionText = "Wie viele Primzahlen gibt es zwischen 1 und 10?",
            Answers = new List<string> { "2", "3", "4", "5" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question45);

        Question question46 = new Question
        {
            QuestionText = "Welches Land hat die längste Küstenlinie?",
            Answers = new List<string> { "Kanada", "Russland", "Indonesien", "Australien" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question46);

        Question question47 = new Question
        {
            QuestionText = "Wer hat den Roman '1984' geschrieben?",
            Answers = new List<string> { "George Orwell", "Ernest Hemingway", "F. Scott Fitzgerald", "Aldous Huxley" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question47);

        Question question48 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Russland?",
            Answers = new List<string> { "Moskau", "Sankt Petersburg", "Kasan", "Jekaterinburg" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question48);

        Question question49 = new Question
        {
            QuestionText = "Wie viele Jahre sind in einem Jahrzehnt?",
            Answers = new List<string> { "5", "10", "20", "100" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question49);

        Question question50 = new Question
        {
            QuestionText = "Wer hat den Fernseher erfunden?",
            Answers = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Philo Farnsworth" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question50);

        Question question51 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Frankreich?",
            Answers = new List<string> { "Paris", "Marseille", "Lyon", "Toulouse" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question51);

        Question question52 = new Question
        {
            QuestionText = "Wie viele Milliliter sind in einem Liter?",
            Answers = new List<string> { "100", "250", "500", "1000" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question52);

        Question question53 = new Question
        {
            QuestionText = "Welcher Planet ist der zweitgrößte in unserem Sonnensystem?",
            Answers = new List<string> { "Mars", "Venus", "Jupiter", "Saturn" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question53);

        Question question54 = new Question
        {
            QuestionText = "Wer hat den ersten erfolgreichen bemannten Raumflug durchgeführt?",
            Answers = new List<string> { "Yuri Gagarin", "Neil Armstrong", "Buzz Aldrin", "Alan Shepard" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question54);

        Question question55 = new Question
        {
            QuestionText = "Wie viele Farben hat ein Regenbogen?",
            Answers = new List<string> { "4", "6", "7", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question55);

        Question question56 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Südafrika?",
            Answers = new List<string> { "Johannesburg", "Kapstadt", "Pretoria", "Durban" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question56);

        Question question57 = new Question
        {
            QuestionText = "Welcher ist der größte Planet in unserem Sonnensystem?",
            Answers = new List<string> { "Mars", "Jupiter", "Saturn", "Neptun" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question57);

        Question question58 = new Question
        {
            QuestionText = "Wer hat die Symphonie Nr. 9 komponiert?",
            Answers = new List<string> { "Ludwig van Beethoven", "Johann Sebastian Bach", "Wolfgang Amadeus Mozart", "Johannes Brahms" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question58);

        Question question59 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Argentinien?",
            Answers = new List<string> { "Buenos Aires", "Córdoba", "Rosario", "Mendoza" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question59);

        Question question60 = new Question
        {
            QuestionText = "Wie viele Beine hat eine Spinne?",
            Answers = new List<string> { "4", "6", "8", "10" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question60);

        Question question61 = new Question
        {
            QuestionText = "Welche Farbe hat eine reife Banane?",
            Answers = new List<string> { "Grün", "Gelb", "Rot", "Blau" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question61);

        Question question62 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Ägypten?",
            Answers = new List<string> { "Kairo", "Alexandria", "Luxor", "Gizeh" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question62);

        Question question63 = new Question
        {
            QuestionText = "Wie viele Sekunden hat eine Minute?",
            Answers = new List<string> { "30", "45", "60", "90" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question63);

        Question question64 = new Question
        {
            QuestionText = "Wer hat das Gemälde 'Die Schrei' gemalt?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Edvard Munch", "Salvador Dalí" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question64);

        Question question65 = new Question
        {
            QuestionText = "Wie viele Länder gibt es in der Europäischen Union?",
            Answers = new List<string> { "15", "20", "25", "28" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question65);

        Question question66 = new Question
        {
            QuestionText = "Wer hat das Buch 'Die Verwandlung' geschrieben?",
            Answers = new List<string> { "Franz Kafka", "Hermann Hesse", "Thomas Mann", "Friedrich Nietzsche" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question66);

        Question question67 = new Question
        {
            QuestionText = "Wie viele Kontinente gibt es auf der Erde?",
            Answers = new List<string> { "4", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question67);

        Question question68 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Spanien?",
            Answers = new List<string> { "Barcelona", "Madrid", "Valencia", "Sevilla" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question68);

        Question question69 = new Question
        {
            QuestionText = "Wie viele Planeten gibt es in unserem Sonnensystem?",
            Answers = new List<string> { "6", "7", "8", "9" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question69);

        Question question70 = new Question
        {
            QuestionText = "Wer hat den Roman 'Der Herr der Ringe' geschrieben?",
            Answers = new List<string> { "J.R.R. Tolkien", "C.S. Lewis", "George R.R. Martin", "J.K. Rowling" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question70);

        Question question71 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Italien?",
            Answers = new List<string> { "Rom", "Mailand", "Neapel", "Turin" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question71);

        Question question72 = new Question
        {
            QuestionText = "Wie viele Spieler sind in einer Volleyballmannschaft auf dem Spielfeld?",
            Answers = new List<string> { "4", "5", "6", "7" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question72);

        Question question73 = new Question
        {
            QuestionText = "Welches Land hat die längste Mauer der Welt?",
            Answers = new List<string> { "China", "Deutschland", "USA", "Russland" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question73);

        Question question74 = new Question
        {
            QuestionText = "Wer hat die Relativitätstheorie entwickelt?",
            Answers = new List<string> { "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Max Planck" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question74);

        Question question75 = new Question
        {
            QuestionText = "Wie viele Sekunden hat eine Stunde?",
            Answers = new List<string> { "30", "45", "60", "90" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question75);

        Question question76 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Brasilien?",
            Answers = new List<string> { "Rio de Janeiro", "São Paulo", "Brasília", "Salvador" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question76);

        Question question77 = new Question
        {
            QuestionText = "Wie viele Zähne hat ein erwachsener Mensch normalerweise?",
            Answers = new List<string> { "20", "24", "28", "32" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question77);

        Question question78 = new Question
        {
            QuestionText = "Wer hat das Gemälde 'Mona Lisa' gemalt?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Claude Monet" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question78);

        Question question79 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Australien?",
            Answers = new List<string> { "Sydney", "Melbourne", "Brisbane", "Canberra" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question79);

        Question question80 = new Question
        {
            QuestionText = "Wie viele Beine hat ein Insekt?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question80);

        Question question81 = new Question
        {
            QuestionText = "Wer hat das Buch 'Harry Potter und der Stein der Weisen' geschrieben?",
            Answers = new List<string> { "J.R.R. Tolkien", "C.S. Lewis", "George R.R. Martin", "J.K. Rowling" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question81);

        Question question82 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von China?",
            Answers = new List<string> { "Peking", "Shanghai", "Hongkong", "Guangzhou" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question82);

        Question question83 = new Question
        {
            QuestionText = "Wie viele Provinzen hat Kanada?",
            Answers = new List<string> { "5", "8", "10", "13" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question83);

        Question question84 = new Question
        {
            QuestionText = "Wer hat die Mona Lisa gestohlen?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Salvador Dalí", "Vincenzo Peruggia" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question84);

        Question question85 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Großbritannien?",
            Answers = new List<string> { "London", "Manchester", "Liverpool", "Birmingham" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question85);

        Question question86 = new Question
        {
            QuestionText = "Wie viele Gramm sind in einem Kilogramm?",
            Answers = new List<string> { "100", "250", "500", "1000" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question86);

        Question question87 = new Question
        {
            QuestionText = "Welches Land hat die größte Fläche?",
            Answers = new List<string> { "Russland", "Kanada", "China", "USA" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question87);

        Question question88 = new Question
        {
            QuestionText = "Wer hat das Gemälde 'Die Nacht' gemalt?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Edvard Munch", "Rembrandt" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question88);

        Question question89 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Kanada?",
            Answers = new List<string> { "Toronto", "Montreal", "Vancouver", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question89);

        Question question90 = new Question
        {
            QuestionText = "Wie viele Zeitzonen gibt es auf der Welt?",
            Answers = new List<string> { "12", "20", "24", "30" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question90);

        Question question91 = new Question
        {
            QuestionText = "Wer hat den Roman 'Der Fänger im Roggen' geschrieben?",
            Answers = new List<string> { "George Orwell", "Ernest Hemingway", "J.D. Salinger", "F. Scott Fitzgerald" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question91);

        Question question92 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Kanada?",
            Answers = new List<string> { "Toronto", "Montreal", "Vancouver", "Ottawa" },
            CorrectAnswer = 3,
            DifficultyLevel = 1
        };
        questions.Add(question92);

        Question question93 = new Question
        {
            QuestionText = "Wie viele Bundesstaaten hat die USA?",
            Answers = new List<string> { "45", "48", "50", "52" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question93);

        Question question94 = new Question
        {
            QuestionText = "Wer hat das Buch 'Der kleine Prinz' geschrieben?",
            Answers = new List<string> { "Antoine de Saint-Exupéry", "Victor Hugo", "Gustave Flaubert", "Émile Zola" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question94);

        Question question95 = new Question
        {
            QuestionText = "Wie viele Augen hat eine Biene?",
            Answers = new List<string> { "2", "4", "6", "8" },
            CorrectAnswer = 2,
            DifficultyLevel = 1
        };
        questions.Add(question95);

        Question question96 = new Question
        {
            QuestionText = "Was ist die Hauptstadt von Schweden?",
            Answers = new List<string> { "Stockholm", "Göteborg", "Malmö", "Uppsala" },
            CorrectAnswer = 0,
            DifficultyLevel = 1
        };
        questions.Add(question96);

        Question question97 = new Question
        {
            QuestionText = "Wie viele Kilometer sind in einer Meile?",
            Answers = new List<string> { "1", "1.6", "2", "2.5" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question97);

        Question question98 = new Question
        {
            QuestionText = "Wer hat das Gemälde 'Die Sonnenblumen' gemalt?",
            Answers = new List<string> { "Pablo Picasso", "Vincent van Gogh", "Claude Monet", "Salvador Dalí" },
            CorrectAnswer = 1,
            DifficultyLevel = 1
        };
        questions.Add(question98);

        return questions;
    }

}