https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sayi1 = 10;
int sayi2 = 20;
sayi2 = 100;
sayi1 = sayi2;

Console.WriteLine("Sayi1:" + sayi1);

//int decimal float enum boolen:value types

int[] numbers = new int[] { 1, 3, 4, 5 };
int[] numbers2 = new int[] { 10, 45, 34 };
numbers = numbers2;
numbers2[0] = 43;

Console.WriteLine("Sayılar[0]:" + numbers[0]);

Person person = new Person();
Person person1 = new Person();
person.Name = "nuR";
person1 = person;

person.Name = "nURSEL";
Console.WriteLine(person1.Name);

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string  LastName { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber {  get; set; }   
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}