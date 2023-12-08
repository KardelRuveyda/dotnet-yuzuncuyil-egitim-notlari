// Bir CustomerManager örneği oluşturuluyor ve bu örneğe bir Factory1 örneği enjekte ediliyor.
CustomerManager customerManager = new CustomerManager(new Factory1());

// CustomerManager sınıfının GetAll metodu çağrılıyor.
customerManager.GetAll();


#region Farklı Loggin İşlemleri

// Logging adında bir abstract sınıf tanımlanıyor.
public abstract class Logging
{
    // Log metodu, miras alan sınıflar tarafından implemente edilecek.
    public abstract void Log(string message);
}

// Log4NetLogger sınıfı, Logging abstract sınıfını implemente ediyor.
public class Log4NetLogger : Logging
{
    // Log metodu, Log4NetLogger'a özgü şekilde implemente edilmiştir.
    public override void Log(string message)
    {
        Console.WriteLine("Logging with Log4NetLogger.");
    }
}

// ElasticLogger sınıfı, Logging abstract sınıfını implemente ediyor.
public class ElasticLogger : Logging
{
    // Log metodu, ElasticLogger'a özgü şekilde implemente edilmiştir.
    public override void Log(string message)
    {
        Console.WriteLine("Logging with ElasticLogger.");
    }
}

#endregion

#region Farklı Caching İşlemleri

// Caching adında bir abstract sınıf tanımlanıyor.
public abstract class Caching
{
    // Cache metodu, miras alan sınıflar tarafından implemente edilecek.
    public abstract void Cache(string message);
}

// MemCache sınıfı, Caching abstract sınıfını implemente ediyor.
public class MemCache : Caching
{
    // Cache metodu, MemCache'e özgü şekilde implemente edilmiştir.
    public override void Cache(string message)
    {
        Console.WriteLine("Cached with MemCache.");
    }
}

// RedisCache sınıfı, Caching abstract sınıfını implemente ediyor.
public class RedisCache : Caching
{
    // Cache metodu, RedisCache'e özgü şekilde implemente edilmiştir.
    public override void Cache(string message)
    {
        Console.WriteLine("Cached with Redis.");
    }
}

#endregion

#region İki fabrikanın Ortak Abstract'ı

// AbstractFactory1 adında bir abstract sınıf tanımlanıyor.
public abstract class AbstractFactory1
{
    // CreateLogger ve CreateCaching metotları, miras alan sınıflar tarafından implemente edilecek.
    public abstract Logging CreateLogger();
    public abstract Caching CreateCaching();
}

#endregion

#region Birinci Fabrikanın Oluşturulması

// Factory1 adında bir sınıf, AbstractFactory1 abstract sınıfını implemente ediyor.
public class Factory1 : AbstractFactory1
{
    // CreateCaching metodu, RedisCache sınıfından bir örnek oluşturarak geri döndürülüyor.
    public override Caching CreateCaching()
    {
        return new RedisCache();
    }

    // CreateLogger metodu, Log4NetLogger sınıfından bir örnek oluşturarak geri döndürülüyor.
    public override Logging CreateLogger()
    {
        return new Log4NetLogger();
    }
}

#endregion

#region İkinci Fabrikanın Oluşturulması

// Factory2 adında bir sınıf, AbstractFactory1 abstract sınıfını implemente ediyor.
public class Factory2 : AbstractFactory1
{
    // CreateCaching metodu, MemCache sınıfından bir örnek oluşturarak geri döndürülüyor.
    public override Caching CreateCaching()
    {
        return new MemCache();
    }

    // CreateLogger metodu, ElasticLogger sınıfından bir örnek oluşturarak geri döndürülüyor.
    public override Logging CreateLogger()
    {
        return new ElasticLogger();
    }
}

#endregion

#region Client İş katmanı

// CustomerManager sınıfı
public class CustomerManager
{
    // AbstractFactory1, Logging ve Caching örnekleri burada tanımlanıyor.
    private AbstractFactory1 _abstractFactory;
    private Logging _logging;
    private Caching _caching;

    // Constructor aracılığıyla AbstractFactory1 örneği alınarak diğer bağımlılıklar enjekte ediliyor.
    public CustomerManager(AbstractFactory1 abstractFactory)
    {
        _abstractFactory = abstractFactory;
        _logging = abstractFactory.CreateLogger();
        _caching = abstractFactory.CreateCaching();
    }

    // GetAll metodu, Logging ve Caching örneklerini kullanarak işlemleri gerçekleştiriyor.
    public void GetAll()
    {
        _logging.Log("Loglama yapıldı.");
        _caching.Cache("Cachleme yapıldı.");
        Console.WriteLine("Ürünler listelendi.");
    }
}

#endregion

/*
Bu kod örneğinde, Dependency Injection ve Abstract Factory tasarım desenleri 
    kullanılarak farklı loglama (Log4NetLogger ve ElasticLogger) ve 
    caching(MemCache ve RedisCache) işlemleri için soyut fabrika sınıfları 
    (AbstractFactory1, Factory1, Factory2) oluşturulmuş ve bir CustomerManager 
    sınıfı bu fabrikaları kullanarak işlemler gerçekleştirmiştir. Main metodunda
    ise örnek olarak Factory1 ile bir CustomerManager örneği oluşturulmuş ve 
    GetAll metodu çağrılmıştır.*/