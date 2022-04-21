using static System.Console;
using static System.Convert;

try
{
    int n1, n2;
    Write("Enter a number between 0 and 255:");
    n1 = ToInt32(ReadLine());
    Write("Enter a number between 0 and 255:");
    n2 = ToInt32(ReadLine());
    WriteLine($"{n1} divided by {n2} is {n1 / n2}");
}
catch (FormatException)
{
    WriteLine("Input string was not in a correct format.");
}