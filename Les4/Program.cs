                                            // Массивы 
// Двумерные массивы многомерные

string[,]table = new string[2, 5]; // string - тип данных, [,] - означает 2 размерности (строки и столбцы), table - наименование массива 
// table[0,0] table[0,1] table[0,2] 
// table[1,0] table[1,1] table[1,2]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

int[ , ] matrix = new int[3, 4]; // Таблица чисел, 5 -количество строк,  8 - столбцы 

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"{table[i, j]}");
    }
}