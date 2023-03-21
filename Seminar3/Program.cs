//                                                                                  Задача 1
// НАпишите программу, которая принимает на вход координаты точки ( X Y) , причем Х не = 0 , y не = 0
// и выдает номер четверсти в которой находится точка

Console.Clear();
// вариант 1

//Console.Write ("Введите Х: ");
//int X = int.Parse (Console.ReadLine ()); // Parse - метод, можно записать 

//Console.Write ("Введите Y: ");
//int Y = int.Parse (Console.ReadLine ());

// вариант 2
int X , Y ;
try //- "попытайся выполнить"
{
    Console.Write ("Введите Х: ");
    X = int.Parse (Console.ReadLine() ?? ""); // Parse - метод, можно записать 
    
    Console.Write ("Введите Y: ");
    Y = int.Parse (Console.ReadLine() ?? "");
}
catch(Exception exc) // Выдает текстовое описание ошибки
{
    Console.WriteLine ($"Ошибка ввода данных! {exc.Message}");
    return;
}

// Вариант 3
// int X =0 , Y = 0; - при использовании методов, нужно зафиксировать значения.
// InitCoordinatatesByUser (ref x, ref Y); ref - передача с параметра по ссылке
// PrintQuarterByCoords (X , Y);
// static - использовать перед void  так как метод статичен


if (X > 0 && Y > 0) // && - И
{
    Console.WriteLine ("1");
}
else if ( X < 0 && Y > 0 ) //else if так как не взаимоисключающее условие
{
    Console.WriteLine ("2");
}
else if ( X < 0 && Y < 0 ) //else if так как не взаимоисключающее условие
{
    Console.WriteLine ("3");
}
else if ( X > 0 && Y < 0 ) //else if так как не взаимоисключающее условие
{
    Console.WriteLine ("4");
}
else
{
    Console.WriteLine ("Ошибка! Точка попадае на оси координат!");
}