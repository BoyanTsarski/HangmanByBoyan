const string WinScreenText = @"
 
┌───────────────────────────┐
│ │
│ WW WW ** NN N │
│ WW WW ii NNN N │
│ WW WW WW ii N NN N │
│ WWWWWWW ii N NNN │
│ WW W ii N NN │
│ │
│ Good job! │
│ You guessed the word! │
└───────────────────────────┘
";
const string LossScreenText = @"

┌────────────────────────────────────┐
│ LLL OOOO SSSS SSSS │
│ LLL OO OO SS SS SS SS │
│ LLL OO OO SS SS │
│ LLL OO OO SSSS SSSS │
│ LLL OO OO SS SS │
│ LLLLLLLLLL OO OO SS SS SS SS │
│ LLLLLLLLL OOOO SSSS SSSS │
│ |
│ You were so close. │
│ Next time you will guess the word! │
└────────────────────────────────────┘
";
string[] wrongGuessesFrames =
{
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"       \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══"
};
string[] deathAnimationFrames =
{
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      /   ║   " + '\n' +
    @"      \   ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    |__   ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    \__   ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"   ____   ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"    __    ║   " + '\n' +
    @"   /══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    _ '   ║   " + '\n' +
    @"  _/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══"
};


    static void Main(string[] args)
    {
        string[] words = ReadWordsFromFile();
        bool playAgain = true;

        Console.CursorVisible = false;

        while (playAgain)
        {
            string word = GetRandomWord(words);
            string wordToGuess = new string('_', word.Length);
            int incorrectGuessCount = 0;
            List<char> playerUsedLetters = new List<char>();

            DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);

            

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
            }

            Console.Clear();
        }

        Console.WriteLine("Thank you for playing! Hangman was closed.");
        Console.Clear();
    }

    static string[] ReadWordsFromFile()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
        const string WordsFileName = "words.txt";
        string path = $@"{projectDirectory}\{WordsFileName}";
        string[] words = File.ReadAllLines(path);
        return words;
    }

    static string GetRandomWord(string[] words)
    {
        Random random = new Random();
        string word = words[random.Next(words.Length)];
        return word.ToLower();
    }

    static void DrawCurrentGameState(bool inputIsInvalid, int incorrectGuessCount, string guessedWord, List<char> playerUsedLetters)
    {
        Console.Clear();
        Console.WriteLine($"Incorrect Guesses: {incorrectGuessCount}");
        Console.WriteLine($"Guessed Word: {guessedWord}");
        Console.WriteLine($"Used Letters: {string.Join(", ", playerUsedLetters)}");

        if (inputIsInvalid)
        {
            Console.WriteLine("You should type only a single character!");
        }

        Console.Write("Your symbol: ");
    }

void PlayGame(string word, string wordToGuess, int incorrectGuessCount, List<char> playerUsedLetters)
{
    while (true)
    {
        DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
        string playerInput = Console.ReadLine().ToLower();

        if (playerInput.Length != 1)
        {
            DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
            continue;
        }

        char playerLetter = playerInput[0];
        playerUsedLetters.Add(playerLetter);

        if (CheckIfSymbolIsContained(word, playerLetter))
        {
            wordToGuess = AddLetterToGuessWord(word, playerLetter, wordToGuess);
        }
        else
        {
            incorrectGuessCount++;
        }

        DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);

        if (CheckIfPlayerWins(wordToGuess))
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You guessed the word.");
            Console.WriteLine($"The word you guessed is: {word}");
            break;
        }

        if (CheckIfPlayerLoses(incorrectGuessCount))
        {
            Console.Clear();
            Console.WriteLine("Sorry, you've run out of guesses. The word was: " + word);
            break;
        }
    }
}


bool CheckIfSymbolIsContained(string word, char playerLetter)
{
    return word.Contains(playerLetter);
}

string AddLetterToGuessWord(string word, char playerLetter, string wordToGuess)
{
    char[] wordToGuessArray = wordToGuess.ToCharArray();

    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == playerLetter)
        {
            wordToGuessArray[i] = playerLetter;
        }
    }

    return new string(wordToGuessArray);
}

bool CheckIfPlayerWins(string wordToGuess)
{
    return !wordToGuess.Contains('_');
}

bool CheckIfPlayerLoses(int incorrectGuessCount)
{
    const int MaxIncorrectGuesses = 6;
    return incorrectGuessCount >= MaxIncorrectGuesses;
}

void DrawDeathAnimation(string[] deathAnimationFrames)
{
    Console.SetCursorPosition(0, 0);

    foreach (string frame in deathAnimationFrames)
    {
        Console.WriteLine(frame);
        System.Threading.Thread.Sleep(200);
    }
}
