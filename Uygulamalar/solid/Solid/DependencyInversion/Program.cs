
#region Kodun Çalıştırıldığı Yer 
RunCars();

void RunCars()
{
    try
    {
        var renault = new Renault();

        //Araç hareket etsin.
        renault.Go();

        //Duruyor
        renault.Stop();

        //Bilgilerle ilgili sürücüye mail atsın. 
        renault.SendInfoDriverEmail(new DriverInfo());
    }
    catch (ArithmeticException ex1)
    {
        //Motorla ilgili bir arıza oluşursa
        new TripInfoLogger().LogToLocalStorage(ex1.Message);

        //dependency ile 
        new TripInfoLoggerDependency(new LogStorageLoggerDependency()).Log(ex1.Message);

    }
    catch(Exception ex2)
    {
        //Lastik basıncı ile ilgili bir arıza oluşsun.
        new TripInfoLogger().LogToTurkey(ex2.Message);
        new TripInfoLoggerDependency(new TurkeyLoggerDependency()).Log(ex2.Message);
    }
}
#endregion

#region Dependency Inversion Kullanılmasa
public class TripInfoLogger
{
    public void LogToTurkey(string tripInfo)
    {
        new TurkeyLogger().Log(tripInfo);
    }

    public void LogToLocalStorage(string logInfo)
    {
        new LocalStorageLogger().Log(logInfo);
    }

    public void GermanyStorageLogger(string logInfo)
    {
        new GermanyStorageLogger().Log(logInfo);
    }

    public void RussiaStorageLogger(string logInfo)
    {
        new RussiaStorageLogger().Log(logInfo);
    }
}

public class TurkeyLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Türkiye'm:{logStr}");
    }
}

public class LocalStorageLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Ana Merkez:{logStr}");
    }
}

public class GermanyStorageLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Ana Merkez:{logStr}");
    }
}

public class RussiaStorageLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Ana Merkez:{logStr}");
    }
}

#endregion

#region Dependency Inversion ile yapsaydım ? 

public class TripInfoLoggerDependency
{
    private ILoggerDependency _logger;

    public TripInfoLoggerDependency(ILoggerDependency logger)
    {
        _logger = logger;
    }

    public void Log(string logInfo)
    {
        _logger.Log(logInfo);
    }
}

public class TurkeyLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Türkiye'm:{logStr}");
    }
}

public class LogStorageLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Ana Merkez:{logStr}");
    }
}


public class GermanyStorageLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Almanya:{logStr}");
    }
}

public class RussiaStorageLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Rusya:{logStr}");
    }
}
public interface ILoggerDependency
{
    void Log(string logStr);
}


#endregion



#region Önceki yapılanlar 
#region Renault 
public class Renault : BaseCar, ISmsSendable, IMailSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }

    public void SendInfoDriverEmail(DriverInfo mail)
    {
        Console.WriteLine("Mail gönderimi sağandı.");
    }

    public void SendInfoDriverSms(DriverInfo sms)
    {
        Console.WriteLine("Sms gönderimi sağandı.");
    }
}
#endregion

#region Nissan
public class Nissan : BaseCar, ISmsSendable, IMailSendable, IMultipleEmailSendable
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }

    public void SendInfoDriverEmail(DriverInfo mail)
    {
        Console.WriteLine("Mail gönderimi sağandı.");
    }

    public void SendInfoDriverSms(DriverInfo sms)
    {
        Console.WriteLine("Sms gönderimi sağandı.");
    }

    public void SendInfoEmailToDrivers(List<DriverInfo> mails)
    {
        foreach (var mail in mails)
        {
            SendInfoDriverEmail(mail);
        }

    }
}
#endregion

#region Yakıt Giderlerini Hesaplayan Bir Class

public class FuelCostCalculator
{
    public double Calculate(BaseCar car)
    {
        return car.RoadmKm * car.GetCostPerKM();
    }
}

#endregion


#region Base Car Abstract Class'ının oluşturulması
public abstract class BaseCar
{
    public double RoadmKm { get; set; }

    public abstract double GetCostPerKM();

    public void Go()
    {
        Console.WriteLine("Araba gidiyor..");
    }

    public void Stop()
    {
        Console.WriteLine("Araba durdu.");
    }

    public void SendMail()
    {
        Console.WriteLine($"Mail gönderildi. Mail Adresi");
    }

    public void SendSms()
    {
        Console.WriteLine("SMS Gönderildi");
    }
}

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
}

#region Interface Tanımlamları
#region SMS Interface'i tanımlaması
public interface ISmsSendable
{
    void SendInfoDriverSms(DriverInfo sms);
}
#endregion

#region Mail Interface

public interface IMailSendable
{
    void SendInfoDriverEmail(DriverInfo mail);

}

public interface IMultipleEmailSendable
{
    void SendInfoEmailToDrivers(List<DriverInfo> mails);
}
#endregion
#endregion
#endregion
#endregion