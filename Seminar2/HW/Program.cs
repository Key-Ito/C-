int EnterNumber()
 {
    int number;
    while (true)
    {
        Console.Write("Введите трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out number) && number > 100 && number < 1000)
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}
int g = EnterNumber();
Console.Clear ();

Console.Write ($"{g} -> {(g / 10) % 10 }");
