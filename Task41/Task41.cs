//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray()
 {
    int N = Input("Введите количество чисел: ");
    return new int [N];
 }

void FillByUser(int[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Input("Введите число: ");
    }
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

void CountOfPositiveNumbers(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
Console.WriteLine("Количество чисел больше 0: " + count);
Console.WriteLine();
}


int[] numbers = CreateArray();
FillByUser(numbers);
PrintArray(numbers);
CountOfPositiveNumbers(numbers);




