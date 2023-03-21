/*
//                                                              задача 21 
// Принимает координаты двух точек и находит рассотяние между ними в 2D простанстве
// A (3 , 6) B (2 ,1)

int a1 , a2, b1, b2;

a1 = Koords("Введите координату х первой точки: ");
a2 = Koords("Введите координату y первой точки: ");
b1 = Koords("Введите координату х второй точки: ");
b2 = Koords("Введите координату y второй точки: ");

Console.WriteLine ($"{Distanse(a1, a2, b1, b2)}" );

static int Koords (string Message)
{
    Console.Write (Message);
    int result = int.Parse (Console.ReadLine() ?? "");
    return result;
}

static double Distanse (int a1, int a2,int b1, int b2)
{
    double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2-a2, 2));
    // Math.Sqrt - корень из b1 -a1 (разности чисел в нашем случае), 2- значит квадратный корень
    return result;
}
*/


//                                  Задача 22
// Написать прогу, которая принимает на вход число (N) 
// и выдает таблицу квадратов от чисел 1 до N.

Console.Write ("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "");

Console.Write ($"{N} -> ");
PrintSquares(N); 

void PrintSquares(int N)
{
    for (int i = 1; i < N; i++)
    {
        int result = i * i;
        Console.Write ($"{result}, ");
    }
    Console.Write ($"{N * N}");
}