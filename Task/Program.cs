//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array = new string[] { "Пять", "плюс", "Пять", "равно", "10" };
string[] NewArray = new string[Array.Length];

void FindArray(string[] Array, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            NewArray[count] = Array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.Write(" ]");
    Console.WriteLine();
}

Console.Clear();
Console.Write($"[ Пять плюс пять равно 10 ] -> [ ");
FindArray(Array, NewArray);
PrintArray(NewArray);

