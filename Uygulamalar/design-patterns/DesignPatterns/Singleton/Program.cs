
// Bağımlılığı temsil eden bir arayüz
interface IMessageService
{
    void SendMessage(string message);
}

// Bağımlılığın somut bir implementasyonu
class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email gönderildi: {message}");
    }
}

// Bağımlılığın somut bir implementasyonu
class SMSService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS gönderildi: {message}");
    }
}

// Bağımlılıkları enjekte edeceğimiz sınıf
class NotificationService
{
    private readonly IMessageService messageService;

    // Dependency Injection ile IMessageService'yi bekleyen bir constructor
    public NotificationService(IMessageService messageService)
    {
        this.messageService = messageService;
    }

    public void SendNotification(string message)
    {
        // Bağımlılığı kullan
        messageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        // Bağımlılıkları enjekte etmek için uygun servisleri oluştur
        IMessageService emailService = new EmailService();
        IMessageService smsService = new SMSService();

        // Bağımlılıkları enjekte ederek NotificationService'i oluştur
        NotificationService emailNotificationService = new NotificationService(emailService);
        NotificationService smsNotificationService = new NotificationService(smsService);

        // Farklı bağımlılıkları kullanarak bildirim gönder
        emailNotificationService.SendNotification("Merhaba, bu bir email bildirimdir.");
        smsNotificationService.SendNotification("Merhaba, bu bir SMS bildirimdir.");
    }
}
