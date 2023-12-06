Renault renault = new Renault();
//renault.SendInfoDriver(new DriverInfo
//{
//    Telephone = "53051531",
//    EmailAddress = "ruveyda@gmail.com"
//});


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


public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
}
