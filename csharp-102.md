## C# 102


### C# Methodlar

- Bir yöntem, yöntemin adı ve ardından gelen parantez () ile tanımlanır.
- C#, Main() gibi zaten aşina olduğunuz bazı önceden tanımlanmış yöntemler sağlar, ancak belirli eylemleri gerçekleştirmek için kendi yöntemlerinizi de oluşturabilirsiniz.


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a200a5ea-2c50-4721-a4f7-075413747ae7)


#### Çoklu Parametreler

İstediğiniz kadar parametreye sahip olabilirsiniz, sadece virgülle ayırılır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/368728e6-0376-4fb6-8ad6-31004a6b5f81)

#### Method Overloading

Yöntem aşırı yükleme ile, birden fazla yöntem farklı parametrelerle aynı ada sahip olabilir.Farklı türde sayıları toplayan iki yöntemi olan aşağıdaki örneği ele alalım.


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/55aa2eeb-b52d-4e5f-9cf7-283e72c4b3ea)

### C# Classlar

#### C# OOP

- OOP, Nesne Yönelimli Programlama anlamına gelir.
- Prosedürel programlama, veriler üzerinde işlemler gerçekleştiren prosedürler veya yöntemler yazmakla ilgiliyken, nesne yönelimli programlama hem veri hem de yöntemler içeren nesneler oluşturmakla ilgili

**Nesne yönelimli programlamanın prosedürel programlamaya göre çeşitli avantajları vardır:**

- OOP daha hızlıdır ve yürütmesi daha kolaydır
- OOP programlar için net bir yapı sağlar
- OOP, C# kodunun DRY "Kendini Tekrar Etme" özelliğini korumasına yardımcı olur ve kodun bakımını, değiştirilmesini ve hata ayıklamasını kolaylaştırır
- OOP, daha az kod ve daha kısa geliştirme süresi ile tamamen yeniden kullanılabilir uygulamalar oluşturmayı mümkün kılar
**İpucu:** "Kendini Tekrar Etme" (DRY) prensibi kod tekrarını azaltmakla ilgilidir. Uygulama için ortak olan kodları ayıklamalı ve bunları tek bir yere yerleştirmeli ve tekrarlamak yerine yeniden kullanmalısınız.


#### C# - Sınıflar ve Nesneler Nedir?

Sınıflar ve nesneler, nesne yönelimli programlamanın iki ana unsurudur. Sınıf ve nesneler arasındaki farkı görmek için aşağıdaki resme bakın:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c5535f82-8b4a-415a-8ef0-e633a7d498f9)


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/9b4b4afe-1aec-43d2-9401-a8df29d275fc)

#### Classlar ve Objeler

- C#'ta her şey, nitelikleri ve yöntemleriyle birlikte sınıflar ve nesnelerle ilişkilendirilir. Örneğin: gerçek hayatta bir araba bir nesnedir. Arabanın ağırlık ve renk gibi öznitelikleri ve sürüş ve fren gibi yöntemleri vardır.
- Bir sınıftan bir nesne oluşturulur. Car adlı sınıfı zaten oluşturduk, şimdi bunu nesne oluşturmak için kullanabiliriz. Bir Car nesnesi oluşturmak için sınıf adını ve ardından nesne adını belirtin ve new anahtar sözcüğünü kullanın:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ed7611ba-4a10-4398-84f1-9405914b2f01)

#### C# Class Members
Üç sınıf üyesi olan bir Car sınıfı oluşturun: iki alan ve bir yöntem.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/63f625d3-08fc-4f91-b846-85487f0e8d2c)

##### Fields

Sınıfın bir nesnesini oluşturarak ve nokta sözdizimini (.) kullanarak bunlara erişebilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/5c2abb45-ea94-445d-b0af-1e512840e9f7)


Ayrıca alanları boş bırakabilir ve nesneyi oluştururken bunları değiştirebilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f79875af-6e0a-4b19-94cc-9ff2dc55ce1c)


Bu özellikle bir sınıftan birden fazla nesne oluştururken kullanışlıdır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/6e080beb-19cd-4d89-9011-d22f9c01ef31)


##### Object Methods

Yöntemler normalde bir sınıfa aittir ve bir sınıfın nesnesinin nasıl davranacağını tanımlar.Tıpkı alanlarda olduğu gibi, metotlara da nokta sözdizimiyle erişebilirsiniz. Ancak, yöntemin public olması gerektiğini unutmayın. Ve yöntemi çağırmak (çalıştırmak) için yöntemin adını ve ardından iki parantez () ve bir noktalı virgül ; kullandığımızı unutmayın.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c73d38f6-73af-4633-9807-6ca55ad8649c)

#### Constructors

Yapıcı, nesneleri başlatmak için kullanılan özel bir yöntemdir. Bir kurucunun avantajı, bir sınıfın nesnesi oluşturulduğunda çağrılmasıdır. Alanlar için ilk değerleri ayarlamak için kullanılabilir.


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a78a2ac9-8a55-4c5b-bf91-b3f32d29ec9f)

- Constructor adının sınıf adıyla eşleşmesi gerektiğini ve bir dönüş türüne (void veya int gibi) sahip olamayacağını unutmayın.
- -Ayrıca, nesne oluşturulduğunda Constructor'ın çağrıldığına dikkat edin.
- Tüm sınıfların varsayılan olarak kurucuları vardır: kendiniz bir sınıf kurucusu oluşturmazsanız, C# sizin için bir tane oluşturur. Ancak, bu durumda alanlar için başlangıç değerlerini ayarlayamazsınız.

##### Constructor Parameters

Kurucular, alanları başlatmak için kullanılan parametreler de alabilir.Aşağıdaki örnek, kurucuya bir string modelName parametresi ekler. Yapıcının içinde modeli modelName olarak ayarlarız (model=modelName). Yapıcıyı çağırdığımızda, modelin değerini "Mustang" olarak ayarlayacak olan bir parametreyi ("Mustang") yapıcıya geçiririz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/4c2bef47-7175-438a-a463-571060e54f09)

İstediğiniz kadar parametreye sahip olabilirsiniz:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d101d7f7-4dc0-4be3-aa05-47151d2ba272)

#### C# Access Modifiers

**public**: Kod tüm sınıflar için erişilebilirdir
**private**: Koda yalnızca aynı sınıf içinde erişilebilir.
**protected**:	Koda aynı sınıf içinde veya bu sınıftan miras alınan bir sınıf içinde erişilebilir
**internal**	: Koda yalnızca kendi montajı içinden erişilebilir, ancak başka bir montajdan erişilemez

##### Private Modifier

Bir alanı private erişim değiştiricisi ile bildirirseniz, bu alana yalnızca aynı sınıf içinde erişilebilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/e49eb0a0-71cb-4c87-ac5d-620c42b5e801)

##### Public Modifier

Bir alanı public erişim değiştiricisiyle bildirirseniz, tüm sınıflar tarafından erişilebilir olur.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/eae836aa-e24d-4857-b2fa-308dfbdbc906)

**Not**: Bir erişim değiştirici belirtmezseniz, varsayılan olarak bir sınıfın tüm üyeleri (private)özeldir:


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fad28d7c-4a48-4be4-b13d-204510034523)


#### C# Properties (Get and Set)

Özellikleri açıklamaya başlamadan önce, "Kapsülleme" hakkında temel bir anlayışa sahip olmalısınız.

Encapsulation anlamı, "hassas" verilerin kullanıcılardan gizlendiğinden emin olmaktır. Bunu başarmak için şunları yapmalısınız:

- alanları/değişkenleri private olarak bildirme
- özel bir alanın değerine erişmek ve bu değeri güncellemek için özellikler aracılığıyla genel get ve set yöntemleri sağlama

##### Properties

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/10118ffe-6f2c-4111-a651-0311d96e9fcc)

- Name özelliği, name alanıyla ilişkilendirilir. Hem özellik hem de özel alan için aynı adın kullanılması, ancak ilk harfin büyük olması iyi bir uygulamadır.
- **get** yöntemi, değişken adının değerini döndürür.
- **set** yöntemi, name değişkenine bir değer atar. value anahtar sözcüğü, özelliğe atadığımız değeri temsil eder.


**Artık Person sınıfının özel alanına erişmek ve bu alanı güncellemek için Name özelliğini kullanabiliriz:**

##### Automatic Properties

- C# ayrıca, property için alan tanımlamak zorunda olmadığınız ve yalnızca property içine get; ve set; yazmanız gereken kısa el / otomatik özellikleri kullanmanın bir yolunu sağlar.

Aşağıdaki örnek, yukarıdaki örnekle aynı sonucu üretecektir. Tek fark daha az kod olmasıdır:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/10d14354-e422-4ad8-8ec3-8ed137442887)

##### Neden Kapsülleme?

- Sınıf üyelerinin daha iyi kontrolü (kendinizin (veya başkalarının) kodu karıştırma olasılığını azaltın)
- Alanlar salt okunur (yalnızca get yöntemini kullanırsanız) veya salt yazılır (yalnızca set yöntemini kullanırsanız) hale getirilebilir
- Esnek: programcı kodun bir bölümünü diğer bölümleri etkilemeden değiştirebilir
- Artırılmış veri güvenliği

#### C# Inheritance

- C#'ta, alanları ve yöntemleri bir sınıftan diğerine miras almak mümkündür. "Kalıtım kavramını" iki kategoride gruplandırıyoruz:
- Derived Class (child) - başka bir sınıftan miras alan sınıf
- Base Class(parent) - miras alınan sınıf
- Bir sınıftan miras almak için **:** sembolünü kullanın.

Aşağıdaki örnekte, Car sınıfı (alt), alanları ve yöntemleri Vehicle sınıfından (üst) devralır:


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/1f21867d-e876-4c5e-afc6-6e1a535fbda9)

**"Kalıtım" Neden ve Ne Zaman Kullanılır?**
- Kodun yeniden kullanılabilirliği için kullanışlıdır: yeni bir sınıf oluşturduğunuzda mevcut bir sınıfın alanlarını ve yöntemlerini yeniden kullanın.

#### C# Polimorfizm

- Polimorfizm "birçok biçim" anlamına gelir ve birbirleriyle kalıtım yoluyla ilişkili birçok sınıfımız olduğunda ortaya çıkar.
- Örneğin, animalSound() adında bir metodu olan Animal adında bir temel sınıf düşünün. Türetilmiş Hayvan sınıfları Domuzlar, Kediler, Köpekler, Kuşlar olabilir - Ve ayrıca kendi hayvan sesi uygulamalarına sahiptirler (domuz vınlar, kedi miyavlar, vb.):

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ce0c8dda-d906-4df3-9a36-4273c9b736e1)

- Şimdi **Pig** ve **Dog** nesnelerini oluşturabilir ve her ikisinde de **animalSound()** yöntemini çağırabiliriz:
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/cc557416-861f-42e0-8dd1-94463e0d3f5e)

**Aradığım Çıktı Değil**
- Yukarıdaki örneğin çıktısı muhtemelen beklediğiniz gibi değildi. Bunun nedeni, aynı adı paylaştıklarında temel sınıf yönteminin türetilmiş sınıf yöntemini geçersiz kılmasıdır.

Ancak C#, temel sınıf içindeki yönteme virtual anahtar sözcüğünü ekleyerek ve her türetilmiş sınıf yöntemi için override anahtar sözcüğünü kullanarak temel sınıf yöntemini geçersiz kılma seçeneği sunar.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/1e5cbf54-edbc-4cef-b324-61b1002a2f63)

**"Kalıtım" ve "Polimorfizm" Neden ve Ne Zaman Kullanılır?**
- Kodun yeniden kullanılabilirliği için kullanışlıdır: yeni bir sınıf oluştururken mevcut bir sınıfın alanlarını ve yöntemlerini yeniden kullanın.

### C# Abstraction

- Veri soyutlama, belirli ayrıntıları gizleme ve kullanıcıya yalnızca gerekli bilgileri gösterme işlemidir.
- Soyut anahtar sözcüğü sınıflar ve yöntemler için kullanılır:
**- Abstract Class:** nesne oluşturmak için kullanılamayan kısıtlı bir sınıftır (erişmek için başka bir sınıftan miras alınması gerekir).
**- Abstract Method:** yalnızca soyut bir sınıfta kullanılabilir ve bir gövdesi yoktur. Gövde, türetilmiş sınıf tarafından sağlanır (miras alınır).

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/076530db-ba89-4f21-9338-3bd157f7f85a)

- **Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')**
- Soyut sınıfa erişmek için başka bir sınıftan miras alınması gerekir. Polimorfizm bölümünde kullandığımız Animal sınıfını soyut bir sınıfa dönüştürelim.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/66208ac3-b476-4e87-94c1-159d79edfb64)

### C# Interfaces

- C#'ta soyutlama yapmanın bir başka yolu da interfacelerdir.
- Bir interface, yalnızca soyut yöntemler ve özellikler (boş gövdeli) içerebilen tamamen "soyut bir sınıftır":


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b06c3537-cbb9-4f3d-8555-9de4239538da)

- Bir arayüzün başında **"I"** harfi ile başlamak iyi bir uygulama olarak kabul edilir, çünkü kendinizin ve başkalarının bunun bir sınıf değil bir arayüz olduğunu hatırlamasını kolaylaştırır.
- Varsayılan olarak, bir arayüzün üyeleri soyut ve geneldir.

**Not:** Interfaceler özellikler ve yöntemler içerebilir ancak alanlar içeremez.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a46a4cb1-1070-417b-bcac-931558f0fc19)

**Interfaceler Hakkında Notlar:**
- Abstract sınıflar gibi, interfaceler de nesne oluşturmak için kullanılamaz (yukarıdaki örnekte, Program sınıfında bir "**IAnimal**" nesnesi oluşturmak mümkün değildir)
- Interface yöntemlerinin bir gövdesi yoktur - gövde "**implement**" sınıfı tarafından sağlanır
- Bir Interface uygulandığında, arayüzün tüm yöntemlerini geçersiz kılmanız gerekir
- Interface özellikler ve yöntemler Interface'nin , ancak alanlar/değişkenler içeremez
- Interface üyeleri varsayılan olarak abstract ve publictir
- Bir interface bir kurucu içeremez (nesne oluşturmak için kullanılamayacağı için)
**Arayüzler Neden ve Ne Zaman Kullanılır?**
1) Güvenliği sağlamak için - belirli ayrıntıları gizleyin ve bir nesnenin (arayüz) yalnızca önemli ayrıntılarını gösterin.
2) C# "çoklu kalıtımı" desteklemez (bir sınıf yalnızca bir temel sınıftan miras alabilir). Ancak, sınıf birden fazla arayüzü uygulayabildiği için arayüzlerle bu başarılabilir. Not: Birden fazla arayüz uygulamak için bunları virgülle ayırın (aşağıdaki örneğe bakın).


#### Multiple Interfaces
Birden çok arayüzü uygulamak için bunları virgülle ayrılarak eklenir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fa6077b2-b865-4b95-b01f-bd51d0a02f97)

### C# Enums
- Enum, bir grup sabiti (değiştirilemez/sadece okunabilir değişkenler) temsil eden özel bir "sınıftır".
- Bir enum oluşturmak için, enum anahtar sözcüğünü (sınıf veya arayüz yerine) kullanın ve enum öğelerini virgülle ayırın:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ffd4db85-1781-4002-bee9-fed5c2cfb33f)

### C# Exceptions - Try..Catch

- C# kodunu çalıştırırken farklı hatalar meydana gelebilir: programcı tarafından yapılan kodlama hataları, yanlış girdiden kaynaklanan hatalar veya diğer öngörülemeyen şeyler.
- Bir hata oluştuğunda, C# normalde durur ve bir hata mesajı oluşturur. Bunun teknik terimi şudur: C# bir istisna atar (hata verir).

#### C# try and catch

- try deyimi, yürütülürken hatalara karşı test edilecek bir kod bloğu tanımlamanıza olanak tanır.
- catch deyimi, try bloğunda bir hata oluşması durumunda çalıştırılacak bir kod bloğu tanımlamanıza olanak tanır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/95ee9ddb-45b2-49ca-9fd0-abf7151e3b8a)

#### Finally

**finally** deyimi, try...catch işleminden sonra sonuç ne olursa olsun kodu çalıştırmanızı sağlar.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/6a9378d5-0eca-4d95-81b7-70eee5d6aa12)


#### The throw keyword

- throw deyimi özel bir hata oluşturmanıza olanak tanır.
- throw deyimi bir exception sınıfı ile birlikte kullanılır.
- C#'ta birçok exception sınıfı mevcuttur: **ArithmeticException**, **FileNotFoundException**, **IndexOutOfRangeException**, **TimeOutException**, vb:


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fe5e4da1-c45d-4c3e-a7d4-23189727ffb8)

