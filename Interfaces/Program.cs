// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
PersonManager personManager = new PersonManager();
personManager.Add(new Customer
{
    Id = 1,
    FirstName = "Test",
    LastName = "Test",
    Adress="Test"
    
});
Customer customer1 = new Customer
{
    Id = 2,
    FirstName = "Test2",
    LastName = "Test2",
    Adress = "Test"
};

personManager.Add(customer1);
interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress {  get; set; }
}

class Student : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Section { get => throw new NotImplementedException();set => throw new NotImplementedException(); }

}
class PersonManager
{
    public void Add(Customer customer)
    {
        Console.WriteLine(customer.FirstName + " " + customer.LastName);
    }
}