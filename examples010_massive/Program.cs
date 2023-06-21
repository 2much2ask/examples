int[] array = { 12, 3, 4, 85, 69, 39, 85, 69, 39 };

int n = array.Length;

int find = 69;

int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}