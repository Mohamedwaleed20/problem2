// See https://aka.ms/new-console-template for more information
Console.Write("please enter the num : ");
double num = double.Parse(Console.ReadLine());
if (num % 2 == 0 )
{
    Console.WriteLine("num is even ");
}
else
{
    Console.WriteLine("num is odd ");
}
Console.ReadKey();