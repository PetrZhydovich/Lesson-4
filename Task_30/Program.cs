//  Показать кубы чисел, заканчивающихся на четную цифру

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine($"{arr[position]} ");
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

double result = 0;
int index = 0;
int power = 3;
while (array[index] % 2 == 0)
{
    result = Math.Pow(array[index], power);
    Console.WriteLine($"{array[index]} ^ {power} = {result}");
    index++;
}