#region Çalıştırılması
Customer customer1 = new Customer
{
    City = "Lüleburgaz",
    FirstName = "Hatice",
    LastName = "Beyaz"
};

Console.WriteLine(customer1.FirstName);

Customer customer2 = new Customer();
customer2.LastName = "Çetin";

Console.WriteLine(customer2.LastName);

var customer3 = customer1.Clone();
customer3.FirstName = "Kardel";

//İkisi farklıdır.
Console.WriteLine(customer3.FirstName);
Console.WriteLine(customer1.FirstName);

/*
    Bu bölümde, customer nesnesinin bir kopyası olan customer2 oluşturuluyor. 
    Clone metodu sayesinde bir nesnenin derin kopyası alınıyor. Ardından, 
    customer2'nin FirstName özelliği değiştiriliyor, ancak customer'ın 
    FirstName özelliği değiştirilmiyor. Bu durum, 
    kopyalanan nesnenin bağımsız bir kopyası olduğunu gösterir.*/ 

#endregion

#region Abstract Person Class Oluşturulması
public abstract class Person
{
    public abstract Person Clone();
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
#endregion

#region Person'dan türeyen bir Customer
//Bu bölümde, Person adında soyut bir sınıf tanımlanmıştır. Bu sınıfın 
//    soyut metodu olan Clone, türetilen sınıflar tarafından uygulanacak 
//    ve derin kopya oluşturulmasını sağlayacaktır.


//Bu bölümde, Person sınıfından türeyen Customer sınıfı tanımlanmıştır. 
//Bu sınıf, Person sınıfındaki soyut Clone metodu uygulamış ve bu metodun
//içinde MemberwiseClone metodunu kullanarak derin kopya oluşturulmasını sağlamıştır.
public class Customer : Person
{
    public string City { get; set; }

    //Person'u Clone etme MemberWiseClone
    public override Person Clone()
    {
        //Dotnet de karşılaştırabiliyoruz. 
        return (Person)MemberwiseClone();
    }
}

#endregion


#region Person'dan türeyen bir Employee
//Bu bölümde de, Person sınıfından türeyen Employee sınıfı tanımlanmıştır.
//   Person sınıfındaki soyut Clone metodu burada implemente edilmiş ve yine 
//    MemberwiseClone   metodu kullanılarak derin kopya oluşturulmuştur.
public class Employee: Person
{
    public decimal salary { get; set; }

   //Person'u clone etme
    public override Person Clone()
    {
        return (Employee)MemberwiseClone();
    }
}
#endregion

//Bu örnekte, prototip (prototype) tasarım deseni kullanılarak nesnelerin 
//    derin kopyalarının alınması sağlanmıştır. MemberwiseClone metodunun kullanımı, 
//    nesnenin alanlarını kopyalamak için .NET tarafından sağlanan bir kolaylıktır.
//    Bu şekilde, aynı türden yeni nesneler oluşturabilir 
//    ve bu nesneleri orijinal nesnenin durumuyla başlatabilirsiniz.
