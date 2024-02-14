// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Intro();

static void Intro()
{
    string city = "Kayseri";

    Console.WriteLine(city[3]);
    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "Sivas";

    string result = city2 + city;

    Console.WriteLine(result);
    Console.WriteLine(String.Format("{0} {1}", city, city2));
}
//---------------------------------------------------------------------

string sentence = "My name is Nursel";

var result = sentence.Length;
Console.WriteLine(result);
var result2=sentence.Clone();//aslında bir tane daha değişken oluşturulmuş oldu.
Console.WriteLine(result2);
bool result3=sentence.EndsWith("w");//sonunda ki harfin yazılan değer ile btip bitmediğini sorgular

Console.WriteLine(result3);

var result4=sentence.IndexOf("name");//buldugu ilk degerı alır
Console.WriteLine(result4);

var result7=sentence.LastIndexOf(" ");//aramaya sondan baslar
Console.WriteLine(result7);

var result8 = sentence.Insert(17, " Hanım");
Console.WriteLine(result8);

var result9 = sentence.Substring(result7 + 1);
Console.WriteLine(result9);

var result6=sentence.Substring(3);
Console.WriteLine(result6);

var result5 = sentence.Substring(3, 4);//3. indexten basla 4 karakter al

var result12 = sentence.Replace(" ", "**");
Console.WriteLine(result12);


var result13=sentence.Remove(3,4);
Console.WriteLine(result13);