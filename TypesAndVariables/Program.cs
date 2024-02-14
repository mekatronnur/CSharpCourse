// See https://aka.ms/new-console-template for more information


//Values Types
Console.WriteLine("Hello, World!");
int number3 = 1000000000;
int number1  = 567;

int number2 = 7;

Console.WriteLine("Toplam:"+ number1+number2);
Console.WriteLine("Number1 is {0}", number1);
int number4 = -2147483647;
Console.WriteLine("Number4 is {0}",number4);
//----------------------------------------------------------
//short

short number6 = -32767;

Console.WriteLine("Number6 is {0}", number6);


//----------------------------------------------------


//long 

long number5 = 2147483647;
Console.WriteLine("Number1 is {0}", number5);

//---------------------------------------------------

//byte

//8 bit yer kaplayan veri tipi
byte number7 = 255;
//0 ile 255 arasında veri tutan veri tipidir.
Console.WriteLine(number7);

//-----------------------------------------------


//boolen

//tuttuğu değer true yada false

bool condition = false;

if (condition != true)
{
    Console.WriteLine("Bu değer true' ye eşit değidir.");
}

//-------------------------------------------------------

//char

char character='a';
Console.WriteLine(character);

Console.WriteLine("Character is :{0}", (int)character);//a değerinin sayısal karşılığı

//------------------------------------------------------

//double -- virgulden sonra 14 -15 tane değer tutar
double number8 = 96.4;
Console.WriteLine("Number8 is {0}", number8);

//---------------------------------------------------------

//decimal -- virgülden sonra 24 -25 tane veri tutar

decimal number9 = 18.5m;

//-----------------------------------------------------

//var

var number10 = 4;

//Ne verdiysek o şekilde devam eder sonradan string değer verirsek bile kabul etmez.
//----------------------------------------------

Console.WriteLine((int)Days.wednesday);

//Enum 
enum Days
{
    Mondoy=10,Tuesday=20,wednesday,Thursday,Friday,Saturday,Sunday
}

//-------------------------------------------------------------------

