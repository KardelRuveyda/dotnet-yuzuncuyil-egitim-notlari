CustomerManager customerManager = new CustomerManager(new Factory1());
customerManager.GetAll();


#region Farklı Loggin İşlemleri
public abstract class Logging
{
    public abstract void Log(string message);
}

public class Log4NetLogger : Logging
{
    public override void Log(string message)
    {
        Console.WriteLine("Logging with Log4NetLogger.");
    }
}

public class ElasticLogger : Logging
{
    public override void Log(string message)
    {
        Console.WriteLine("Logging with ElasticLogger.");
    }
}

#endregion

#region Farklı Caching İşlemleri

public abstract class Caching
{
    public abstract void Cache(string message);
}

public class MemCache : Caching
{
    public override void Cache(string message)
    {
        Console.WriteLine("Cached with MemCache.");
    }
}

public class RedisCache : Caching
{
    public override void Cache(string message)
    {
        Console.WriteLine("Cached with Redis.");
    }
}

#endregion

#region İki fabrikanın Ortak Abstract'ı
public abstract class AbstractFactory1
{
    public abstract Logging CreateLogger();
    public abstract Caching CreateCaching();
}
#endregion
#region Birinci Fabrikanın Oluşturulması
public class Factory1 : AbstractFactory1
{
    public override Caching CreateCaching()
    {
        return new RedisCache();
    }

    public override Logging CreateLogger()
    {
        return new Log4NetLogger();
    }
}
#endregion

#region İkinci Fabrikanın Oluşturulması
//İkinci Fabrika
public class Factory2 : AbstractFactory1
{
    public override Caching CreateCaching()
    {
        return new MemCache();
    }

    public override Logging CreateLogger()
    {
        return new ElasticLogger();
    }
}
#endregion

#region Client İş katmanı
//Client Tarafı İş Katmanı
public class CustomerManager
{
    private AbstractFactory1 _abstractFactory;
    private Logging _logging;
    private Caching _caching;
    public CustomerManager(AbstractFactory1 abstractFactory)
    {
        _abstractFactory = abstractFactory;
        _logging = abstractFactory.CreateLogger();
        _caching = abstractFactory.CreateCaching();
    }

    public void GetAll()
    {
        
        _logging.Log("Loglama yapıldı.");
        _caching.Cache("Cachleme yapıldı.");
        Console.WriteLine("Üürnler listelendi.");
    }
}
#endregion
