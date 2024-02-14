// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//if else bloğu

var number = 11;

if (number == 10)
{
    Console.WriteLine("Number is 10");
}

else
{
    Console.WriteLine("Number is not 10 , Number is:" + number);
}
Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");//single line if ile çalışmak


//------------------------------------------------------------------------------------

//if else if bloğu
Console.WriteLine("Bir kulllanıcı adı giriniz");
var word = Console.ReadLine();

if (word == "Nursel")
{
    Console.WriteLine("Kullanıcı adı:" + word);
}
else if (word == "Merve")
{
    Console.WriteLine("Kullanıcı adı:" + word);
}
else
{
    Console.WriteLine("Kullanıcı Adı Hatalıdır.");
}

//--------------------------------------------------------------------------------------

//Switch bloğu ile çalışmak 

switch (number)
{
    case 10:
        Console.WriteLine("Bu sayı 10 durr");
        break;

    case 11:
        Console.WriteLine("Bu sayı 11 dir");
        break;
    default:
        Console.WriteLine("Bu sayı 10 veya 11 değidir")
  ; break;
}

//-----------------------------------------------------------------------------------------

//Örnek

Console.WriteLine("Bir sayı giriniz");

var number1=Convert.ToInt32(Console.ReadLine());

if (number1 >= 10 && number1 <= 20)
{
    Console.WriteLine("Toplam:" + number1 + number);
}

else if (number1 >50 && number1 <= 67)
{
    Console.WriteLine("Çıkartma:" + (number - number1));
}
else if(number1>=100 || number1 >=200)
{
    Console.WriteLine("Sayı:" + number1);
}
else
{
    Console.Write("Girilen sayı bu değer aralıklarında değildir.");
}
//----------------------------------------------------------------------------------------------