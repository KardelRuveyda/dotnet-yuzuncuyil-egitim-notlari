#region Kodun Çalıştırıldığı Yer
Renault renault = new Renault();
renault.SendInfoDriverMail(new DriverInfo
{
    Telephone = "53051531",
    EmailAddress = "ruveyda@gmail.com"
});
#endregion

#region Renault İşlemleri
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
#endregion


#region Nissan İşlemleri
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

#endregion

#region BaseCar
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
}

#endregion


#region Yakıt Giderini Hesaplayan
//Yakıt Giderini hesaplayan Class
public class FuelCostClaculator
{
    public double Calculate(BaseCar car)
    {
        return car.RoadKm * car.GetCostPerKM();
    }
}

#endregion

#region Sürücü Bilgileri
public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
}
#endregion


#region Email İçin Interface
//Bir interface oluşturalım, mail gönderimi işlemi için
public interface IEmailSendable
{
    void SendInfoDriverMail(DriverInfo driver);

    //Yarın bir gün yeni bir metot eklerlerse Interface Segregation bozulur.
}

#endregion

#region SMS için interface
//Bir interface oluşturalım, sms gönderimi işlemi için
public interface ISMSSendable
{
    void SendInfoDriverSms(DriverInfo drivers);
}
#endregion

#region MultipleEmailSendable
public interface IMultipleEmailSendable
{
    void SendInfoEmailToDrivers(List<DriverInfo> driver);
}
#endregion
