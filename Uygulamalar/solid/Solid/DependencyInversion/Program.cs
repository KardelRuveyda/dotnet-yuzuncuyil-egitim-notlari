//Çalıştırılma
RunCars();

void RunCars()
{
    try
    {
        var renault = new Renault();

        // Araç hareket ediyor.
        renault.Go();

        // Duruyor
        renault.Stop();

        // Mail atıyor.
        renault.SendInfoDriverMail(new DriverInfo());
    }
    catch (ArithmeticException ex2)
    {
        //Motorla ilgili arıza oluşursa 
        new TripInfoLogger().LogToLocalStorage(ex2.Message);
        new TripInfoLoggerDependency(new LogStorageLoggerDependency()).Log(ex2.Message);
        //İkinci çözümle
    }
    catch (Exception ex)
    {
        // Lastik basıncı vs gibi bir hata oluşursa buraya loglanıyor.
        // Türkiyeye gönderilecek.
        new TripInfoLogger().LogToTurkey(ex.Message);
        new TripInfoLoggerDependency(new TurkeyLoggerDependency()).Log(ex.Message);
    }



}


/// <summary>
//Her bir yeni hata oluştuğunda tekrar metot yazmam gerekecek. 
//Bu aslında bir sorun :(
//TripInfoLogger TurkeyLogger içerisindeki metotlara bağımlı. 
// Daha üst seviyedeki class alt metotlara bağımlı olmamalı
//Abstraction ile sorun çözülebilir. 
/// </summary>

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
}
public class TurkeyLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine("Loglama işlemi Turkey");
    }
}

public class LocalStorageLogger
{
    public void Log(string logStr)
    {
        Console.WriteLine("Local Storage Loglama işlemi Turkey");
    }
}



#region Dependency Inversion kullanılmış hali
/// Çözülmüş hali 
/// Kendi içerisinde daha alt bir class'a bağımlı değil.
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
public class TurkeyLoggerDependency: ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine("Loglama işlemi Turkey");
    }

    public void LocalStorageLog(string logStr)
    {
        Console.WriteLine("Local Storage Loglama işlemi Turkey");
    }
}

public class LogStorageLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine("Local Storage Loglama işlemi Turkey");
    }
}
public interface ILoggerDependency
{
    void Log(string logStr);
}

#endregion

#region Eski Solutionlarda olan alan
/// <summary>
/// Burdan sonrası zaten diğer solutionlarla benzer.
/// 
/// </summary>
public class Renault : BaseCar, IEmailSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }
    public void SendInfoDriverMail(DriverInfo driver)
    {
        if (!string.IsNullOrEmpty(driver.EmailAddress))
        {
            SendMail();
        }
    }
}


public class Nissan : BaseCar, ISMSSendable, IEmailSendable, IMultipleEmailSendable
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }

    public void SendInfoDriverSms(DriverInfo driver)
    {
        if (!string.IsNullOrEmpty(driver.Telephone))
        {
            SendSms();
        }
    }

    public void SendInfoDriverMail(DriverInfo driver)
    {
        if (!string.IsNullOrEmpty(driver.EmailAddress))
        {
            SendMail();
        }
    }

    public void SendInfoEmailToDrivers(List<DriverInfo> drivers)
    {
        foreach (var driver in drivers)
        {
            SendInfoDriverMail(driver);
        }
    }
}

public abstract class BaseCar
{
    public int RoadKm { get; set; }

    public abstract double GetCostPerKM();

    public void Go()
    {
        Console.WriteLine("Araba  gidiyor.");
    }

    public void Stop()
    {
        Console.WriteLine("Araba durdu.");
    }

    public void SendMail()
    {
        Console.WriteLine("Mail gönderildi.");
    }

    public void SendSms()
    {
        Console.WriteLine("Mail gönderildi.");
    }

    public void SendInfoDriver(DriverInfo driver)
    {
        if (!string.IsNullOrEmpty(driver.EmailAddress))
        {
            SendMail();
        }

        if (!string.IsNullOrEmpty(driver.Telephone))
        {
            SendSms();
        }
    }
}

//Yakıt Giderini hesaplayan Class
public class FuelCostClaculator
{
    public double Calculate(BaseCar car)
    {
        return car.RoadKm * car.GetCostPerKM();
    }
}



public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
}


//Bir interface oluşturalım, mail gönderimi işlemi için
public interface IEmailSendable
{
    void SendInfoDriverMail(DriverInfo driver);

}

public interface ISMSSendable
{
    void SendInfoDriverSms(DriverInfo drivers);
}

public interface IMultipleEmailSendable
{
    void SendInfoEmailToDrivers(List<DriverInfo> driver);
}
#endregion