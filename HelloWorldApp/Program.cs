

Console.WriteLine("Welcome to the program 'Hello'");
Console.WriteLine();
Console.WriteLine("If you wish to display the message in English, enter '1'");
Console.WriteLine("If you wish to display the message in French, enter '2'");
Console.WriteLine("If you wish to quit the program, enter 'q'");

var selectedChoice = Console.ReadLine();

if (selectedChoice == "1")
{
    Console.WriteLine("Hello, World!");
} else if (selectedChoice == "2")
{
    Console.WriteLine("Bonjour tout le monde");
} else if (selectedChoice == "q")
{
    Console.WriteLine("Bye!");
}