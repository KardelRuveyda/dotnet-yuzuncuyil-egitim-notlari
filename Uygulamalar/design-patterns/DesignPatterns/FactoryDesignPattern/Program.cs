#region Kodun Çalıştırıldığı Kısım

#endregion


#region Loggers
//IKardelLogger arayüzü , KardelLogger sınıfının bir örneğini oluşturucak fabrika sınıfları 
//için bir şablon belirler.
public interface IKardelLogger
{
    void Log();
}

public interface IKRCLogger
{
    void Log();
}


//1.Logger KRCLogger
public class KRCLogger : IKRCLogger
{
    public void Log()
    {
        Console.WriteLine("KRC Logger Başladı");
    }
}

public class KardelLogger : IKardelLogger
{
    public void Log()
    {
        Console.WriteLine("Kardel Logger Başladı");
    }
}
#endregion


#region KRC Logger Factory

// En temel Classım Logger Factory ( Yani Fabrika üretiyorum ) 
//Factory bir abstract veya abstractan inherit edimesi gerekir. 
// Ben bugün bu factory ile çalışıyorsam yarın başka bir factory ile çalışmak isteybeilirim.

public interface IKRCLoggerFactory
{
    IKRCLogger CreateLogger();
}

public class KRCLoggerFactory : IKRCLoggerFactory
{
    public IKRCLogger CreateLogger()
    {
        // KRC Logger sınıfından bir örnek oluşturarak geri döndürme işlemi yapalım.
        return new KRCLogger();
    }
}
#endregion

#region Kardel Factory
public interface IKardelFactory
{
    IKardelLogger CreateLogger();
}

public class KardelFactory : IKardelFactory
{
    public IKardelLogger CreateLogger()
    {
        return new KardelLogger();
    }
}

#endregion

#region  1. Client /// Uygun olmayan kullanım.
public class UserManager
{
    public void Save()
    {
        //ILoggerFactory arayüzünden bir örnek oluşturmak istiyorum. 

        IKRCLogger logger = new KRCLoggerFactory().CreateLogger();
        logger.Log();
    }
}
#endregion


#region 2. Client
public class KardelManager
{
    private IKardelFactory _kardelFactory;

    public KardelManager(IKardelFactory kardelFactory)
    {
        _kardelFactory = kardelFactory;
    }

    public void Save()
    {
        IKardelLogger kardel = _kardelFactory.CreateLogger();
        kardel.Log();
    }
}
#endregion
