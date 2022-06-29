// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
string entry = Console.ReadLine();
TrueOrFalse.Tools.SetUpInputStream(entry);
string[] questions = new string[2];
questions[0] = "You are coding";
questions[1] = "You are bad";
bool[] answers = new bool[2];
answers[0] = true;
answers[1] = true;
bool[] responses = new bool[questions.Length];
if (questions.Length != answers.Length)
{
    Console.WriteLine("Warning the length of questions doesn't equals the length of answers.");
}
int askingIndex = 0;
foreach (var question in questions)
{
    string input;
    bool isBool;
    bool inputBool;
    Console.WriteLine(question);
    Console.WriteLine("True or False?");
    input = Console.ReadLine();
    isBool = Boolean.TryParse(input, out inputBool);
    // refazer essa parte com try catch
    while (isBool != true)
    {
        Console.WriteLine("Respond with True or False");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

    }
    responses[askingIndex++] = inputBool;
}
var scoreIndex = 0;
var score = 0;
Console.WriteLine(askingIndex);
foreach (bool answer in answers)
{
    var response = responses[scoreIndex];
    Console.WriteLine(scoreIndex + 1 + ".");
    Console.WriteLine($"Input:{response} | Answer{answer} ");
    if (response = answer)
    {
        score++;
    }
    scoreIndex += 1;
}
Console.WriteLine($"you got {score} points");