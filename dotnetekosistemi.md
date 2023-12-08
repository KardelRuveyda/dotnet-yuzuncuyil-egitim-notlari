# .NET Ekosistemi

.NET, birçok tür uygulama oluşturmaya yönelik ücretsiz, platformlar arası, açık kaynak bir geliştirici platformudur . .NET, birçok yüksek ölçekli uygulama tarafından üretimde kullanılan yüksek performanslı bir çalışma zamanı üzerine kurulmuştur.

## Bulut uygulamaları

- Bulutta yerel uygulamalar
- .NET Aspire
- Konsol uygulamaları
- Bulutta sunucusuz işlevler
- Web uygulamaları, web API'leri ve mikro hizmetler

## Windows uygulamaları
- Windows Masaüstü uygulamaları(Windows Forms,Windows WPF)
- Evrensel Windows Platformu (UWP)
- Windows hizmetleri

## .NET Özellikleri
- Asynchronous code
- Attributes
- Reflection
- Code analyzers
- Representatives and lambda expressions
- Events
- Special cases
- Garbage collection
- General Species
- LINQ (Language Integrated Query).
- Parallel programming and Managed threading
- Type inference - C#, F#, Visual Basic.
- Type system
- Unsecured code

## .NET kullanma

.NET uygulamaları ve kitaplıkları, .NET CLI veya Visual Studio gibi bir Tümleşik Geliştirme Ortamı (IDE) kullanılarak kaynak koddan ve proje dosyasından oluşturulur.

![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/d714109f-1839-4911-ab08-ad73ae2f2f12)
![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/5732699c-4441-4e05-9b39-304c982c8361)


- **.NET SDK:** Geliştirme, derleme ve test uygulamaları için araçlar, kitaplıklar ve çalışma zamanları kümesi.
- **.NET Çalışma Zamanları:** Uygulamaları çalıştırmak için çalışma zamanı ve kitaplık kümesi.

## Ücretsiz ve açık kaynak

NET ücretsiz, açık kaynak ve bir .NET Foundation projesidir. .NET, Microsoft ve GitHub'daki topluluk tarafından çeşitli depolarda tutulur. .NET kaynağı ve ikili dosyaları MIT lisansıyla lisanslandırılır. İkili dağıtımlar için Windows'ta ek lisanslar geçerlidir.

## Desteklenen Diller

Çalışma zamanı, birden çok programlama dilini destekleyecek şekilde tasarlanmıştır. C#, F# ve Visual Basic dilleri Microsoft tarafından desteklenir ve toplulukla işbirliği içinde tasarlanmıştır.

- **C#** modern, nesne odaklı ve tür açısından güvenli bir programlama dilidir. C dil ailesine kökenleri vardır ve C, C++, Java ve JavaScript programcılarına hemen aşina olacaktır.
- **F#** kısa, sağlam ve performanslı kod yazmaya yönelik birlikte çalışabilen bir programlama dilidir. F# programlama, kodun işlevlerle veri dönüştürmeyi içerdiği veri odaklıdır.
- **Visual Basic** , sıradan bir insan diline daha yakın olan daha ayrıntılı bir söz dizimi kullanır. Programlamaya yeni yeni gelen kişiler için öğrenmesi daha kolay bir dil olabilir.

## Nuget Paket Yöneticisi

NuGet , .NET için paket yöneticisidir. Geliştiricilerin derlenmiş ikili dosyaları birbirleriyle paylaşmasına olanak tanır. NuGet.org topluluktan birçok popüler paket sunar.

## .NET geçmişi

- 2002'de Microsoft, Windows uygulamaları oluşturmaya yönelik bir geliştirme platformu olan .NET Framework'i yayımladı. Bugün .NET Framework 4.8 sürümündedir ve Microsoft tarafından tam olarak desteklenmektedir.
- 2014'te Microsoft, .NET Framework'ün açık kaynak ardılı olarak .NET Core'u platformlar arası bir hale getirerek kullanıma sunmaçtaydı. .NET'in bu yeni uygulaması sürüm 3.1'e kadar .NET Core adını korudu. .NET Core 3.1'den sonraki sürüm adın "Core" bölümünü bıraktı ve .NET 5 olarak adlandırıldı.
- Yeni .NET sürümleri, her birinin ana sürüm numarası daha yüksek olmak üzere yıllık olarak yayınlanmaya devam ediyor. Bunlar önemli yeni özellikler içerir ve genellikle yeni senaryoları etkinleştirir.

## .NET ekosistemi

Her biri farklı bir uygulama türünü destekleyen birden çok .NET değişkeni vardır. Birden çok çeşidin nedeni kısmen geçmiş, kısmen tekniktir.

_**Microsoft'un desteklediği dört .NET uygulaması vardır:**_

- NET 6 ve sonraki sürümleri
- .NET Framework
- Mono
- UWP
  
Daha önce .NET Core olarak adlandırılan .NET şu anda birincil uygulamadır. .NET (8), Windows masaüstü uygulamaları ve platformlar arası konsol uygulamaları, bulut hizmetleri ve web siteleri gibi birden çok platformu ve çok sayıda iş yükünü destekleyen tek bir kod tabanında oluşturulur. .NET WebAssembly derleme araçları gibi bazı iş yükleri isteğe bağlı yüklemeler olarak kullanılabilir.

**.NET uygulamaları (geçmiş sırası):**

**.NET Framework**

.NET Framework, 2002'den beri var olan özgün .NET uygulamasıdır. Sürüm 4.5 ve üzeri .NET Standard'ı uyguladığından, .NET Standard'ı hedefleyen kod bu .NET Framework sürümlerinde çalıştırılabilir. Windows Forms ve WPF ile Windows masaüstü geliştirme API'leri gibi Windows'a özgü ek API'ler içerir. .NET Framework, Windows masaüstü uygulamaları oluşturmak için iyileştirilmiştir.

**Mono**

Mono, çoğunlukla küçük bir çalışma zamanı gerektiğinde kullanılan bir .NET uygulamasıdır. Android, macOS, iOS, tvOS ve watchOS'ta Xamarin uygulamalarını destekleyen ve öncelikli olarak küçük bir ayak izine odaklanan çalışma zamanıdır. Mono, Unity altyapısı kullanılarak oluşturulan oyunları da destekler. Şu anda yayımlanmış olan tüm .NET Standard sürümlerini destekler. Mono, geçmişte daha büyük .NET Framework API'sini uyguladı ve Unix'te en popüler özelliklerden bazılarını taklit etti. Bazen Unix'te bu özelliklere dayanan .NET uygulamalarını çalıştırmak için kullanılır. Mono genellikle tam zamanında derleyici ile kullanılır, ancak aynı zamanda iOS gibi platformlarda kullanılan tam statik derleyici (önceden derleme) içerir.

**.NET (Core)** 

.NET'in platformlar arası ve açık kaynak uygulaması, bulut çağı için yeniden kullanılırken .NET Framework ile önemli ölçüde uyumlu kalır. Linux, macOS ve Windows uygulamaları için kullanılır.

**.NET 5 ve sonraki sürümleri**

_.NET 8, bu .NET uygulamasının en son sürümüdür._

_Daha fazla bilgi edinmek için aşağıdaki kaynaklara bakın:_

- .NET'e giriş
- Sunucu uygulamaları için .NET ve .NET Framework karşılaştırması
- .NET 5+ ve .NET Standard

Daha önce .NET Core olarak adlandırılan .NET, sunucu ve bulut iş yüklerini büyük ölçekte işlemek için tasarlanmış platformlar arası bir uygulamadır. Masaüstü uygulamaları da dahil olmak üzere diğer iş yüklerini de destekler. Windows, macOS ve Linux üzerinde çalışır. .NET Standard'ı hedefleyen kodun .NET üzerinde çalışabilmesi için .NET Standard'ı uygular. ASP.NET Core, Windows Forms ve Windows Presentation Foundation (WPF) .NET üzerinde çalışır.

### Kaynakça 
https://learn.microsoft.com/tr-tr/dotnet/core/introduction
