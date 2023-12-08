#region Kodun çalıştırıldığı yer
Renault renault = new Renault();

CalculateTripCost();
#region Harcanan yakıt parasını hesaplayan fonksiyon 
void CalculateTripCost()
{
    var calculator = new FuelCostCalculator();
    var cost = calculator.Calculate(new Renault());

    Console.WriteLine($"Toplam Harcanan Para: {cost}");
    Console.ReadLine();
}
#endregion
#endregion
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
public class Nissan : BaseCar, ISmsSendable, IMailSendable,IMultipleEmailSendable
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