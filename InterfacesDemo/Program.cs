// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Iworker[] workers = new Iworker[2]
{
    new Manager(),
      new Robot(),
};
foreach (var item in workers)
{
    item.Work();
}

interface Iworker
{
    void Work();
}
interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}
class Manager : Iworker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("çalıştı");
    }
}

class Worker : Iworker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        Console.WriteLine("çalıştı");
    }
}
class Robot : Iworker
{
    public void Work()
    {
        Console.WriteLine("çalıştı");
    }
}