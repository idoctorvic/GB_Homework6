// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] IntArray()
{
Console.Write("Enter few numbers separated by spaces: ");
string? sNumbers = Console.ReadLine();
string[] sArray = sNumbers.Split(" ");
int[] intArray = Array.ConvertAll<string, int>(sArray, int.Parse);
return intArray;
}

int[] result = IntArray();
PrintArray(result);
Console.WriteLine(CountNatural(result));

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (i == array.Length - 1)
		{
			Console.WriteLine($"{array[i]}");
		}
		else
		{
			Console.Write($"{array[i]}, ");
		}
	}
}

int CountNatural(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
