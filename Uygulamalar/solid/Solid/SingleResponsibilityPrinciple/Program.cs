#region Kodun Çalıştırıldığı Kısım
Renault renault = new Renault();
renault.SendInfoDriver(new DriverInfo
{
    Telephone = "53051531",
    EmailAddress = "ruveyda@gmail.com"
});

#endregion


#region Birinci Arabanın Class'ı
public class Renault
{
    public int RoadKm { get; set; }

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


    //Bir metot içerisinde birden fazla işlem yapmaması gerekiyor
    //Aşağıdaki işlemde hem Mail hem Sms atılmaktadır.
    //Bu single responsibility'e uygu bir kullanım değildir. 
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

    #region SingleResponsibility Uyması için Eklendi
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

    #endregion
}
#endregion


#region İkinci Arabanın Class'I
public class Nissan
{
    public int RoadKm { get; set; }

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


    //Bir metot içerisinde birden fazla işlem yapmaması gerekiyor
    //Aşağıdaki işlemde hem Mail hem Sms atılmaktadır.
    //Bu single responsibility'e uygu bir kullanım değildir. 
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

    #region Single Responsibility Uyumluluğu için eklendi.
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

    #endregion
}
#endregion

public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
}
