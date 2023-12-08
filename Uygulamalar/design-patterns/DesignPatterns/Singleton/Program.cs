using System;

// ILogger arayüzü, loglama işlemleri için bir şablon belirler.
public interface ILogger
{
    void Log(string message);
}

// FileLogger, ILogger arayüzünü implemente ederek loglama işlemini dosyaya yapar.
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log to file: {message}");
    }
}

// ConsoleLogger, ILogger arayüzünü implemente ederek loglama işlemini konsola yapar.
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log to console: {message}");
    }
}

// UserService, bir ILogger bağımlılığına sahip olan bir servis sınıfıdır.
public class UserService
{
    private readonly ILogger _logger;

    // Bağımlılık enjeksiyonu ile ILogger örneği alınır.
    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void SaveUser(string username)
    {
        // Kullanıcı kaydedildiği zaman loglama işlemi yapılır.
        _logger.Log($"User saved: {username}");
        // Gerçek kullanıcı kaydetme işlemleri burada gerçekleştirilir.
    }
}

class Program
{
    static void Main()
    {
        // Dependency Injection ile FileLogger kullanarak UserService örneği oluşturuluyor.
        var userServiceWithFileLogger = new UserService(new FileLogger());
        userServiceWithFileLogger.SaveUser("John Doe");

        Console.WriteLine("----------------------");

        // Dependency Injection ile ConsoleLogger kullanarak UserService örneği oluşturuluyor.
        var userServiceWithConsoleLogger = new UserService(new ConsoleLogger());
        userServiceWithConsoleLogger.SaveUser("Jane Doe");
    }
}

/*
Yukarıdaki örnekte ILogger arayüzü loglama işlemleri için bir şablon belirler. 
    FileLogger ve ConsoleLogger sınıfları bu arayüzü implemente eder ve kendi loglama 
    yöntemlerini tanımlarlar.

UserService sınıfı, bir ILogger bağımlılığına sahiptir ve bu bağımlılık constructor 
aracılığıyla enjekte edilir. Bu sayede, UserService sınıfı loglama işlemleri için 
herhangi bir ILogger implementasyonuyla çalışabilir.

Main metodu içinde, UserService sınıfının iki farklı örneği oluşturuluyor ve
her birine farklı bir ILogger implementasyonu enjekte ediliyor. Bu şekilde 
Dependency Injection sayesinde, UserService sınıfı loglama işlemleri için esnek ve
değiştirilebilir hale gelir.*/