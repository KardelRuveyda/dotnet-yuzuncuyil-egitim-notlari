Customer customer = new Customer { City = "Trabzon", FirstName = "Kardel", Id = 1, LastName = "Çetin" };
Console.WriteLine(customer.FirstName);

//Customer customer2 = customer.Clone();
//Customer customer2 = (Customer)customer;

//Customer 1 ve Customer2 aynı nesneler değil
//Aynı referansları tutmuyor.
//Yeni referans oluşturma maliyetinden kurtarılır. 
var customer2 = customer.Clone();
customer2.FirstName = "Rüveyda";

Console.WriteLine(customer.FirstName);
Console.WriteLine(customer2.FirstName);

public abstract class Person
{
    public abstract Person Clone();
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Customer : Person
{
    public string City { get; set; }

    public override Person Clone()
    {
        //Dotnet de karşılaştırabiliyoruz. 
        return (Person)MemberwiseClone();
    }
}

public class Employee: Person
{
    public decimal salary { get; set; }

    public override Person Clone()
    {
        return (Employee)MemberwiseClone();
    }
}