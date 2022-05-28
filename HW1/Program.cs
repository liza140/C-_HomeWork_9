// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// Создание массива
int[,] CreateArray(int m)
{
    int[,] array = new int[m, m];
    return array;
}

// Заполнение треугольника

void FillTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
        array[i, i] = 1;
    }
    for (int i = 2; i < array.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}

// равнобедренное представление треугольника
void PrintFinalTriangle(int[,] array, int n)
{
    int cell = 3;
    int col = cell * n;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 5); //Добавила "5" для отступа от верхнего края
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]}  ");
            }
            col += cell * 2;
        }
        col = cell * n - cell * (i + 1);
        Console.WriteLine();
    }
}

int M = 15;
int N = 10;
int[,] Triangle = CreateArray(M);
FillTriangle(Triangle);
PrintFinalTriangle(Triangle, N);