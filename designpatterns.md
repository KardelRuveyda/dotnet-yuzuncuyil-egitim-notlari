# Design Patterns

### Singleton Tasarım Deseni Hakkında

Singleton tasarım deseni, yazılım tasarımında sıkça kullanılan bir tasarım deseni olup, bir sınıfın yalnızca bir örneğine (instance) sahip olduğundan emin olmak için kullanılır. Bu desen, bir sınıfın tek bir örneğinin oluşturulmasını ve bu örneğe küresel bir erişim noktası sağlanmasını amaçlar. Singleton deseni genellikle bir nesnenin yalnızca bir kez oluşturulmasını ve bu nesneye bir noktadan erişim sağlanmasını istediğiniz durumlarda kullanışlıdır.

**Singleton tasarım deseninin temel avantajları şunlardır:**

- Tek Örnek: Sistemde yalnızca bir örnek oluşturulduğundan emin olunur. Bu durum, belirli bir sınıfın tek bir noktadan kontrol edilmesini sağlar.
- Global Erişim Noktası: Singleton deseni, oluşturulan tek örneğe genel bir erişim noktası sağlar. Böylece, bu örneğe her yerden kolayca erişilebilir.
- Kaynak Tasarrufu: Singleton deseni, örneği ilk oluşturulduğunda bellekte yer tutar ve her çağrıda yeni bir örnek oluşturmak zorunda kalmaz.

**Singleton tasarım deseni genellikle aşağıdaki yöntemlerden biriyle uygulanır:**

- Eager Initialization (İstekli Başlatma): Singleton örneği, program başladığında veya sınıf ilk kez yüklendiğinde hemen oluşturulur.
- Lazy Initialization (Tembel Başlatma): Singleton örneği, ihtiyaç duyulduğunda oluşturulur. Bu, örneğin gerektiği anda ve ilk defa çağrıldığında yaratılmasını sağlar.

### Factory Tasarım Deseni Hakkında

Factory tasarım deseni (Fabrika tasarım deseni), bir nesnenin oluşturulma sürecini sınıflardan ayırmayı amaçlayan bir creational tasarım desenidir. Factory tasarım deseni, nesne oluşturma işlemlerini bir alt sınıfa (fabrika sınıfına) devreder, bu sayede ana sınıf (istemci sınıf) nesnenin hangi tip ve nasıl oluşturulduğu konusundan bağımsız hale gelir. Bu desen, nesne oluşturma mantığını ana sınıftan ayırarak sınıflar arasındaki bağımlılığı azaltır ve kodun daha esnek, bakımı daha kolay ve genişletmeye daha açık olmasını sağlar.

**Factory tasarım deseninin temel bileşenleri şunlardır:**

- **Ürün (Product):** Oluşturulacak nesne türünü tanımlayan arayüz veya soyut bir sınıftır.
- **ConcreateProduct:** Ürün arayüzünü veya soyut sınıfını uygulayan gerçek nesne sınıf(lar)ıdır.
- **Creator (Creator):** Ürünlerin oluşturulması için soyut bir metot veya arayüz içerir. Bu sınıfın alt sınıfları, ürün nesnesinin türüne göre nesne oluşturmayı gerçekleştirir.
- **ConcreateCreator:** Creator sınıfını uygulayan ve belirli bir ürün türü için nesne oluşturan sınıftır.

### Prototype Tasarım Deseni Hakkında

- Amacımız nesne üretim maliyetlerini minimize etmektir. Her zaman kullanılması mümkün değildir, ihtiyaç dahilinde kullanabiliriz. Elimizdeki nesneyi kullanarak onun klonlarını oluşturabiliyoruz. Prototype tasarım deseni, creational tasarım desenlerinden biridir ve nesnelerin kopyalanmasını sağlamayı amaçlar. Bu desen, bir nesnenin prototipini kullanarak yeni nesneler oluşturmanın bir yolunu tanımlar. Yeni nesneler, mevcut bir nesnenin kopyası alınarak oluşturulur, bu da yeni nesnelerin özelliklerini veya durumlarını başlangıç nesnesinden alacakları anlamına gelir.

- Prototype tasarım deseni, özellikle nesne oluşturma maliyeti yüksek veya karmaşık olan durumlarda kullanışlıdır. Bu desen, sınıflar arasındaki bağımlılıkları azaltabilir ve nesnelerin daha dinamik bir şekilde oluşturulmasına olanak tanır.