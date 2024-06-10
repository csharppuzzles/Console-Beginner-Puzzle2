
static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("\nWhat's your favourite color?: ");
    string? color1 = Console.ReadLine();

    Console.WriteLine("\nWhat's your second favourite color?: ");
    string? color2 = Console.ReadLine();

    // String Join()
    string message = "Your favourite colors are: " + string.Join(" ", color1, color2);
    string message2 = "Your favourite colors are: " + string.Join(" and ", color1, color2);
    Console.WriteLine(message);
    Console.WriteLine(message2);
}


// Puzzle A -  What's your name, baby?
//
// Write a program that asks "What's your first name, baby?".
// Have the program also ask for your second name.
// Use string.Join() to create the final sentence "Your full name is {firstName} {secondName}"
// Use multiple string.Joins to create the final sentence "Name: {secondName}, {firstName}"
// Remember to have spaces between the strings when you join them.

static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("\nWhat's your first name, baby?: ");
    string? firstName = Console.ReadLine();

    Console.WriteLine("\nWhat's your second name?: ");
    string? secondName = Console.ReadLine();

    string message = string.Join(" ", "Your full name is", firstName, secondName);

    string name = string.Join(", ", secondName, firstName);
    string message2 = string.Join(" ", "Name: ", name);

    Console.WriteLine(message);
    Console.WriteLine(message2);
}


static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    string message = "I got married, had a few kids, paid a few bills, retired to Florida and died.";
    Console.WriteLine(message);

    Console.WriteLine(message.Replace("bills", "hookers"));
}


// Puzzle B - You are replaceable
//
// Write a program that asks the user to "Input a sentence with the word "and" in it: ".
// Replace every occurence of the word "and" with the symbol &
// Remember to escape the backslashes around "and" or use verbatium.

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("\n Input a sentence with the word \"and\" in it: ");
    string? input = Console.ReadLine();

    string result = input.Replace("and", "&");
    Console.WriteLine(result);
}


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Lets join words onto a sentence!: ");

    Console.WriteLine("\n Please enter a sentence: ");
    string? sentance = Console.ReadLine();

    Console.WriteLine("\n Enter a word: ");
    string? word1 = Console.ReadLine();

    Console.WriteLine("\n Enter another word: ");
    string? word2 = Console.ReadLine();

    string output = string.Join(" ", sentance, word1, word2);

    Console.WriteLine(output);
}


// Puzzle C – Choose a word to replace
//
// Write a program that asks the user "Please enter a sentence: "
// Then ask the user "Which word will we replace?: "
// Then ask the user "Replace it with what?: "
// Output the original sentence with the word replaced.
// Don't worry if the user enters a word that is not in the sentence, we have not covered loops or error catching yet.
// Just to be clear, the program WILL crash if the user enters a word not in the sentence. That's ok for now.
// Don't worry about green squiggly lines, we have not covered null checks yet.
static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("\n Please enter a sentence: ");
    string? sentence = Console.ReadLine();

    Console.WriteLine("Which word will we replace?: ");
    string? word1 = Console.ReadLine();

    Console.WriteLine("Replace it with what?: ");
    string? word2 = Console.ReadLine();

    string output = sentence.Replace(word1, word2);

    Console.WriteLine(output);
}



// Run the puzzles

ExampleA();
//PuzzleA();

ExampleB();
//PuzzleB();

ExampleC();
//PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter