// Методы ВИд1 МЕТОДЫ НИЧЕГО НЕ ВОЗВРАЩАЮТ И НИЧЕГО НЕ ПРИНИМАЮТ
void Method1 ()
{
    Console.WriteLine ("Автор Артур");
}
//Method1 ();


// Метод 2 ВИД 2 МЕТОДЫ НИЧЕГО НЕ ВОЗВРАЩАЮТ И НО МОГУТ ПРИНИМАТЬ ИНФОРМАЦИЮ
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


// Метод 3 ВИД 3 МЕТОДЫ ЧТО-ТО  ВОЗВРАЩАЮТ И НО НИЧЕГО НЕ ПРИНИМАЮТ
int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3 ();
//Console.WriteLine(year);


// Метод 4 ВИД 4 МЕТОДЫ ЧТО-ТО  ВОЗВРАЩАЮТ И что-то ПРИНИМАЮТ
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
 
string res =  Method4 (10 , "Текст");
//Console.WriteLine (res);
