Console.WriteLine ("Enter required number of elements");
int M = Convert.ToInt32(Console.ReadLine());
int [] FillArray()
{
    int [] array = new int [M];
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter element");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i] = element;
    }
    return array;
}

int[] arr = FillArray();

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
ShowArray(arr);

void CountElements(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i]>0)
        {
            count = count +1;
        }
    }
     Console.WriteLine($"There are  {count} greater then 0 elements in array");
}
CountElements(arr);