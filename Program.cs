string[] InputArray()
{
    Console.Write("Input the Length of Array: ");
    int length = int.Parse(Console.ReadLine());
    if (length < 0) length = 0;
    string[] array = new string[length];
    if (length == 0) return array;

    Console.WriteLine("Input the Elements of Array: ");
    for (int i = 0; i < length; i++) array[i] = Console.ReadLine();
    return array;
}


int CountNeedItems(string[] arr)
{
    int count = 0;
    foreach (string item in arr) if (item.Length <= 3) count++;
    return count;
}


string[] FillOutputArray(string[] arr)
{
    int length = CountNeedItems(arr);
    string[] array = new string[length];
    if (length == 0) return array;

    int count = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            array[count] = item;
            count++;
        }
    }
    return array;
}


void PrintArray(string[] arr)
{
    if (arr.Length == 0) return;

    int count = 0;
    while (count < arr.Length)
    {
        Console.Write($" {arr[count]} ");
        count++;
    }
    Console.WriteLine();
}


string[] array_in = InputArray();
Console.Clear();
Console.Write("Input Array:");
PrintArray(array_in);
Console.Write("Output Array:");
PrintArray(FillOutputArray(array_in));
