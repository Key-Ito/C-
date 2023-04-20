// Задача 24 Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А (4 -> (1+2+3+4) -> 10)


// Console.Write ("Введите число A: ");
// int A = int.Parse(Console.ReadLine()?? "");

// Console.Write ($"{A} -> ");
// PrintSquares(A); 

/*
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
     }*/

     /*
void PrintSquares(int A) // void Не может использоваться так как он не возвращает
{
    int sum = 0;
    for (int sum = 1; sum < A; i++)
    {
        int result = i * i * i;
        Console.Write ($"{result}, ");
    }
    Console.Write ($"{N * N * N}");
}*/

///////// OR ///
/*
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

int GetNumberFromUser(string message, string errorMessage)
{    
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber); 
        // bool - логический метод имеет значение либо правда  либо ложь
        // Console.ReadLine(), out int userNumber - вводится число и если оно целое то оно присваивается в userNumber
        if(isCorrect) // если isCorrect приравнялся и случился то выполняется условие если нет, то переходит на else
            return userNumber;
        Console.WriteLine(errorMessage);
    }    
}

// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}


int num = new Random().Next(0,10000);
Console.WriteLine (num);
Number (num);

void Number (int UserNumber)
{
    int a = UserNumber;
    int i = 0;
    while (UserNumber > 0){
        UserNumber /=10;
        i += 1;
    }
    
    // int a = UserNumber;
    // int b = 0;
    // for (int i = 0; UserNumber/10 > 0 ; i++)
    // {
    //     UserNumber = UserNumber / 10;
    //     i += 1;
    // }
    // return i;
    Console.WriteLine ($"{a} -> {i}");
}


int num = new Random().Next(0,10);
Console.WriteLine (num);
int N = GetMultiplyNumbers (num);
Console.WriteLine ($"{num} -> {N}");

int GetMultiplyNumbers(int number)
{
    int multiply = 1;
    while(number > 0)
    {
        multiply *= number;
        number--;
    }
    return multiply;
}
*/

int[] arr = new int[8];
PrintArray(arr);
arr = GenerationArray (arr);
PrintArray(arr);

int[] GenerationArray (int [] array) // функция которая изменяет массив
{
    int[] arr = new int[array.Length];
    //int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
       // result[i] = arr[i];
    }
    return arr;
}

void PrintArray (int [] array) // функция которая печататет массив в заданном размере //с рандомным занчением  0 иил 1 
{
    int count = array.Length;
    //int[] arr = new int[array.Length];
    for (int i = 0; i < count ; i++)
    {
       //arr[i] = new Random().Next(0, 2);
        Console.Write ($"{arr[i]} ");
    }
    Console.WriteLine ();
}


