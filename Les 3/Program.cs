//                                              Методы ВИд1 МЕТОДЫ НИЧЕГО НЕ ВОЗВРАЩАЮТ И НИЧЕГО НЕ ПРИНИМАЮТ
void Method1 ()
{
    Console.WriteLine ("Автор Артур");
}
//Method1 ();


//                                      Метод 2 ВИД 2 МЕТОДЫ НИЧЕГО НЕ ВОЗВРАЩАЮТ И НО МОГУТ ПРИНИМАТЬ ИНФОРМАЦИЮ
void Method2 (string msg)
{
    Console.WriteLine (msg);
}
//Method2 (msg: "Текст сообщения");

void Method21 (string msg, int count   )    
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i ++; 
    }
}
//Method21 (msg: "Текст", count: 4);
//Method21 (msg: "New Текст", count: 4);


//                                                  Метод 3 ВИД 3 МЕТОДЫ ЧТО-ТО  ВОЗВРАЩАЮТ И НО НИЧЕГО НЕ ПРИНИМАЮТ
int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3 ();
//Console.WriteLine(year);


//                                              Метод 4 ВИД 4 МЕТОДЫ ЧТО-ТО  ВОЗВРАЩАЮТ И что-то ПРИНИМАЮТ
string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;
}
 
//string res =  Method4 (10 , "Текст");
//Console.WriteLine (res);


//                                                                      ЦИКЛ for из метода 4 собираем метод 5
string Method5 (int count, string text)
{
    //int i = 0 - - добавляем в for
    
    string result = String.Empty;
    for ( int i = 0; i < count; i++ )
        // while //(i < count) - добавляем в for
    {
    result = result + text;
         //   i++; - добавляем в for
    }
        return result;
}
 
//string res =  Method5 (10 , "Текст");
//Console.WriteLine (res);

//                                                                  Методы и циклы таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int g = 2; g <= 10 ; g++)
   {
//       Console.WriteLine ($"{i} x {g} = {i * g}" );
   }
//    Console.WriteLine ();
}

//                                                                  Задача 1 заменить заглавные на строчные
// Дан текстк. В тексте нужно все пробелы заменить черточками,
// маленькие буквы к заменить большими К,
// большие буквы С заменить маленькими с.

string text = "- Я думая, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r


string Replace (string text, char oldValue, char newValue ) // Мы написали функцию под названием Replace, которая берет значиение char oldValue и меняет на char newValue
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // result = result + $"{newValue}" - в результат положить новое значение
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '|');
newText = Replace (newText, 'к', 'К');
newText = Replace (newText, 'С', 'с');
//Console.WriteLine (newText);


//                                                          Работа с массивами
//метод максимального сортировка массива
// найти позитицию минимального элемента
// произвести обмен этого значения с текущей позицией
// повторять, пока массив не упорядочится

int[] arr = {1,9,5,8,9,7,3,5,6,4,2,1};

void PrintArray (int [] array) // функция которая печататет массив
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write ($"{array[i]} ");
    }

    Console.WriteLine ();
}

void SelectionSort(int[] array) // функция которая меняет местами значения
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array [j] < array [minPosition]) minPosition = j ; // если поменять знак < на > то функция будет работать в обратном порядке
        }
        int temporary = array [i];
        array [i] = array[minPosition];
        array [ minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort (arr);
PrintArray (arr);