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

    //Renault bu fonksiyonu desteklemek istemiyorsa ne yapacağım ? :( 
    //İşte burada Interface Segregation devreye girecekk :)
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

    //Base'den kaldıralım çünkü belki bi araç mail gönderimini kaldırabilir, diğeri kaldırmayabilir.
    //public void SendInfoDriverSms(DriverInfo driver)
    //{
    //    if (!string.IsNullOrEmpty(driver.Telephone))
    //    {
    //        SendSms();
    //    }
    //}

    //public void SendInfoDriverMail(DriverInfo driver)
    //{
    //    if (!string.IsNullOrEmpty(driver.EmailAddress))
    //    {
    //        SendMail();
    //    }
    //}
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

    //Yarın bir gün yeni bir metot eklerlerse Interface Segregation bozulur.
}

//Bir interface oluşturalım, sms gönderimi işlemi için
public interface ISMSSendable
{
    void SendInfoDriverSms(DriverInfo drivers);
}

public interface IMultipleEmailSendable
{
    void SendInfoEmailToDrivers(List<DriverInfo> driver);
}