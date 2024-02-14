// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
//---------------------------------------------------------------------
//For Döngüsü
//ForLoop();
static void ForLoop()
{
    for (int i = 0; i < 101; i++)
    {
        Console.WriteLine(i);
    }

    for (int i = 100; i >= 0; i = i - 3)
    {
        Console.WriteLine(i);
    }
}
//----------------------------------------------------------------
//While Döngüsü

//WhileLoop();

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
}
//-----------------------------------------------------------------
//Do while Döngüsü
//DoWhileLoop();

static void DoWhileLoop()
{
    int number = 20;
    do
    {
        Console.WriteLine(number);
        number--;
    } while
    (number >= 0);
}
//------------------------------------------------------------------------
//ForEach Döngüsü

//ForEachLoop();

static void ForEachLoop()
{
    string[] cities = { "İstanbul", "İzmir", "Adana", "Konya" };

    foreach (var item in cities)
    {
        Console.WriteLine(item);
    }
}

//----------------------------------------------------------------------
//Örnek Uygulama

Application();

static void Application()
{
    static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }


        }
        return result;
    }
    if (IsPrimeNumber(10))
    {
        Console.WriteLine("This is a prime number");
    }
    else
    {
        Console.WriteLine("This is not a prime number");
    }
}
//--------------------------------------------------------------