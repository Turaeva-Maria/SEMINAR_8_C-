/* Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.*/


int[] InputMatrix(int[, ] matrix)
{
   int minColumn = 0, minRow = 0, minNumber = 11;
   int[] arrayCord = new int[2];

   for (int i = 0; i < matrix.GetLength(0); i++)
   {   
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         matrix[i, j] = new Random().Next(1, 11);
         if (minNumber > matrix[i, j])
         {
            minNumber = matrix[i, j];
            minRow = i;
            minColumn = j;
         }
         Console.Write($"{matrix[i, j]} \t");
      }
      Console.WriteLine();
   }
   arrayCord[0] = minRow;
   arrayCord[1] = minColumn;
   //Console.WriteLine(string.Join(", ",arrayCord));
   return arrayCord;
}
void ReleaseMatrix(int[, ] matrix, int[] arrayCord)
{
   Console.WriteLine();
   int i1 = arrayCord[0], j1 = arrayCord[1];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         if (i != i1 && j != j1)
            Console.Write(matrix[i, j] + " \t");
      }
      Console.WriteLine();
   }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] array = new int[2];
array = InputMatrix(matrix);
//Console.WriteLine(string.Join(", ", array));
ReleaseMatrix(matrix, array);

