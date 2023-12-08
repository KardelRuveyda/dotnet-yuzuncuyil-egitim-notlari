// User Manager sınıfından bir örnek oluşturuluyor.
UserManager manager = new UserManager();
// Kardel Manager sınıfından bir örnek, KardelFactory kullanılarak oluşturuluyor.
KardelManager kardel = new KardelManager(new KardelFactory());

// User Manager'ın Save metodu çağrılıyor.
manager.Save();
// Kardel Manager'ın Save metodu çağrılıyor.
kardel.Save();



#region Loggers
// IKardelLogger arayüzü, KardelLogger sınıfının bir örneğini oluşturacak fabrika sınıflar için bir şablon belirler.
public interface IKardelLogger
{
    void Kardel();
}

public interface IKRCLogger
{
    void Log();
}


//1. Logger KRCLogger
public class KRCLogger : IKRCLogger
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


#region Logger Factory

//En temel class LoggerFactory ( Yani fabrika üretiyorum. ) 
//Factory'nin de bir abstract, interface soyutlamasının olması gerekiyor.
//Yarın öbür gün başka bir factoryle de çalışmak isteyebilirim.

// LoggerFactory, ILoggerFactory arayüzünü implemente ediyor.
public class LoggerFactory: ILoggerFactory
{
    public IKRCLogger CreateLogger()
    {
        // KRCLogger sınıfından bir örnek oluşturularak geri döndürülüyor.
        return new KRCLogger();
    }
}

// ILoggerFactory arayüzü, loglama sınıflarının örneklerini oluşturacak fabrika sınıflar için bir şablon belirler.
public interface ILoggerFactory
{
    IKRCLogger CreateLogger();
}
#endregion 

#region Kardel Factory

// KardelFactory, IKardelFactory arayüzünü implemente ediyor.
public class KardelFactory : IKardelFactory
{
    // IKardelFactory arayüzünden gelen CreateLogger metodu implemente ediliyor.
    public IKardelLogger CreateLogger()
    {
        // KardelLogger sınıfından bir örnek oluşturularak geri döndürülüyor.
        return new KardelLogger();
    }
}

// IKardelLogger arayüzü, KardelLogger sınıfının bir örneğini oluşturacak fabrika sınıflar için bir şablon belirler.
public interface IKardelFactory
{
    IKardelLogger CreateLogger();
}
#endregion


#region 1. Client
// UserManager sınıfı, ILoggerFactory kullanarak bir ILogger örneği oluşturarak loglama işlemini gerçekleştiriyor.
public class UserManager
{
    public void Save()
    {
        // ILoggerFactory arayüzünden bir örnek oluşturuluyor.
        IKRCLogger logger = new LoggerFactory().CreateLogger();
        // Oluşturulan ILogger örneğinin Log metodu çağrılıyor.
        logger.Log();
    }
}

#endregion


#region 2. Client
// KardelManager sınıfı, IKardelFactory kullanarak bir IKardelLogger örneği oluşturarak Kardel özelinde loglama işlemini gerçekleştiriyor.
public class KardelManager
{
    private IKardelFactory _kardelFactory;
    // IKardelFactory arayüzünden bir örnek alarak KardelManager sınıfını başlatan bir constructor.
    public KardelManager(IKardelFactory loggerFactory)
    {
        _kardelFactory = loggerFactory;
    }

    public void Save()
    {
        // Save metodu, IKardelFactory kullanarak bir IKardelLogger örneği oluşturuyor ve Kardel metodu çağrılıyor.
        IKardelLogger kardel = _kardelFactory.CreateLogger();
        // Oluşturulan IKardelLogger örneğinin Kardel metodu çağrılıyor.
        kardel.Kardel();
    }
}
#endregion