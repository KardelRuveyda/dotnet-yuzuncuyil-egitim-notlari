#region 1-) Komut Satırına Yazdırma İşlemleri
Console.WriteLine("Hello World!");
Console.WriteLine(2 + 2);
#endregion

#region 2-) Yorum Satırı İşlemleri
//Yorum Satırı İşlemleri

/*
Console.WriteLine("Test");
Console.WriteLine("Test2");
*/
#endregion

#region 3-) C# Değişkenler 
// Integer bir veri tipi tanımlayalım.
int number = 0;
int age = 21;

Console.WriteLine(number + age);

//Double bir değer tanımlama
double doubleCase = 5.99D;
Console.WriteLine(doubleCase);

//Char veri tipi 
char charValue = 'h';
Console.WriteLine(charValue);

//String değerler 
var name = "Kardel";
string surname = "Çetin";

Console.WriteLine(String.Format("Adı : {0} Soyadı: {1}", name, surname));
Console.WriteLine($"Adı: {name} Soyadı:{surname}");

//Boolean Değerler
bool isActive = false;

//Ternary If Örneği
isActive = name == "Kardel" ? true : false;
string message = isActive ? $"{name} kullanıcısı aktif bir kullanıcıdır. " : $"{name} kullanıcısı pasif bir kullanıcıdır. ";

//Normal If Kullanımı 
if (name == "Kardel")
{
    isActive = true;
}
else
{
    isActive = false;
}

string message2 = "";

if (isActive)
{
    message2 = $"{name} kullanıcısı aktif bir kullanıcıdır. ";
}
else
{
    message2 = $"{name} kullanıcısı pasif bir kullanıcıdır. ";
}

Console.WriteLine(message2);
#endregion

#region 4-) Casting İşlemleri 
//Double bir değeri integera cast etmek
double myValue = 9.83;
int myIntegerValue = (int)myValue;

Console.WriteLine(myIntegerValue);

//Convert
int integerValueCast = 19;
double doubleValueCast = 2.28;
bool myBooleanCast = false;

//Stringe Convert Etme
string intToString = Convert.ToString(integerValueCast);
Console.WriteLine(intToString);

//Convert To Double -> Integer bir değeri Double'a çevirme işlemi 
double intToDouble = Convert.ToDouble(integerValueCast);
Console.WriteLine(intToDouble);
//Convert To Int32 -> Double bir değeri int değere çevirme
int doubleToInt = Convert.ToInt32(doubleValueCast);

//Tablonuzda ID değeri vardır,Ama bu Id Değeri string bir biçimde tutulmuştur. 
//"1203" ( Yüsra ) 
var id = "1203";
int idIntValue = Convert.ToInt32(id);

//Convert Kullanılmadan Stringi integera çevirme işlemi ( Gizem Turan ) 
#region String'i Int Çevirme İşlemi 
int result = 0;
int sign = 1;

string nameString = "234";

//Convert To Int 32 kullanarak String bir değeri Int'e çevirebilirim.
int resultNormal = Convert.ToInt32(nameString);

//String içindeki her karakteri kontrol edebilmek için bir döngüye ihtiyacım var. 
//Döngülerde de kullanabilecekleriniz : for,while,foreach
//Eğer bu hayatı sevmiyorsam aşağıdakini kullanabilirim.

foreach (char c in nameString)
{
    //Eğer karakterim bir sayıdan oluşursa
    if (char.IsDigit(c))
    {
        //Sayıyı bulduktan sonra sonuca ekleme işlemini gerçekleştirelim.
        result = result * 10 + (c - '0');
    }
    else if (c == '-' && result == 0)
    {
        //Eğer karakterlerden bir tanesi "-" ve henüz bir sayı 
        sign = -1;
    }

    //İşaret İşlemlerini Uygulasın 

    result *= sign;
    //Console.WriteLine(result);
}
#endregion
#endregion

#region 5-) Konsolda User Input İşlemleri 
//Konsola aşağıdaki alanı yazdırınız. 
//Console.WriteLine("Kullanıcı adınızı giriniz.");

//Konsola ne yazarsam o değeri alsın ; 
string userName = Console.ReadLine();
//Tekrardan konsola yazdırsın.
//Console.WriteLine($"Konsoldan gelen değer : {userName}");
#endregion

#region 6-) Operatörler

//Aritmetik Operatörler
int resultOperator = 2;

resultOperator *= 4;
resultOperator += 6;
resultOperator -= 1;
resultOperator /= 2;

//Karşılaştırma Operatörleri
//>,>=,<,<=, ==, !=

Console.WriteLine("Operatörler için sayı değeri giriniz.");
string integerValueString = Console.ReadLine();
int integerValue = Convert.ToInt32(integerValueString);

List<string> messageList = new List<string>();

if (integerValue > 7)
{
    messageList.Add("Verilen değer 7'den büyüktür.");
}

if (integerValue >= 7)
{
    messageList.Add("Verilen değer 7'den büyük veye 7'ye eşittir. ");
}

if (integerValue < 8)
{
    messageList.Add("Verilen değer 8'den küçüktür.");
}

if (integerValue <= 8)
{
    messageList.Add("Verilen değer 8'den küçük veya eşittir.");
}

if (integerValue == 12)
{
    messageList.Add("Verilen değer 12'ye eşittir.");
}

if (integerValue != 12)
{
    messageList.Add("Verilen değer 12'ye eşit değildir. ");
}

// Mantıksal Operatörler ( &&, || )

//Konsola girilen sayı 8 ile 12 arasında olsun 

if (integerValue > 8 && integerValue < 12)
{
    messageList.Add("Bu sayı 8 ile 12 arasındadır.");
}

if (integerValue == 8 || integerValue > 8)
{
    messageList.Add("Bu sayı 8'e eşit ya da 8'den büyüktür.");
}

Console.WriteLine(String.Join("\n", messageList));


#endregion

#region 7-) Strings
var firstName = "Kardel";
var secondName = "Rüveyda";

//String birleştirme Türleri 

var nameJoin = firstName + ' ' + secondName;
var nameConcat = string.Concat(firstName, ' ', secondName);
var stringInterpolation = $"Benim adım {firstName} ikinci adım ise {secondName}";
var stringFormat = String.Format("Benim adım {0} ikinci adım ise {1}", firstName, secondName);

Console.WriteLine(nameJoin);
Console.WriteLine(nameConcat);
Console.WriteLine(stringInterpolation);
Console.WriteLine(stringFormat);
#endregion

#region 8-) IF - ELSE Şekilleri 

int value = 3;

//Basit bir if örneği
if (value != 3)
{
    Console.WriteLine("Bu ifade 3 değildir.");
}

//Else-if

if (value != 3)
{
    Console.WriteLine("Bu ifade 3 değildir.");
}
else if (value != 2)
{
    Console.WriteLine("Bu ifade 2 değildir.");
}
else
{
    Console.WriteLine("Bu ifade 2 ya da 3  değildir.");
}

// Normal bir if else örneği 
string messageStringIf = "";

if (value == 2)
{
    messageStringIf = "Bu ifade 2'dir";
}
else
{
    messageStringIf = "Bu ifade 2 değildir.";
}

//Ternary If
messageStringIf = value == 2 ? "Bu ifade 2'dir" : "Bu ifade 2 değildir.";
//Daha karmaşık bir ternary If yazalım .
messageStringIf = value == 2 ? "Buradaki değer 2'dir." : (value < 2 ? "Buradaki değer 2'den küçüktür." : "Buradaki değer 2'den büyüktür.");

//Ternary If'in normal If'e dönüştürülmüş hali
if (value == 2)
{
    messageStringIf = "Buradaki değer 2'dir.";
}
else
{
    if (value < 2)
    {
        messageStringIf = "Buradaki değer 2'den küçüktür.";
    }
    else
    {
        messageStringIf = "Buradaki değer 2'den büyüktür.";
    }
}

#endregion

#region 9-) Switch Case

int switchNumber = 10;

switch (switchNumber)
{
    case 10:
        Console.Write("Bu sayı 10'dur");
        break;
    case 11:
        Console.WriteLine("Bu sayı 11'dir.");
        break;
    default:
        Console.WriteLine("Bu sayı girdiğiniz herhangi bir değerle eşleşmiyor.");
        break;
}

//Switch'i ife çevirirsek.
if (switchNumber == 10)
{
    Console.Write("Bu sayı 10'dur");
}
else if (switchNumber == 11)
{
    Console.WriteLine("Bu sayı 11'dir.");
}
else
{
    Console.WriteLine("Bu sayı girdiğiniz herhangi bir değerle eşleşmiyor.");
}

#endregion

#region 10-) For ve While ile 1000 kere özür dilerim yazdıralım

//For döngüsü
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine("Özür dilerim.");
}

//While Döngüsü

int counter = 0;

while (counter<1000)
{
    Console.WriteLine("Özür dilerim.");
    counter++;
}

#endregion

#region 11-) Foreach Kullanımı
List<int> listIntegers = new List<int>();

listIntegers.Add(1);
listIntegers.Add(2);
listIntegers.Add(3);

foreach (var item in listIntegers)
{
    Console.WriteLine(item);
}
#endregion

#region 12-) Arrays

// Dört elmanlı bir dizi oluşturun ve değerleri sonra ekleyin .
string[] cars = new string[4];

//Dört elemanlı bir dizi oluşturun ve elemanları ekleyin.
cars = new string[4] { "Volvo", "BMW", "Porche", "Nissan" };

//Boyut belirtmeden dört elemanlı bir dizi oluşturabilrisiniz
string[] carsNew = new string[] { "Volvo", "Bmw", "Porche", "Nissan", "Renault" };

//new anahtarı sözcüğünü kullanmadan dizi oluşturabilirsiniz.
string[] carsNew2 = { "Test", "Test1", "Test2" };
#endregion