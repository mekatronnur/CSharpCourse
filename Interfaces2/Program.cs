// See https://aka.ms/new-console-template for more information
using Interfaces2;

Console.WriteLine("Hello, World!");

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerDal());

ICustomerDal[] customerDal = new ICustomerDal[2]
{
    new OracleCustomerDal(),
    new SqlServerCustomerDal(),
};
foreach (var item in customerDal)
{
    item.Add();
}

Iperson ıperson = new Customer
{
    Id = 1,
};


interface Iperson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Description { get; set; }


}

class Customer:Iperson
{
 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Description { get; set; }
    public string Adress { get; set; }
}

class Student : Iperson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Description { get; set; }
    public string Section { get; set; }
}