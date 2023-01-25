
Console.Write ("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write ("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);

Console.Write ("a = " + userNumber1 + ", b = " + userNumber2 + " -> max = ");

if (userNumber1 > userNumber2)
{
    Console.Write (userNumber1);   
}
else
    {
    Console.Write (userNumber2);
    }

//Console.WriteLine(userNumber + " -> " + userNumber * userNumber);
