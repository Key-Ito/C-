//                                      Задача 19
// Напишите программу кторая принимает на вход 5 значное число
// и проверяет, является ли оно палиндромом
/*
Console.Write ("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()?? "");


int d1 = N / 10000;
int d2 = (N % 10000) / 1000;
int d3 = (N % 1000) / 100;
int d4 = (N % 100) / 10;
int d5 = N % 10;
        
if (d1 == d5 && d2 == d4)
    {
        Console.WriteLine($"{N} -> да");
    }
    else
    {
        Console.WriteLine($"{N} -> нет");
    }
*/        


//                                  Задача 21
// принимает на вход координаты 2 точек 
// и находит рассотяние между 2 точками в 3д простанстве 

/*
int a1, a2, a3, b1, b2, b3;

a1 = Koords("Введите координату х первой точки: ");
a2 = Koords("Введите координату y первой точки: ");
a3 = Koords("Введите координату z первой точки: ");
b1 = Koords("Введите координату х второй точки: ");
b2 = Koords("Введите координату y второй точки: ");
b3 = Koords("Введите координату z второй точки: ");

//Console.clear;
Console.WriteLine ($"A ({a1},{a2},{a3}); B ({b1},{b2},{b3}) -> ");
Console.Write ($"{Distanse(a1, a2, a3, b1, b2, b3)}");

static int Koords (string Message)
{
    Console.Write (Message);
    int result = int.Parse (Console.ReadLine() ?? "");
    return result;
}

static double Distanse (int a1, int a2, int a3, int b1, int b2, int b3)
{
    double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2-a2, 2)+ Math.Pow(b3-a3, 2));
    // Math.Sqrt - корень из b1 -a1 (разности чисел в нашем случае), 2- значит квадратный корень
    return result;
}

*/

//                                                      Задача 23
// Программа, которая принимает на вход числр (N) 
// и выдает таблицу кубов от чисел 1 до N

/*
Console.Write ("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "");

Console.Write ($"{N} -> ");
PrintSquares(N); 

void PrintSquares(int N)
{
    for (int i = 1; i < N; i++)
    {
        int result = i * i * i;
        Console.Write ($"{result}, ");
    }
    Console.Write ($"{N * N * N}");
}
*/