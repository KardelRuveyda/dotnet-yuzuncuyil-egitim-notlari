#region Methodlar
//Metotları ve Classları çağırdığım kısım
HelloWorld();
MyMethod("Kardel", "Çetin");
IsMarried("Havva");
IsMarried("Gizem");
IsMarried("Hatice");
IsMarriedInteger("Havva");
CarFeatures();
SpecialCarConsole();
animalSoundFeatures();
animalSoundFeatures2();
abstractClassTest();
TryCatchMethod();
Throw(23);
//Void Metotu : Geri dönüş değeri olmayan fonksiyonlardır. 
//Response-> Yazdığımız metottan bize geri döner değelerdir. (List,string,boolean,int,object)
void HelloWorld()
{
    Console.WriteLine("Hello World");
}
//Geri dönüş değeri olmasın ama parametreli olsun. (FirstName,Age)

void MyMethod(string firstName, string lastName)
{
    Console.WriteLine($"Benim adım {firstName}, soyadım da {lastName}");
}

//Boolean bir değer döndürsün. Eğer Gizem ve Kardel'i yazarsak bekar, Havva'yı evli olacak. 
bool IsMarried(string name)
{
    bool isMarried = false;
    if (name == "Havva" || name == "Hatice")
    {
        isMarried = true;
    }
    else
    {
        isMarried = false;
    }

    //Ternary If
    //isMarried = (name == "Havva" || name == "Hatice") ? true : false;
    string message = isMarried ? $"{name} evlidir." : $"{name} evli değildir.";
    Console.WriteLine(message);
    return isMarried;
}

//integer bir değer döndürecek metot yazınız. 
int IsMarriedInteger(string name)
{
    int isMarried = 0;
    if (name == "Havva" || name == "Hatice")
    {
        isMarried = 1;
    }
    else
    {
        isMarried = 1;
    }

    //Ternary If
    //isMarried = (name == "Havva" || name == "Hatice") ? true : false;
    string message = isMarried == 1 ? $"{name} evlidir." : $"{name} evli değildir.";
    Console.WriteLine(message);
    return isMarried;
}

Car CarFeatures()
{
    //Birinci Yazım Şekli
    Car car = new Car();
    car.year = 2014;
    car.color = "red";
    car.model = "Nissan";

    //İkinci Yazım Şekli
    Car car2 = new Car
    {
        color = "red",
        model = "Nissan",
        year = 2013
    };

    return car2;
}

Fruit FindFruitName(string fruitName, string fruitName2)
{
    Fruit fruit = new Fruit(fruitName, fruitName2);

    Console.WriteLine($"Birinci meyvenin ismi {fruit.fruitName}, ikinci meyvenin ismi {fruit._fruitName2}");

    return fruit;
}

void SpecialCarConsole()
{
    SpecialCar specialCar = new SpecialCar();

    specialCar.carTest();
}

void animalSoundFeatures()
{
    Animal myAnimal = new Animal();
    Animal myCat = new Cat();
    Animal myDog = new Dog();

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
}

void animalSoundFeatures2()
{
    Animal2 myAnimal = new Animal2();
    Animal2 myCat = new Cat2();
    Animal2 myDog = new Dog2();

    myAnimal.animalSound();
    myCat.animalSound();
    myDog.animalSound();
}

void abstractClassTest()
{
    Snake snake = new Snake();
    //Animal3 abstractNew = new Animal3(); // abstract classlar new-lene-mez.

    snake.animalSound(); // Abstract Class çağrıldı. 
    snake.sleep(); // Basit bir metotun çağrılması. 
}

void InterfaceClassTest()
{
    Bird bird = new Bird();
    bird.animalSound();
}

void MultipleInterfaceClassTest()
{
    Demo demo = new Demo();
    demo.myMethod();
    demo.mySecondMethod();
}

void setRole()
{
    Level normal = Level.Normal;
    Level admin = Level.Admin;
    Level intern = Level.Intern;
}



#region Try Catch
void TryCatchMethod()
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
    if (age > 18 && age < 25)
    {
        throw new ArithmeticException("Access denied.");
    }else
    {
        Console.WriteLine("Acces granted");
    }
}
#endregion
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
    public string fruitName;
    public string _fruitName2;

    public Fruit(string fruitName, string fruitName2)
    {
        this.fruitName = fruitName;
        _fruitName2 = fruitName2;
    }

}
#endregion

#region Inheritence(Kalıtım)
class Vehicle //base clas ( parent ) 
{
    public string brand = "Renault";

    public void carTest()
    {
        Console.WriteLine("Bu bir testtir. Vehicle Parent, SpecialCar Child.");
    }
}

class SpecialCar : Vehicle //derived class ( child ) 
{
    public string modelName = "Mustang"; // Special Car Field
}
#endregion

#region Polimorfizm 1
class Animal // Base clas ( parent ) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Cat : Animal // Child ( Derived Class )
{
    public void animalSound()
    {
        Console.WriteLine("The cat says: miyav");
    }
}

class Dog : Animal //Child ( Derived Class ) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: hav");
    }
}

#endregion

#region Polimorfizm 2 ( Virtual ve Override Kullanımı) 
class Animal2 // Base clas ( parent ) 
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Cat2 : Animal2 // Child ( Derived Class )
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: miyav");
    }
}

class Dog2 : Animal2 //Child ( Derived Class ) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: hav");
    }
}
#endregion

#region C# Abstraction
abstract class Animal3
{
    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Animal is sleeping...");
    }
}

class Snake : Animal3 //Derived classs ( inherit from Animal3
{
    public override void animalSound()
    {
        //The body of animalSound() is provided here.
        Console.WriteLine("The snake is SsSsSsSsS ");
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
        Console.WriteLine("The bird is cikcik");
    }
}

//Multiple Interfeace
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
       Console.WriteLine("This is myMethod.");
    }

    public void mySecondMethod()
    {
        Console.WriteLine("This is mySecondMethod.");
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

