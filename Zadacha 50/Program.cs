


//получает число с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 20);
        }
    }

    return matrix;
}
void FindPosition(int[,] matrix, int num)
{
    bool flag = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {
                Console.WriteLine($"Позиция числа {num}: [{i}, {j}]");
                flag = false;
            }
        }

    }

    if (flag == true)
        Console.WriteLine("Такого элемента нет");
}

void PrintMatrix(int[,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] == num)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{matrix[i, j]} ");
                Console.ResetColor(); 

            }
            else
                Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите размер массива m");
int n = GetNumber("Введите размер массива n");
int num = GetNumber("Введите целое число, которое надо найти");

int[,] matrix = InitMatrix(m, n);


Console.WriteLine("Матрица:");
PrintMatrix(matrix, num);
FindPosition(matrix, num);
