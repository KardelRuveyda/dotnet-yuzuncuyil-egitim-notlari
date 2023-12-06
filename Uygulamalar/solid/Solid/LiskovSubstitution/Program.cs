#region Kodun Çalıştırıldığı Yer
Renault renault = new Renault();
renault.SendInfoDriverSms(new DriverInfo
{
    Telephone = "53051531",
    EmailAddress = "ruveyda@gmail.com"
});
#endregion

#region Renault
public class Renault : BaseCar, ISMSSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }
    public void SendInfoDriverSms(DriverInfo driver)
    {
        if (!string.IsNullOrEmpty(driver.Telephone))
        {
            SendSms();
        }
    }
}
#endregion

#region Nissan
public class Nissan : BaseCar, ISMSSendable,IEmailSendable
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
#endregion

#region Yakıt Giderini
//Yakıt Giderini hesaplayan Class
public class FuelCostClaculator
{
    public double Calculate(BaseCar car)
    {
        return car.RoadKm * car.GetCostPerKM();
    }
}
#endregion


#region Driver Bilgileri
public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
}
#endregion

#region Email atan interface
//Bir interface oluşturalım, mail gönderimi işlemi için
public interface IEmailSendable
{
    void SendInfoDriverMail(DriverInfo driver);
}
#endregion


#region Sms atan interface
//Bir interface oluşturalım, sms gönderimi işlemi için
public interface ISMSSendable
{
    void SendInfoDriverSms(DriverInfo driver);
}

#endregion