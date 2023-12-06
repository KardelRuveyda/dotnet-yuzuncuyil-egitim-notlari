CustomerManager customerManager = new CustomerManager(new Factory1());
customerManager.GetAll();

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

public abstract class AbstractFactory1
{
    public abstract Logging CreateLogger();
    public abstract Caching CreateCaching();
}

//İlk Fabrika
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

