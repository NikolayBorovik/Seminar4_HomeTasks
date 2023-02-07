// 29. Пр-ма, кот задает массив из 8 эл-в и выводит их на экран.
// 1,2,5,7,19 - [1, 2, 5, 7, 19]

Console.Clear();

int[] array = new int[8];

void FillArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        System.Console.Write(array[i]);
    }
}

FillArray(array);
PrintArray(array);