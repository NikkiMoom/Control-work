// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] arrayA = new string[7] {"123", "23", "hello", "world", "res", "Russia", "-2"};
string[] arrayB = new string[arrayA.Length];
void SecondArrayWithIF(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayA, arrayB);
PrintArray(arrayB);