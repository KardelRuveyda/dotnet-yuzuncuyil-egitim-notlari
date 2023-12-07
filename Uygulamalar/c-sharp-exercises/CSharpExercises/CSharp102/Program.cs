#region Kodların Çalıştırıldığı Kısım
HelloWorld();
MyMethod("kardel", "çetin");
IsMarried("Alex");
IsMarried("Jane");
IsMarriedRefactor("Alex");
IsMarriedInteger("Frank");
CarFeatures();
FindFruitName("elma");
SpecialCarConsole();
animalSoundFeatures();
animalSoundFeatures2();
abstractClassTest();
InterfaceTest();
MultipleInterfaceTest();
TryCatchMethod();
TryCatchMethodFinally();
Throw(20);
#endregion

#region Metotlar 
//Void Metotu: Geri dönüş değeri olmayan fonksiyonlardır. 
//Response -> Yazdığımız metotların geri dönüş değerleri olarak adlandırılır. 
//(int,list,string,boolean,object vb.)
void HelloWorld()
{
    Console.WriteLine("Hello World");
}

//Metotun gene geri dönüş değeri olmasın. 
// İki adet parametre alsın, firstName ve lastName

void MyMethod(string firstName, string lastName)
{
    Console.WriteLine($"Benim adım {firstName}, soyadım ise {lastName}");
}

//Boolean bir değer döndürsün. 
//Alex ise kişi evli , Alex değilse evli değil. 

bool IsMarried(string name)
{
    bool isMarried = false;
    string message = "";
    if (name == "Alex")
    {
        isMarried = true;
    }
    else
    {
        isMarried = false;
    }

    if (isMarried)
    {
        message = $"{name} evlidir. ";
    }
    else
    {
        message = $"{name} evli değildir.";
    }

    Console.WriteLine(message);

    return isMarried;
}

//IsMarried Refactor edilmiş hali 
bool IsMarriedRefactor(string name)
{
    //Ternary If
    bool isMarried = name == "Alex" ? true : false;
    string message = isMarried ? $"{name} evlidir." : $"{name} evli değildir.";
    Console.WriteLine(message);
    return isMarried;
}
//interger bir değer döndürecek metot yazalım. 
int IsMarriedInteger(string name)
{
    //Ternary If
    int isMarried = name == "Alex" ? 1 : 0;
    string message = isMarried == 1 ? $"{name} evlidir." : $"{name} evli değildir.";
    return isMarried;
}

//Arabanın özelliklerini getiren bir metot yazalım. 
Car CarFeatures()
{
    //Birinci Yazım şekli 
    Car car = new Car();
    car.year = 2014;
    car.color = "black";
    car.model = "Renault";

    //İkinci yazım şekli
    Car car2 = new Car
    {
        color = "red",
        model = "Nissan",
        year = 2012
    };

    Console.WriteLine(car.year);
    Console.WriteLine(car.model);
    ; return car2;
}

Fruit FindFruitName(string fruitName)
{
    Fruit fruit = new Fruit(fruitName);

    Console.WriteLine($"Meyvenin ismi {fruit._fruitName}");

    return fruit;
}

//Special Car Testi için
void SpecialCarConsole()
{
    SpecialCar specialCar = new SpecialCar();
    specialCar.CarTest();
}
#endregion
//Polimorfizm 1 örneğinin çalıştırılması. 
void animalSoundFeatures()
{
    Animal myAnimal = new Animal();
    Animal myCat = new Cat();
    Animal myDog = new Dog();

    myCat.animalSound();
    myDog.animalSound();
}

//Polimorfizm 2 örneğinin çalıştırılması. 
void animalSoundFeatures2()
{
    Animal2 myAnimal = new Animal2();
    Animal2 myCat = new Cat2();
    Animal2 myDog = new Dog2();

    myCat.animalSound();
    myDog.animalSound();
}

//abstract metotunun test edilmesi 
void abstractClassTest()
{
    Snake snake = new Snake();
    //Animal3 animal3 = new Animal3(); // abstract classlar new-le-ne-mez.

    snake.animalSound();
    snake.sleep();
}
//Interface örneklerini test etmek için 
void InterfaceTest()
{
    Bird bird = new Bird();
    bird.animalSound();
}

void MultipleInterfaceTest()
{
    Demo demo = new Demo();
    demo.myMethod();
    demo.mySecondMethod();
}
//enum örneği
void setRole()
{
    Level normal = Level.Normal;
    Level admin = Level.Admin;
    Level intern = Level.Intern;

    Console.WriteLine(normal);
    Console.WriteLine(admin);
    Console.WriteLine(intern);
}

#region Try Cath Methodu
void TryCatchMethod()
{
    try
    {
        //hata alabilecek bir kod
        int[] myNumbers = { 1, 2, 3 };
        Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void TryCatchMethodFinally()
{
    try
    {
        // hata alabilecek kod yazılır.
        int[] myNumbers = { 1, 2, 3 };
        Console.WriteLine(myNumbers[10]);
    }
    catch (Exception e)
    {
        // hata alınırsa buraya düşer.
        Console.WriteLine("Something went wrong");
    }
    finally
    {
        Console.WriteLine("The try catch is finished.");
    }
}

void Throw(int age)
{
    if(age > 18 && age < 25)
    {
        throw new ArithmeticException("Access is denied");
    }
    else
    {
        Console.WriteLine("Access granted.");
    }
}
#endregion
#region Classlar
class Car
{
    public int? year { get; set; }
    public string model { get; set; }
    public string color { get; set; }
}

class Fruit
{
    public string _fruitName;

    public Fruit(string fruitName)
    {
        _fruitName = fruitName;
    }
}
#endregion

#region Inheritence(Kalıtım)
class Vehicle // base clas 
{
    public string _brand = "Nissan";

    public void CarTest()
    {
        Console.WriteLine($"Bu bir testtir.");
    }
}

class SpecialCar : Vehicle
{
    public string modelName = "Renault"; // Special Car Field.
}
#endregion

#region Polimorfizm 1 ( İstenen Senaryo olmayan kısmı)
class Animal //Base Class
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat:Animal
{
    public void animalSound()
    {
        Console.WriteLine("The cat says: miyav");
    }
}

class Dog : Animal
{
    public void animalSound()
    {
        Console.WriteLine("The dog says : hav hav");
    }
}
#endregion

#region Polimorfizm 2 ( Virtual ve Override Kullanımı )
class Animal2 //Base Class
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat2 : Animal2
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: miyav");
    }
}

class Dog2 : Animal2
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says : hav hav");
    }
}
#endregion

#region C# Abstraction 
abstract class Animal3 //baseclass
{
    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

class Snake : Animal3 // Inherit edilmiş class ( miras alınmış class)
{
    public override void animalSound()
    {
        Console.WriteLine("The snake is SsSsSSs");
    }
}
#endregion

#region Interface
//Tek Interface Örneği

interface IAnimal
{
    void animalSound();
}

class Bird : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The bird is cik cik.");
    }
}

//Multiple Interface
interface IFirstInterface
{
    void myMethod();
}

interface ISecondInterface
{
    void mySecondMethod();
}

class Demo : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Bu birinci metottur.");
    }

    public void mySecondMethod()
    {
        Console.WriteLine("Bu ikinci metottur.");
    }
}

#endregion

#region Enums
enum Level
{
    Admin,
    Normal,
    Intern
}
#endregion
