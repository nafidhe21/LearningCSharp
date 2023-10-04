Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");

int firstInput = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");

int secondInput = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those number?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine().ToUpper();

if (userChoice == "A")
{
    Console.WriteLine($"{firstInput} + {secondInput} = {firstInput+secondInput}");
} 
else if (userChoice == "S")
{
    Console.WriteLine($"{firstInput} - {secondInput} = {firstInput - secondInput}");
}
else if (userChoice == "M")
{
    Console.WriteLine($"{firstInput} * {secondInput} = {firstInput*secondInput}");
}
else
{
    Console.WriteLine("Invalid Choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();