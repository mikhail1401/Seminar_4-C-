// Funtctions
// Syntax:
// dataType Name()

Console.WriteLine("Task 24");
// Напишите программу, которая принимает на вход число (А) и 
// выдает сумму чисел от 1 до А.
// 7 -> 28      4 -> 10     8 -> 36

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int sum = 0;
    int count = 0;

    while(count<=num)
    {
        // sum = sum + count;
        sum+=count;
        count++;
    }
    return sum;
}

int result = GetSumNum();
Console.WriteLine(result);


Console.WriteLine("\nTask26");
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Option 1");
// Option 1
int DigitCount(int number)
{
    int totalDigits = 0;

    if(number>0 && number<10)
    {
        totalDigits = 1;
    }
    else if(number>=10 && number<100)
    {
        totalDigits = 2;
    }
    else if(number>=100 && number<1000)
    {
        totalDigits = 3;
    }
    else if(number>=1000 && number<10000)
    {
        totalDigits = 4;
    }
    else if(number>=10000 && number<100000)
    {
        totalDigits = 5;
    }

    return totalDigits;
}

Console.Write("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitCount(number1));

Console.WriteLine("Option 2");
// Option 2
int DigitCount2(int number2)
{
    int count = 0;

    while(number2>0)
    {
        number2 = number2/10;
        count++;
    }
    return count;
}

Console.Write("Enter a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitCount2(number2));


Console.WriteLine("\nTask 28");
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter a nubmer: ");
int number28 = Convert.ToInt32(Console.ReadLine());

int ProductOfNumbers()
{
    int multi = 1;

    for (int i = 1; i<=number28; i++)
    {
        multi = multi * i;
    }
    return multi;
}

int result28 = ProductOfNumbers();
Console.WriteLine(result28);


Console.WriteLine("\nTask 30");
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int [8];
GetArray();     // apparently a function can be called before its declaration

void GetArray()
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i]+" "); 
    }
}

