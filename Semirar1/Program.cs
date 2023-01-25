Console.Write ("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write ("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

int userNumber1 = int.Parse(userInput1);
int userNumber2 = int.Parse(userInput2);

if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine ("a = " + userNumber1 + ", b = " + userNumber2 + " -> да");   
}
else
    {
    Console.WriteLine ("a = " + userNumber1 + ", b = " + userNumber2 + " -> нет");
    }

//Console.WriteLine(userNumber + " -> " + userNumber * userNumber);
