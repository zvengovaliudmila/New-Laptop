//Перевепнуть одномерный массив.

int[] array = new int[] {1,2,3,4,5};
PrintArray(array);
int [] reverseArray = ReverseArray(array);
Console.WriteLine();
PrintArray(reverseArray);

void PrintArray (int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
     Console.Write($"{array[i]}");
     }
}

int[] ReverseArray (int[] array)
{

    int [] reverseArray = new int[array.Length];
    for ( int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - 1 - i];
    }

    return reverseArray;
}