Console.WriteLine("Выберите задачу: 1, 2, 3, 4");
int num_task = Convert.ToInt32(Console.ReadLine());
switch (num_task)
{
    case 1:
        FirstTask();
        break;
    case 2:
        SecondTask();
        break;
    case 3:
        ThirdTask();
        break;
    case 4:
        FourthTask();
        break;
}

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
void FirstTask()
{
    Console.WriteLine("Программа, которая принимает,на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("кратно одновременно 7 и 23");
    }
    else
    {
        Console.WriteLine("нет, не кратно одновременно 7 и 23");
    }
}

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
void SecondTask()
{
    Console.WriteLine("Программа, , которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.");
    Console.Write("x = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x != 0 && y != 0)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("I четверть");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("II четверть");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("III четверть");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("IV четверть");
        }
    }
    else
    {
        Console.WriteLine("Не соответствие условиям задачи - X ≠ 0 и Y ≠ 0");
    }
}

//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
void ThirdTask()
{
    Console.WriteLine("Программа, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.");
    int num = new Random().Next(10, 99);
    int max_num;
    if (num / 10 >= num % 10)
    {
        max_num = num / 10;
    }
    else
    {
        max_num = num % 10;
    }
    Console.WriteLine($"Наибольшей цифрой числа - {num}, является - {max_num}");
}

//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
void FourthTask()
{
    Console.WriteLine("Программа, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.");
    int i = 1, N = new Random().Next(), digitCount = (int)Math.Log10(N) + 1;
    Console.WriteLine($"{N}");
    while (i < digitCount + 1){
        if (i == digitCount) {
            Console.Write($"{(int)(N / Math.Pow(10,digitCount - i) % 10)}");
        } else {
            Console.Write($"{(int)(N / Math.Pow(10,digitCount - i) % 10)}, ");
        }
        i++;
    }
}