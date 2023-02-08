internal class Program
{
    private static void Main(string[] args)
    {
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
        int firstNumber = EnterNumber();
        int secondNumber = EnterNumber();

        Console.Clear();
        Console.Write($"{firstNumber}, {secondNumber} -> ");
        if (firstNumber % secondNumber == 0)
            Console.WriteLine("кратно");
        else
            Console.Write($"не кратно, остаток {firstNumber % secondNumber}");

    }
}