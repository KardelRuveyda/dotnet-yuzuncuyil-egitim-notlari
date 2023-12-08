#region Kodun Çalıştırıldığı Kısım 
Renault renault = new Renault();
//Sürücü bilgilerinin sadece mail gönderilmesini istiyorsam aşağıdaki kodu çalıştırım. 

renault.SendInfoDriverMail(new DriverInfo
{
    EmailAdress = "ruveydakardelcetin@gmail.com"
});
#endregion

#region Birinci Arabanın Class'ının oluşturulması
public class Renault
{
    public int RoadmKm { get; set; }

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

    //Bir metot içerisinde birden fazla işlem yapılmaması gerektiğini gösteren bir metot yazalım .

    public void SendInfoDriver(DriverInfo driver)
    {
        if (!String.IsNullOrEmpty(driver.EmailAdress))
        {
            SendMail();
        }

        if (!String.IsNullOrEmpty(driver.Telephone))
        {
            SendSms();
        }
    }

    #region Single Responsibility İşlemleri İçin Yapılan Alan
    public void SendInfoDriverSms(DriverInfo driver)
    {
        if (!String.IsNullOrEmpty(driver.Telephone))
        {
            SendSms();
        }
    }

    public void SendInfoDriverMail(DriverInfo driver)
    {
        if (!String.IsNullOrEmpty(driver.EmailAdress))
        {
            SendMail();
        }
    }
    #endregion
}

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
}

#endregion