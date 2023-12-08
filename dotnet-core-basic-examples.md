# Temel örneklerle Dotnet Core

## Entity Framework Core Nedir?
Entity Framework Core (EF Core), Microsoft tarafından geliştirilen, .NET platformu için bir nesne ilişkisel eşleme (Object-Relational Mapping, ORM) framework'üdür. ORM, veritabanıyla nesne tabanlı programlama arasındaki uyumu sağlamak amacıyla kullanılır. Entity Framework Core, özellikle .NET Core ve .NET 5 gibi çeşitli .NET platformlarında çalışabilen hafif ve açık kaynaklı bir ORM çözümüdür.

Entity Framework Core, .NET uygulamalarının veritabanlarıyla etkileşimde bulunmasını kolaylaştırmak için kullanılır. Bu framework sayesinde, veritabanındaki tabloları, sütunları ve ilişkileri nesne modelleriyle eşleştirebilirsiniz. Bu sayede, veritabanı işlemlerini SQL sorguları yazmak yerine nesne yönelimli bir yaklaşımla gerçekleştirebilirsiniz.

_EF Core'un temel özellikleri arasında şunlar bulunur:_

- **Code First Yaklaşımı:** Veritabanı şemalarını kodunuzdaki sınıflara dayalı olarak oluşturmanızı sağlar. Kod tarafında sınıfları tanımlayarak, EF Core otomatik olarak veritabanını oluşturabilir.
- **Migration Desteği:** Veritabanındaki şemada yapılan değişiklikleri takip edebilmeniz ve bu değişiklikleri uygulayabilmeniz için migration (geçiş) mekanizması sunar.
- **LINQ Desteği:** LINQ (Language Integrated Query) kullanarak veritabanına sorgular yazabilirsiniz. Bu, SQL sorguları yazmak yerine daha okunabilir ve yönetilebilir sorgular oluşturmanıza olanak tanır.
- **Çeşitli Veritabanı Motorları Desteği:** EF Core, çeşitli veritabanı motorlarına uyumlu olarak çalışabilir. Microsoft SQL Server, PostgreSQL, MySQL, SQLite gibi popüler veritabanlarına destek sağlar.
- **Performans İyileştirmeleri:** EF Core, performansı artırmak ve gereksiz sorguları önlemek için çeşitli optimizasyonlar içerir.

Entity Framework Core, geliştiricilere veritabanı işlemlerini basitleştirmek ve daha az kod yazarak veritabanıyla etkileşimde bulunmalarını sağlamak için güçlü bir araç sunar.

## Adım adım Codefirst

# Entity Framework Core Code First Örneği

Bu proje, Entity Framework Core'un Code First yaklaşımını kullanarak basit bir öğrenci-sınıf ilişkisini simgeliyor.

## Yüklenen Paketler
 Entity Framework Core ve SQL Server paketlerini ekleyin:
    ```bash
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    ```
    - Entity Framework Core ve SQL Server için gerekli paketler eklenir.

## Kod Örnekleri

### Model Sınıfları

Öğrenci ve Sınıf model sınıfları örnek:

#### Student.cs
```csharp
public class Student
{
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
}
```
#### AppDbContext.cs
```csharp
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
        }
    }
```

#### Program.cs
```csharp
// See https://aka.ms/new-console-template for more information
using EntityFrameworkCore.Models;
using EntityFrameworkCoreExample.DataContext;



using (var context = new AppDbContext())
{
    //INSERT
    var student = new Student()
    {
        Email = "ruveydakardelcetin@gmail.com",
        FirstName = "Kardel",
        LastName = "Ruveyda",
        Telephone = "5305153061"
    };

    context.Students.Add(student);
    context.SaveChanges();
    Console.WriteLine("Veri tabanına başarılı bir şekilde eklendi!");
    Console.ReadLine();

    //Tolist

    var students = context.Students.ToList();

    foreach (var item in students)
    {
        Console.WriteLine(String.Join("Öğrenci adı : {0}", item.FirstName));
        Console.ReadLine();
    }

    ////UPDATE
    var studentUpdate = context.Students.Where(x => x.Id == 1).FirstOrDefault();

    if (studentUpdate != null)
    {
        studentUpdate.FirstName = "Aynur";
        studentUpdate.LastName = "Katırcıoğlu";

        context.Update(studentUpdate);
        context.SaveChanges();

        Console.WriteLine("Veri tabanına başarılı bir şekilde güncellendi");
        Console.ReadLine();
    }

    //Delete İşlemi 

    List<int> removeListIds = new List<int>();

    removeListIds.Add(2);
    removeListIds.Add(3);

    bool isRemoved = false;
    string message = "Bir hata oluştu";
    try
    {
        foreach (var item in removeListIds)
        {
            var studentDelete = context.Students.Where(x => x.Id == item).FirstOrDefault();
            if (studentDelete != null)
            {
                context.Students.Remove(studentDelete);
                context.SaveChanges();
                isRemoved = true;
                message = "Silme işlemi başarılı.";
            }
        }
    }
    catch (Exception)
    {

        isRemoved = false;
    }


    if (isRemoved)
    {
        var studentNew = context.Students.Where(x => x.Id == 1).FirstOrDefault();

        if (studentNew != null)
        {
            studentNew.FirstName = "Test";
            studentNew.LastName = "Test2";
            studentNew.Email = "test3@gmail.com";
            studentNew.Telephone = "2124444444";

            context.Students.Update(studentNew);
            context.SaveChanges();

            message = "Hem silme hem güncelleme işlemi gerçekleşti.";
            isRemoved = true;
        }
    }
    Console.WriteLine(message);
    Console.ReadLine();
}
```




