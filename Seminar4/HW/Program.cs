/*int A, B ;
try //- "попытайся выполнить"
{
    Console.Write ("Введите A: ");
    A = int.Parse (Console.ReadLine() ?? ""); // Parse - метод, можно записать 
    
    Console.Write ("Введите B: ");
    B = int.Parse (Console.ReadLine() ?? "");
}
catch(Exception exc) // Выдает текстовое описание ошибки
{
    Console.WriteLine ($"Ошибка ввода данных! {exc.Message}");
    return;
}
*/
/*
                    // задание 25  
            // Принимает на вход 2 числа и выдает первое чило в степени второго числа 
int A = EnterNumber();
int B = EnterNumber();
Console.Clear();
Console.WriteLine ($"{A}, {B} -> {Stepen(A,B)}");

int Stepen(int a, int b){
    int result = 1;
    for (int i = 1; i < b+1; i++)
    {
        result *= a;
    }
    return result;   }
*/
int EnterNumber(){

    int number;
    while (true)
    {
        Console.Write("Введите число: ");
         if (int.TryParse(Console.ReadLine(), out number))
             break;
         Console.WriteLine("Ошибка ввода!");
     }
     return number;}


                //  задание 27 
        //программу которая принимает на вход число и выдает сумму цифр в числе

/*
int number = EnterNumber();
Console.Clear();
//PrintArray (NumberToArray (number));
Console.WriteLine ($"{number} -> {SumArray(NumberToArray (number))}");

//void PrintArray (int [] array) // функция которая печататет массив
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine ();
}

int[] NumberToArray (int number) // функция которя преобразовывает число в массив
{
   List<int> list = new List<int>();
   while (number > 0)
   {
      int digit = number % 10;
      number /= 10;
      list.Add(digit);
   }
   list.Reverse();
   return list.ToArray();
}

int SumArray (int[] array){ // функция которая считает сумму значений массива
    int sum = 0;
        for (int i = 0; i < array.Length ; i++){
            sum += array[i]; 
        }
        return sum;
}
*/

/////                       напиать программу которая принимает на вход число и пишет все циры за ней с помощью рекурсии


/*
int N = EnterNumber();
Console.Write (N + " -> " );
PrintNumbers(N);

void PrintNumbers (int n) // рекурсия, которая печатает числа от 1 до n
{
    if (n <= 0) 
    return;
    Console.Write ($"{n} ");
    PrintNumbers(n-1);
}
*/

//                      Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N включительно.
/*
int M = EnterNumber();
int N = EnterNumber();
Console.Clear();
Console.WriteLine ($"M = {M}; N = {N} -> {SumNumbers(M, N)}");

int SumNumbers (int FirstNumber, int SecondNumber){
    int sum = 0;
    for (int i = FirstNumber; i <= SecondNumber; i++){
        sum += i;
    }
    return sum;}
*/


//