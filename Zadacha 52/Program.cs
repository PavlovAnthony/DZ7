


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
            matrix[i, j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}
void FindSum(int[,] matrix)
{
double sum = 0;
string average = "среднее арифметическое по столбцам : ";

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            sum= sum+matrix[i,j];
        }
        sum = Math.Round(sum/matrix.GetLength(0), 2);
        average = average + Convert.ToString(sum) + " ";
    }
    Console.WriteLine(average);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите размер массива m");
int n = GetNumber("Введите размер массива n");


int[,] matrix = InitMatrix(m, n);


Console.WriteLine("Матрица:");
PrintMatrix(matrix);
FindSum(matrix);
