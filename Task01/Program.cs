// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите элементы массива, разделяя их запятыми: ");
string input = Console.ReadLine();
string[] inputArray = input.Split(',');
int count = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
    }
}

string[] resultArray = new string[count];
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        resultArray[index] = inputArray[i];
        index++;
    }
}

Console.Write("[");
for (int i = 0; i < inputArray.Length; i++)
{
    if (i < inputArray.Length - 1) Console.Write(inputArray[i] + ", ");
    else Console.Write(inputArray[i]);
}
Console.Write("]");

Console.Write("->[");
for (int i = 0; i < resultArray.Length; i++)
{
    if (i < resultArray.Length - 1) Console.Write(resultArray[i] + ", ");
    else Console.Write(resultArray[i]);
}
Console.Write("]");
