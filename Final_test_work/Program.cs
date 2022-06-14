string[] initialArray = { "Написать", "программу", ",", "которая", "из", "имеющегося", "массива", "строк", "формирует",
                          "массив", "из", "строк", ",", "длина", "которых", "меньше", "либо", "равна", "3", "символа" };
int arrayElementSize = 3;

int ArrayLengthCalculation(int symbolsQuantity, string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= symbolsQuantity)
        {
            count++;
        }
    }
    return count;
}

string[] ArrayCreationFromInitialArray(int symbolsQuantity, string[] inputArray, int newArrayLength)
{
    string[] outputArray = new string[newArrayLength];
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= symbolsQuantity)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }
    return outputArray;
}

string PrintArray(string message, string[] inputArray)
{
    Console.Write(message);
    string output = "[ ";
    for (int i = 0; i < inputArray.Length; i++)
    {
        output += $"'{inputArray[i]}' ";
    }
    output += " ]";
    return output;
}

int arrayLength = ArrayLengthCalculation(arrayElementSize, initialArray);
string[] targetArray = ArrayCreationFromInitialArray(arrayElementSize, initialArray, arrayLength);
Console.WriteLine(PrintArray("Исходный массив: ", initialArray));
Console.WriteLine(PrintArray("Целевой массив: ", targetArray));