// Task #1 ------------------
Console.WriteLine("Task 1");
int sum = 0;
Console.Write("Введите число:");
while (true)
{
    String? add_number = Console.ReadLine();
    if (int.TryParse(add_number, out int number))
    {
        foreach (Char addik in add_number)
        {
            sum += int.Parse(addik.ToString());
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("Сумма цифр четное число. Выход. ");
            break;
        }
    }
    else
    {
        if (add_number == "q")
            Console.WriteLine(" 'q'. Выход. ");
        break;
    }
    sum = 0;
}


// Task #2 -----------------
int[] CreateArray(int number_array, int max_number, int min_number)
{
    Random rand = new Random();
    int[] array = new int[number_array];
    for (int i = 0; i < number_array; i++)
    {
        array[i] = rand.Next(min_number, max_number);
    }
    return array;
}

int CountEven(int[] mass)
{
    int count_even = 0;
    foreach (int number in mass)
    {
        if (number % 2 == 0)
        {
            count_even += 1;
        }
    }
    return count_even;
}

// Task #3 -----------------
void ReversMass(int[] mass)
{
    Array.Reverse(mass);
}

Console.WriteLine("Task 2");
Console.WriteLine("Введите количество элементов:");
int number_array = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
int max_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение:");
int min_number = Convert.ToInt32(Console.ReadLine());

int[] array_create = CreateArray(number_array, max_number, min_number);
Console.WriteLine(String.Join(",", array_create));


int count_even = CountEven(array_create);
Console.WriteLine($"Количество четных чисел в массиве - {count_even}.");

Console.WriteLine("Task 3");
ReversMass(array_create);
Console.WriteLine(String.Join(",", array_create));
