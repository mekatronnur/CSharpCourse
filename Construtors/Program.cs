// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer Customers = new Customer();
Customer customer1 = new Customer(2, "Nursel", "Düzdar", "Kayseri");

Customer customer2 = new Customer
{
    Id = 1,
    FirstName = "mERVE",
    LastName = "dENİZ",
    City = "kAYSERİ"
};
class Customer
{
    //Default Constructor
    public Customer()
    {

    }


    public Customer(int id, string _FirstName, string _LastName, string _city)
    {
        Id = id;
        FirstName = _FirstName;
        LastName = _LastName;
        City = _city;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}