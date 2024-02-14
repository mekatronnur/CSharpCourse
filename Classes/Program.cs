// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");


CustomerManamger customerManamger = new CustomerManamger();
customerManamger.Add();

Students[] studentsArray = new Students[2];

studentsArray[0] = new Students();
studentsArray[0].Id = 1;
studentsArray[0].Name = "Test";
studentsArray[0].Description = "Test";

studentsArray[1] = new Students();
studentsArray[1].Id = 2;
studentsArray[1].Name = "Nursel";
studentsArray[1].Description = "Test1";

foreach (Students item in studentsArray)
{
  Console.WriteLine(item.Name);
}


Students students = new Students
{
    Id = 1,
    Name = "Test",
    Description = "Test",
};

Console.WriteLine(students.Id);
class CustomerManamger
{
    public void Add()
    {
        Console.WriteLine("Customer Added");

    }

    public void Update()
    {

        Console.WriteLine("Customer Updated");
    }
}

