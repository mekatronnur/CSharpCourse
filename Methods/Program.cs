// See https://aka.ms/new-console-template for more information
//---------------------------------------------------


//Parametreli Methodlar
Console.WriteLine("Hello, World!");

Console.WriteLine("Bir sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir sayı daha giriniz");
int number1 = Convert.ToInt32(Console.ReadLine());

//------------------------------------------------------
//Method Çağırma

Add(number, number1);
Write();
Add2();
var result =(Multiply( ref number, number1));

Console.WriteLine(result);
Console.WriteLine(Add4(1, 34, 56));
Console.WriteLine(Add5(23, 45, 45));
//-----------------------------------------------------------
static void Add(int number, int number1)
{

    Console.WriteLine("Toplam:" + (number + number1));

}


//----------------------------------------------------
//Parametresiz Methodlar
static void Write()
{
    Console.WriteLine("Merhaba");
}
//----------------------------------------------

//Default Parametreli Methodlar

static int Add2(int number=23, int number1 = 23)
{
    var result = number + number1;
    Console.WriteLine(result);
    return result;
}

//---------------------------------
static int Add3(int number,int number1)
{
    return number + number1;
}
//ref --out----------------------------

//ref mutlaka bir deger set edilmıs olması gerekıyor outta ref set etmeye gerek yok
//---------------------------------------------------------

static int Multiply(ref int number,int number1)
{
    number = 70;
    var result = number * number1;
    return result;    
}
//-------------------------------------------------------

//Method Overloading--aşırı yükleme



//static int Multiply1(int number1,int number2)
//{
//    return  number1 * number2;
//}
//static int Multiply1(int number1, int number2, int number3)
//{
//    return number1 * number2 * number3;
//}
//---------------------------------------------------------------------
//params kullanımı
static int Add4(params int[] numbers)
{
    return numbers.Sum();

}


static int Add5(int number,params int[] numbers){
    return numbers.Sum();   
}
//-------------------------------------------------------------------