**Proje Detayları**

- N-Layer katmanlı mimarisine uygun .NET Core 6.0 versiyonla bir proje oluşturmanız gerekiyor.
- Projenin içerisinde Core,Repository,Service ve API katmanları yer almalıdır. ( En az üç katmanlı olması şarttır. Tercihe istinaden farklı katmanlar da ekleyebilirsiniz.(Test vb.)
- Core katmanı bileşenleri :Model,DTOs,Repository Interfaces, Service Interfaces, Unitofwork Interfaces 
- Repository katmanı bileşenleri:Migrations,Seeds, Repository Imlementation, Unitofwork, implementation
- Servis katmanı bileşenleri : Mapping, Service Implementation, Validations, Exceptions
- Ders kapsamında Team,User,UserProfile tablolarına istinaden işlemler yaptık. Sizler de kendiniz bir senaryo üretip 3 adet tablo oluşturabilirsiniz.
- Bu tablolar kapsamında "Generic" repository işlemlerinin ve "Generic" servis işlemlerinin olması gerekmektedir.
- Ek olarak, Generic Service dışında kullanacağınız servislerde "Generic" metot dışında farklı metotlar da yazabilirsiniz.
- API katmanında ders kapsamında gördüğümüz Custom Response'dan faydalanabilirsiniz.
- Oluşturduğunuz metotları Swagger üzerinde göstermelisiniz.
- Veri tabanı olarak istediğiniz veri tabanı yönetim sistemini kullanabilirsiniz.
- Projeniz tamamlandıktan sonra hassas verileri içerisinde barındıran appsettings.json dosyasını da güvenlik kurallarına uygun bir şekilde revize etmeyi ihmal etmeyin.

**Makale Yazacaklara Konu Başlıkları**

- _Makalenizi "Dotnet Bootcamp" e özel hangi konuları gördüysek hepsini içeren bir makale yazabileceğiniz gibi ayarı ayrı makaleler de yazabilirsiniz. _

**Konu Başlıkları**
- Git versiyon kontrol sistemi temelleri
- C# Temelleri
- Interface, Abstract farklılıkları
- SOLID
- Design Patterns
- Dotnet Core Temelleri
- Monolith Mimari
- Soa Mimari
- Microservices
- N-Layer katmanlı proje mimarisi
- Core Katmanı Görevleri
- Repository Katmanı Görevleri
- Servis katmanı görevleri
- API Katmanı görevleri
- Unit test neden yazarız?
- Dotnet Core ile Secret Protection
