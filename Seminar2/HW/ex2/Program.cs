int EnterNumber()
 {
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}
int g = EnterNumber();
Console.Clear ();

Console.Write ($"{g} -> ");

int r = g;

if (g < 101)
{
    Console.WriteLine ($"третьей цыфры нет");
}
else 
{
    while ( r > 1001 )
    {
      r =  r / 10;
    }
    Console.WriteLine ( $"{r % 10}" );
}