//
UserManager manager = new UserManager();
KardelManager kardel = new KardelManager(new KardelFactory());
manager.Save();
kardel.Save();


#region Logger Factory

//En temel class LoggerFactory ( Yani fabrika üretiyorum. ) 
//Factory'nin de bir abstract, interface soyutlamasının olması gerekiyor.
//Yarın öbür gün başka bir factoryle de çalışmak isteyebilirim.
public class LoggerFactory: ILoggerFactory
{
    public ILogger CreateLogger()
    {
        //Loglamayı yapacak bir sınıf üretiyorum.
        return new KRCLogger();
    }
}

public interface ILoggerFactory
{
    ILogger CreateLogger();
}

public interface ILogger
{
    void Log();
}

#endregion 

#region Kardel Factory

public class KardelFactory : IKardelFactory
{
    public IKardelLogger CreateLogger()
    {
        return new KardelLogger();
    }
}

public interface IKardelFactory
{
    IKardelLogger CreateLogger();
}
public interface IKardelLogger
{
    void Kardel();
}

#endregion

#region Loggers
//1. Logger KRCLogger
public class KRCLogger : ILogger
{
    public void Log()
    {
        Console.Write("KRC Logger logladı.");
    }
}

//2. Logger
public class KardelLogger : IKardelLogger
{
    public void Kardel()
    {
        Console.Write("Kardel Logger ile loglandı.");
    }
}
#endregion

#region 1. Client
public class UserManager
{
    public void Save()
    {
        //ILogger logger = new KRCLogger();
        ILogger logger = new LoggerFactory().CreateLogger();
        logger.Log();
    }
}

#endregion


#region 2. Client
public class KardelManager
{
    private IKardelFactory _kardelFactory;

    public KardelManager(IKardelFactory loggerFactory)
    {
        _kardelFactory = loggerFactory;
    }

    public void Save()
    {
        IKardelLogger kardel = _kardelFactory.CreateLogger(); 
        kardel.Kardel();
    }
}
#endregion