// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Count()
// {
//     Console.Write("How man numbers you want to enter: ");
//     int amount = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     while (amount > 0)
//     {
//         int number = 0;
//         Console.Write("Enter a number: ");
//         number = Convert.ToInt32(Console.ReadLine());
//         if (number > 0)
//         {
//             count++;
//         }
//         amount--;
//     }

//     return count;
// }

// Console.WriteLine(Count());

Console.Write("How man numbers you want to enter: ");
int quant = Convert.ToInt32(Console.ReadLine());

int[] count = FillArray(quant);
PrintArray(count);
Console.Write(CountNatural(count));

int[] FillArray(int amount)
{
    var result = new int[amount];
    for(int i = 0; i < quant; i++)
    {
        Console.Write("Enter a number: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

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