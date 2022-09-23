 //Задача 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30



void PrintNumber(int M, int N)
{
  int sum = 0;
  for (int i = M; i <= N; i++)
  {
    sum = sum + i;
  }
  Console.WriteLine(sum);
}
PrintNumber(1, 15);