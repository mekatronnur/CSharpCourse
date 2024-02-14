// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer = new Customer();
customer.Name = "Test";
Person[] person = new Person[2]
{
     new Customer
     {
         Name = "Test",
     },
   new Student
   {
       LastName = "Test",
   }
};
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }  
}

class Customer : Person
{
    public string City { get; set; }    

}
class Student : Person
{
    public string Departmant { get; set;}
}