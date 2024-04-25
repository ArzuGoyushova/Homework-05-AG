#region 3 taskda userden input almaq uchun metod
int[] AskUserInput(int numberOfInputs)
{
    bool validInput = false;
    int[] inputs = new int[numberOfInputs];

    while (!validInput)
    {
        try
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                if (i == 0)
                {
                    Console.Write("Birinci eded: ");
                }
                else
                {
                    Console.Write("Ikinci eded: ");
                }
                inputs[i] = int.Parse(Console.ReadLine());
            }
            validInput = true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Zehmet olmasa duzgun eded daxil edin:");
        }
    }
    return inputs;
}
#endregion

#region Task1
//İki ədəd arasında olan ədədlərin cəmini ekrana çıxarın. (Parametrsiz return metodu ilə) 

Console.WriteLine("Task 1. 2 eded arasindaki ededlerin cemini tapin:");
Console.WriteLine($"Cem: {SumBetweenNumbers()}");

int SumBetweenNumbers()
{
    int sum = 0;
    int [] nums = AskUserInput(2);
    int low = Math.Min(nums[0], nums[1]);
    int high = Math.Max(nums[0], nums[1]);

    for (int i = low + 1; i < high; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine("*****************************************************************************");
Console.WriteLine();
#endregion

#region Task2
//Bir ədədin qüvvətini ekrana çıxarın. Məsələn, 2^3 = 8.
//(Parametrli return metodu ilə). Ədədləri istifadəçi daxil etsin. 

Console.WriteLine("Task 2. Eded ve quvvetini daxil edin:");

int[] nums = AskUserInput(2); 
Console.WriteLine($"{nums[0]}^{nums[1]}={PowerOfNumber(nums[0], nums[1])}");

int PowerOfNumber(int number, int power)
{
    int mult = number;
    for (int i = 0; i < power-1; i++)
    {
       number *= mult;
    }
    return number;
    //Math.pow(number, power) de olar
}
Console.WriteLine();
Console.WriteLine("*****************************************************************************");
Console.WriteLine();
#endregion

#region Task3
//İstifadəçi tərəfindən daxil edilən ədədə qədər Fibonacci ardıcıllığını parametrli return metodu ilə ekrana çıxarın.
//Məsələn istifadəçi 5 daxil etdikdə 0 1 1 2 3 5 alsın. 

Console.WriteLine("Task 3. Fibonacci siralamasi uchun eded daxil edin:");

int[] fibArray = Fibonacci(AskUserInput(1)[0]);
Console.WriteLine(string.Join(", ", fibArray));

int[] Fibonacci(int number)
{
    if (number <= 0)
    {
        return new int[0]; 
    }

    int[] fib = new int[number+1];
    fib[0] = 0;

    if (number > 1)
    {
        fib[1] = 1;
        for (int i = 2; i <= number; i++)
        {
            fib[i] = fib[i - 2] + fib[i - 1];
        }
    }
    return fib;
}
#endregion