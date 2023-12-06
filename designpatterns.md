# Design Patterns

Design pattern'lar, yazılım tasarımında sık karşılaşılan problemlere çözüm sunan tekrarlanabilir ve denenmiş pratiklerdir. Bu pattern'lar, yazılım geliştirme sürecinde daha okunabilir, sürdürülebilir, genişletilebilir ve yeniden kullanılabilir kod oluşturmanın yanı sıra, hataları minimize etmeye ve performansı optimize etmeye yardımcı olurlar. İşte design pattern'ların önemli olduğu bazı nedenler:

- **Kodun Anlaşılabilirliği:** Design pattern'lar, belirli bir problemi çözmek için belirli bir yaklaşımı takip eden genel bir çözüm sunar. Bu, yazılım geliştiricilerin kodu daha hızlı anlamalarına ve bakım yapmalarına olanak tanır.
- **Tekrar Kullanılabilirlik:** Design pattern'lar, genel problemler için genel çözümler sağladığından, bu pattern'ları kullanarak yazılmış kod parçalarını başka projelerde veya aynı projenin farklı yerlerinde tekrar kullanabilirsiniz.
- **Esneklik ve Genişletilebilirlik:** Design pattern'lar, gelecekteki değişikliklere ve genişletmelere uyum sağlamak için tasarlanmıştır. Bu sayede yazılım, yeni gereksinimlere veya özelliklere daha kolay adapte olabilir.
- **Hata Azaltma:** Design pattern'lar, genellikle test edilmiş ve doğrulanmış çözümler olduğu için hataları azaltmaya yardımcı olabilirler.
- **Topluluk Standartları:** Design pattern'lar, birçok yazılım geliştiricisi tarafından bilinen ve benimsenen çözümlerdir. Bir projede bu pattern'ları kullanmak, yazılım geliştiriciler arasında bir standart oluşturabilir.

Design pattern'ların sayısı belirli bir kesitte sınırlı değildir. Ancak, "Gang of Four" (GoF) olarak bilinen dört yazarın "Design Patterns: Elements of Reusable Object-Oriented Software" adlı kitaplarında tanımlanan 23 temel design pattern, en yaygın kullanılanlarıdır. Bu pattern'lar, Creational, Structural ve Behavioral olmak üzere üç kategoriye ayrılır. Ancak, zamanla yeni pattern'lar da geliştirilmekte ve kullanılmaktadır.

**Creational Design Patterns:**
- Singleton Pattern
- Factory Method Pattern
- Abstract Factory Pattern
- Builder Pattern
- Prototype Pattern


**Structural Design Patterns:**
- Adapter Pattern
- Bridge Pattern
- Composite Pattern
- Decorator Pattern
- Facade Pattern
- Flyweight Pattern
- Proxy Pattern


**Behavioral Design Patterns:**
- Chain of Responsibility Pattern
- Command PatternInterpreter Pattern
- Iterator Pattern
- Mediator Pattern
- Memento Pattern
- Observer Pattern
- State Pattern
- Strategy Pattern
- Template Method Pattern
- Visitor Pattern

**Not:** Bu eğitim kapsammında hepsini incelemek epey zor, o nedenle **Singleton**,**FactoryDesignPattern**,**AbstractFactory**,**Prototype** ve **Dependency Injection** patternlerini inceleyeceğiz. Fakat birçok pattern'i inceleyeceğim repoya [Design Patterns](https://github.com/KardelRuveyda/design-patterns-example-with-csharp) 'den ulaşabilirsiniz.


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

### Builder Tasarım Deseni Hakkında

Genellikle ortaya bir nesne ortaya çıkarmayı hedefler. Nesne örneği birbiri arkasına atılacak adımların sırasıyla işlenmeisyle ortaya çıkar. Genellike biz bunları iş katmanlarında veya arayüz katmanlarında ifle yazmak yerine ilgili üreticinin enkejte edilmesi ve ortaya bir nesnenin çıkarılması şeklinde uygulanır. Buuilder Design Pattern'i internet örneklerinde hamburger üretimine benzetilebilir. Hamburger bir nesneyse vejeteryanlar için bir hamburger veya vejetaryan olmayanlar için üretilecek hamburgerde belirli bir sırayla oluşmasını ve ortaya çıkmasını sağlayan bir yapıdır. 
