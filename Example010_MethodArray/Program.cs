int[] array = { 13, 52, 81, 43, 55, 16, 73, 81 };

int n = array.Length;
int find = 81;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}