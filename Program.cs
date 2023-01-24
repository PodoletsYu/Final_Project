string[] arr1 = new string[7] {"Hello", "23", ":-)", "world", "Kazan", "home", "old"};
string[] arr2 = new string[arr1.Length];

void ResultArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
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
ResultArray(arr1, arr2);
PrintArray(arr2);