// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string students = "Nursel";
string students2 = "Merve";
string students3 = "Zeynep";


string[] student = new string[3];

string[] student2 = new[] {"Engin","Nusel","Merve"} ;
student[0] = "Nursel";
student[1] = "Merve";
student[2] = "Zeynep";

foreach (var item in student)
{
    Console.WriteLine(item);
}

string[,] regions = new string[5, 3]
{
{ "Ankara","Konya","Kayseri"},
{ "Trabzon","Samsun","Ordu"},
{ "Antalya","Mersin","Isparta"},
{ "İzmir","Aydın","Muğla"},
{ "erzurum","van","ağrı"},


};
for(int i = 0; i <= regions.GetUpperBound(0); i++)
{
   for(int j = 0; j <=regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
}