Console.WriteLine("Введите строки через пробел");
string element = Console.ReadLine();
string[] array = element.Split(' ');

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] CreateNewArray(string[] arr)
{
    string[] result = new string[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        string arrayElement = arr[i];
        if (arrayElement.Length <= 3)
        {
            result[i] = arrayElement;
        }
        else
            result[i] = string.Empty;
    }
    return result;
}

void PrintArray1(string[] array)
{
    Console.Write("[");
    if (array[0] != string.Empty)
    {
        Console.Write($"{array[0]}");
        for (int i = 1; i < array.Length; i++)
        {
           if (array[i] != string.Empty)
            if (i < array.Length - 1) Console.Write($", {array[i]} ");
            else Console.Write($", {array[i]}");
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != string.Empty)
                if (i < array.Length - 1) Console.Write($"{array[i]} ,");
                else Console.Write($"{array[i]}");
        }
    }

    Console.WriteLine("]");
}

PrintArray(array);
string[] resultarray = CreateNewArray(array);
PrintArray1(resultarray);