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
public class Renault : BaseCar
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }
}
#endregion

#region Nissan
public class Nissan : BaseCar
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }
}
#endregion

#region Yakıt Giderlerini Hesaplayan Bir Class

public class FuelCostCalculator
{
    public double Calculate(BaseCar car)
    {
        //if (car is Nissan)
        //{
        //    return 5.6;
        //}
        //else if (car is Renault)
        //{
        //    return  3.5;
        //}else if(car is BMW)
        //{
        //    return 1.5;
        //}
        //else
        //{
        //    return 10.5;
        //}
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
}

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
}
#endregion