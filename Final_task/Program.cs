// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());

string[] array = new string[elements];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива c индексом {i}: ");
    array[i] = Console.ReadLine();
}

string[] resultArray = NewStringArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(resultArray);

string[] NewStringArray(string[] arr)
{
    int index = 0;
    string[] stringArray = new string[elements];
    for (int i = 0; i < elements; i++)
    {
        if (arr[i].Length <= 3)
        {
            stringArray[index] = arr[i];
            index++;
        }
    }
    string[] resultArray = new string[index];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = stringArray[i];
    }
    return resultArray;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}