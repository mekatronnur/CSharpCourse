// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IPersonManager personManager=new CustomerManager();
ProjectManager projectManager=new ProjectManager();
projectManager.Add(personManager);
personManager.Add();
projectManager.Add(new CustomerManager());
 public interface  IPersonManager
{
    void Add();
    
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Added");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        throw new NotImplementedException();
    }
}
//Interface new lenemez

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
      personManager.Add();
    }
}