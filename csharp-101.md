## C# 101

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/54f514e2-374e-431e-bb51-dfdcfef71133)


### C# Giriş

- C# (C-Sharp), Microsoft tarafından geliştirilen ve .NET Framework üzerinde çalışan bir programlama dilidir.
- C# web uygulamaları, masaüstü uygulamaları, mobil uygulamalar, oyunlar ve çok daha fazlasını geliştirmek için kullanılır.
- C# "C-Sharp" olarak telaffuz edilir.
- Microsoft tarafından oluşturulan ve .NET Framework üzerinde çalışan nesne yönelimli bir programlama dilidir.
- C#'ın kökleri C ailesine dayanır ve dil C++ ve Java gibi diğer popüler dillere yakındır.
- İlk sürüm 2002 yılında yayınlandı. En son sürüm olan C# 11, Kasım 2022'de piyasaya sürüldü.
- Mobil uygulamalar,Masaüstü uygulamaları,Web uygulamaları,Web hizmetleri,Web siteleri,Oyunlar,VR,Veritabanı uygulamaları gibi alanlarda aktif kullanılır.

### Neden C# Kullanmalı?
- Dünyanın en popüler programlama dillerinden biridir
- Öğrenmesi kolay ve kullanımı basit
- Büyük bir topluluk desteğine sahip
- C#, programlara net bir yapı kazandıran ve kodun yeniden kullanılmasına olanak tanıyarak geliştirme maliyetlerini düşüren nesne yönelimli bir dildir
- C#, C, C++ ve Java'ya yakın olduğu için programcıların C#'a geçişini veya tam tersini kolaylaştırır

### C# IDE
- C# ile çalışmaya başlamanın en kolay yolu bir IDE kullanmaktır.
- Kodu düzenlemek ve derlemek için bir IDE (Entegre Geliştirme Ortamı) kullanılır.
- https://visualstudio.microsoft.com/vs/community/ adresinden ücretsiz olarak indirebilirsiniz.
- C# ile yazılan uygulamalar .NET Framework'ü kullanır, bu nedenle program, çerçeve ve dil Microsoft tarafından oluşturulduğundan Visual Studio'yu kullanmak mantıklıdır.

### C# Syntax

"Hello World" yazdırmak için aşağıdaki kod kullanılır:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/4cba3bbe-a22f-4523-bd04-17764dc072ea)


- Satır 1: using System, System isim alanındaki sınıfları kullanabileceğimiz anlamına gelir.
- Satır 2: Boş bir satır. C# beyaz boşluğu yok sayar. Ancak, birden fazla satır kodu daha okunabilir hale getirir.
- Satır 3: namespace kodunuzu düzenlemek için kullanılır ve sınıflar ve diğer namespace'ler için bir konteynerdir.
- Satır 4: Küme parantezleri {} bir kod bloğunun başlangıcını ve sonunu işaret eder.
- Satır 5: sınıf, programınıza işlevsellik kazandıran veri ve yöntemler için bir kapsayıcıdır. C#'ta çalışan her kod satırı bir sınıfın içinde olmalıdır. Örneğimizde, sınıfa Program adını verdik.
- Satır 7: Bir C# programında her zaman görünen bir başka şey de Main yöntemidir. Küme parantezleri {} içindeki herhangi bir kod çalıştırılacaktır. Main'den önceki ve sonraki anahtar kelimeleri anlamak zorunda değilsiniz. 
- Satır 9: Console, System isim alanının bir sınıfıdır ve metin çıktısı almak/yazdırmak için kullanılan bir WriteLine() metoduna sahiptir. Örneğimizde "Merhaba Dünya!" çıktısı verecektir.
- Eğer using System satırını atlarsanız, metni yazdırmak/çıkarmak için **System.Console.WriteLine()** yazmanız gerekecektir.
- **Not:** Her C# deyimi noktalı virgül ; ile biter.
- **Not:** C# büyük/küçük harf duyarlıdır: "MyClass" ve "myclass" farklı anlamlara sahiptir.

### C# Yorum Satırları

Yorumlar, C# kodunu açıklamak ve daha okunabilir hale getirmek için kullanılabilir. Alternatif kodu test ederken yürütmeyi önlemek için de kullanılabilir.

#### Tek Satırlı Yorumlar
- Tek satırlı yorumlar iki ileri eğik çizgi (//) ile başlar.
- // ile satır sonu arasındaki herhangi bir metin C# tarafından yok sayılır (yürütülmez).
- Bu örnekte, bir kod satırından önce tek satırlık bir açıklama kullanılmaktadır:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b8075647-dabf-4e27-9373-2e691d05a6ef)

#### C# Çok Satırlı Yorumlar

- Çok satırlı yorumlar /* ile başlar ve */ ile biter.
- ** ve */ arasındaki herhangi bir metin C# tarafından yok sayılacaktır.
- Bu örnekte kodu açıklamak için çok satırlı bir yorum (yorum bloğu) kullanılmıştır:


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/1b41b18b-127d-49d3-b126-f347aad39b25)

### C# Değişkenleri

Değişkenler, veri değerlerini saklamak için kullanılan kaplardır. C#'ta farklı değişken türleri vardır (farklı anahtar kelimelerle tanımlanır), örneğin:

- **int** - 123 veya -123 gibi ondalıksız tam sayıları (tam sayılar) saklar
- **double** - 19.99 veya -19.99 gibi ondalıklı kayan nokta sayılarını saklar
- **char** - 'a' veya 'B' gibi tek karakterleri saklar. Char değerleri tek tırnak işaretiyle çevrelenir
- **string** - "Merhaba Dünya" gibi metinleri saklar. String değerleri çift tırnak ile çevrelenir
- **bool** - iki durumlu değerleri saklar: doğru veya yanlış

#### Değişken Bildirme (Oluşturma)

- Bir değişken oluşturmak için türünü belirtmeli ve ona bir değer atamalısınız.
- Burada type bir C# türüdür (int veya string gibi) ve variableName değişkenin adıdır (x veya name gibi). Eşittir işareti değişkene değer atamak için kullanılır.


**string türünde name adında bir değişken oluşturun ve ona "Kardel" değerini atama.**
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d5b22f08-b933-4987-8429-430c632565d5)

**int türünde myNum adında bir değişken oluşturun ve ona 61 değerini atama.**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c751aff6-32c0-41b8-a569-8b8c36ec4d97)

**Ayrıca bir değişkeni değer atamadan da bildirebilir ve değeri daha sonra atayabilirsiniz**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f54dedc7-3060-45cf-a29c-0f01b8823719)

**Mevcut bir değişkene yeni bir değer atarsanız, bu değerin önceki değerin üzerine yazılacağını unutmayın.**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/39a168f3-b974-4e80-954a-637bc1f94e80)

#### Diğer Tipler

Diğer türlerdeki değişkenlerin nasıl bildirileceğine dair bir gösterim aşağıdaki gibidir!


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/5c7303ad-769e-4243-b391-7ba5cc308e77)

#### Const Kavramı

Başkalarının (veya kendinizin) mevcut değerlerin üzerine yazmasını istemiyorsanız, değişken türünün önüne const anahtar sözcüğünü ekleyebilirsiniz.Bu, değişkeni değiştirilemez ve salt okunur anlamına gelen "sabit" olarak bildirecektir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/98b12ebf-e73a-4687-a72c-a144fe0d00e2)

**const** anahtar sözcüğü, bir değişkenin her zaman aynı değeri saklamasını istediğinizde kullanışlıdır, böylece başkaları (veya kendiniz) kodunuzu karıştırmaz. Genellikle sabit olarak anılan bir örnek PI (3.14159...) değeridir.

**Not:** Değer atamadan sabit bir değişken bildiremezsiniz. Bunu yaparsanız bir hata oluşur: Bir const alanı için bir değer sağlanması gerekir.

#### Ekran Değişkenleri

- WriteLine() yöntemi genellikle değişken değerlerini konsol penceresinde görüntülemek için kullanılır.
- Hem metni hem de bir değişkeni birleştirmek için + karakterini kullanmak gerekir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ae9a560e-6874-4d7e-8a60-08dbde1026f0)

**Bir değişkeni başka bir değişkene eklemek için + karakterini de kullanabilirsiniz:**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d530d895-f385-4273-96b1-dd0ffb5c05d5)

**Sayısal değerler için + karakteri matematiksel bir operatör olarak çalışır (burada int (tamsayı) değişkenleri kullandığımıza dikkat edin):**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b41366d9-4e09-4617-9fed-466b807e41b8)

**_Yukarıdaki örnekten şunu bekleyebilirsiniz:_**
- x, 5 değerini saklar
- y, 6 değerini saklar
Ardından, 5 olan x + y değerini görüntülemek için WriteLine() yöntemini kullanırız.

#### Birçok Değişken Bildirme

- Aynı türde birden fazla değişken bildirmek için virgülle ayrılmış bir liste kullanılabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fe2f35d1-0f17-46f2-99d2-987318467eb5)


- Aynı değeri tek bir satırda birden fazla değişkene de atayabilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/6580e022-e39e-48a7-8c09-2a8332ca5f2c)

#### C# Tanımlayıcıları

- Tüm C# değişkenleri benzersiz isimlerle tanımlanmalıdır.
- Bu benzersiz isimler tanımlayıcı olarak adlandırılır.
- Tanımlayıcılar kısa isimler (x ve y gibi) veya daha açıklayıcı isimler (age, sum, totalVolume) olabilir.
- **Not:** Anlaşılabilir ve sürdürülebilir kod oluşturmak için açıklayıcı isimler kullanılması önerilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/5338ce2b-d847-4da2-a3d7-70d40f1a34b3)

**Değişkenleri adlandırmak için genel kurallar şunlardır:**

- İsimler harfler, rakamlar ve alt çizgi karakteri (_) içerebilir
- İsimler bir harf veya alt çizgi ile başlamalıdır
- İsimler küçük harfle başlamalıdır ve boşluk içeremez
- İsimler büyük/küçük harfe duyarlıdır ("myVar" ve "myvar" farklı değişkenlerdir)
- Ayrılmış sözcükler (int veya double gibi C# anahtar sözcükleri gibi) ad olarak kullanılamaz



### C# Veri Tipleri

- C#'ta bir değişken belirtilen bir veri türünde olmalıdır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/19a86e24-fb9e-4654-a9f3-411b6561e053)

- Bir veri türü, değişken değerlerinin boyutunu ve türünü belirtir.
- İlgili değişken için doğru veri türünü kullanmak önemlidir; hatalardan kaçınmak, zamandan ve bellekten tasarruf etmek için, ancak aynı zamanda kodunuzu daha sürdürülebilir ve okunabilir hale getirecektir. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/2f52864d-7345-4d45-a948-88c7bba41128)

#### Sayılar

**_Sayı türleri iki gruba ayrılır:_**

- Tamsayı türleri, pozitif veya negatif (123 veya -456 gibi) tam sayıları ondalıklar olmadan depolar. Geçerli türler int ve long'dur. Hangi türü kullanmanız gerektiği, sayısal değere bağlıdır.
- Floating nokta türleri, bir veya daha fazla ondalık içeren kesirli kısmı olan sayıları temsil eder. Geçerli türler float ve double'dır.
- C#'ta birçok sayısal tür olmasına rağmen, sayılar için en çok kullanılan int (tam sayılar için) ve double (kayan noktalı sayılar için) türleridir.

##### Integer Türleri

**Int**
int veri türü -2147483648 ile 2147483647 arasındaki tam sayıları saklayabilir. Genel olarak ve dersimizde, int veri türü, sayısal değerli değişkenler oluştururken tercih edilen veri türüdür.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/e6fcafbd-6695-4c57-87f5-c80b363fcd82)

**Long**

Long veri türü -9223372036854775808 ile 9223372036854775807 arasındaki tam sayıları saklayabilir. Bu, int değeri saklamak için yeterince büyük olmadığında kullanılır. Değeri "L" ile bitirmeniz gerekmektedir. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/76b5e1a5-1277-4437-bb3e-7b67d625bf87)

##### Float Nokta Türleri

Ondalıklı bir sayıya ihtiyacınız olduğunda (9,99 veya 3,14515 gibi) float noktalı bir tür kullanmalısınız. Float ve double veri türleri kesirli sayıları saklayabilir. Değeri float için "F" ve double için "D" ile bitirmeniz gerekmektedir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7f49525a-447a-4165-a883-830032732170)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c418e1db-e6bb-4132-a983-10e33bd403fb)


**Float mı yoksa double mı kullanmalıyım?**

Bir kayan nokta değerinin hassasiyeti, değerin ondalık noktadan sonra kaç basamaklı olabileceğini gösterir. Float'ın hassasiyeti yalnızca altı veya yedi ondalık basamak iken, double değişkenlerin hassasiyeti yaklaşık 15 basamaktır. Bu nedenle çoğu hesaplama için **double** kullanmak daha güvenlidir.

##### Bilimsel Sayılar

Kayan nokta sayısı, 10'un kuvvetini belirtmek için bir "e" ile bilimsel bir sayı da olabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/022dc47d-6e94-4460-9576-9eca6b402270)


#### Booleans

Bir boolean veri türü bool anahtar sözcüğü ile bildirilir ve yalnızca true veya false değerlerini alabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/9739d94a-3399-4c32-9c4e-b3a798bfb9eb)

Boolean değerleri çoğunlukla koşullu testler için kullanılır.


#### Characters

char veri türü tek bir karakteri saklamak için kullanılır. Karakter, 'A' veya 'c' gibi tek tırnak işaretleriyle çevrelenmelidir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/84e440ce-f04b-423f-b6e8-0b8590c21b67)


#### Strings

Dize veri türü, bir karakter dizisini (metin) saklamak için kullanılır. Dize değerleri çift tırnak işaretiyle çevrelenmelidir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/044b316b-4116-41dd-aa9e-a4e3bbd99dec)


### C# Type Casting

- Tür atama, bir veri türündeki bir değeri başka bir türe atamanızdır.

_**C#'ta iki tür döküm vardır:**_

- Implicit Casting (otomatik olarak) - daha küçük bir yazıyı daha büyük bir yazı boyutuna dönüştürme
char -> int -> long -> float -> double
- Explicit Casting (manuel) - daha büyük bir tipi daha küçük boyutlu bir tipe dönüştürme
double -> float -> long -> int -> char

#### Implicit Casting

Daha küçük boyutlu bir türü daha büyük boyutlu bir türe geçirirken implicit casting otomatik olarak yapılır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/e0c7b3e9-8005-4a35-9c86-868a8c3fd962)

#### Explicit Casting

Explicit Casting, değerin önüne parantez içinde tür yerleştirilerek manuel olarak yapılmalıdır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/31316fe2-f27b-46a7-b47c-2c6870279c2d)


#### Tip Dönüştürme Yöntemleri

**Convert.ToBoolean**, **Convert.ToDouble**, **Convert.ToString**, **Convert.ToInt32 (int)** ve **Convert.ToInt64 (long)** gibi yerleşik yöntemleri kullanarak veri türlerini açıkça dönüştürmek de mümkündür.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/24dbfc4b-bdeb-4772-9bbb-e1d646846fca)

### C# User Input

- **Console.WriteLine()** işlevinin değerlerin çıktısını almak (yazdırmak) için kullanıldığını zaten öğrenmiştiniz.
- Kullanıcı girdisini almak için **Console.ReadLine()** kullanacağız.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/0d94ab3a-e590-4742-9680-4dde6df61d2c)

#### User Input and Numbers

- **Console.ReadLine()** yöntemi bir dize döndürür. Bu nedenle, int gibi başka bir veri türünden bilgi alamazsınız.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/852b84ed-ed04-4b85-a9de-0bcf44044ade)


**Not:** Yanlış girdi girerseniz (örneğin sayısal bir girdide metin), bir istisna/hata mesajı alırsınız (System.FormatException: 'Input string was not in a correct format.' gibi).


### C# Operatorler

- Operatörler, değişkenler ve değerler üzerinde işlem yapmak için kullanılır.
**Aşağıdaki örneklerde, iki değeri toplamak için + operatörünü kullanılmaktadır.**

  ![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/3a4582f0-ad97-4c3e-8b8a-9d20d9f2f886)


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7b38128c-13a8-48c8-85b5-cf22e6171f2c)


### C# Strings
#### String Birleştirme

- "+", dizeleri birleştirmek için dizeler arasında kullanılabilir. Buna birleştirme denir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a99d00c1-ba38-4d4d-b5b7-344e858a1066)

- _Yazdırma sırasında ad ve soyad arasında bir boşluk oluşturmak için "John" kelimesinden sonra bir boşluk eklediğimize dikkat edin._
- İki dizeyi birleştirmek için **string.Concat()** yöntemini de kullanabilirsiniz.
  
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/713c94f4-91ce-4312-94fe-30bdbf22c382)

#### C# String Interpolation

Dize birleştirmenin bir başka seçeneği de, değişkenlerin değerlerini bir dizedeki yer tutucuların yerine koyan dize enterpolasyonudur. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7d9682a3-076d-44ee-92b2-9a66984b1f25)

### C# If ... Else

- C#, matematiğin olağan mantıksal koşullarını destekler.
- Şundan daha az: a < b
- Daha az veya eşit: a <= b
- Şundan büyük: a > b
- Büyük veya eşit: a >= b
- a == b'ye eşittir
- Eşit Değil: a != b
- Farklı kararlar için farklı eylemler gerçekleştirmek üzere bu koşulları kullanabilirsiniz.

_**C# aşağıdaki koşullu ifadelere sahiptir:**_

- Belirtilen bir koşul doğruysa yürütülecek bir kod bloğu belirtmek için if kullanın
- Aynı koşulun yanlış olması durumunda çalıştırılacak bir kod bloğu belirtmek için else kullanın
- İlk koşulun yanlış olması durumunda test edilecek yeni bir koşul belirtmek için else if kullanın
- Yürütülecek çok sayıda alternatif kod bloğu belirtmek için switch kullanın

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/824d7bac-fd05-4f75-90d0-5880c7d986c9)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/9d79c42f-e356-45ed-b4db-fb918e990471)

#### Ternary Operator
Ayrıca, üç işlenenden oluştuğu için üçlü operatör olarak bilinen bir kısa el if else vardır. Birden fazla kod satırını tek bir satırla değiştirmek için kullanılabilir. Genellikle basit if else ifadelerinin yerine kullanılır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7c6874d8-7c34-45b6-9b95-b900660abb6b)


### C# Switch

Yürütülecek birçok kod bloğundan birini seçmek için switch deyimini kullanılabilir. 
Şimdi dizelerden oluşan bir dizi tutan bir değişken bildirdik.

Buna değer eklemek için bir dizi değişmezi kullanabiliriz - değerleri virgülle ayrılmış bir listeye, küme parantezleri içine yerleştirin:
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/082caafc-c0bb-4bb7-a7ac-47a0052e92e0)

- switch ifadesi bir kez değerlendirilir
- İfadenin değeri her bir durumun değerleriyle karşılaştırılır
- Bir eşleşme varsa, ilgili kod bloğu yürütülür
- C# bir break anahtar sözcüğüne ulaştığında switch bloğundan çıkar.
- Bu, blok içinde daha fazla kod ve durum testinin yürütülmesini durduracaktır.
- Bir eşleşme bulunduğunda ve iş bittiğinde, ara verme zamanı gelir.
- Varsayılan anahtar kelime isteğe bağlıdır ve büyük/küçük harf eşleşmesi olmadığında çalıştırılacak bazı kodları belirtir.

### C# While Loop
- while döngüsü, belirli bir koşul Doğru olduğu sürece bir kod bloğu boyunca döner.
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c13629ef-53ad-48fb-97ea-f69b3c3c0223)

### C# For Loop
Bir kod bloğunda tam olarak kaç kez döngü yapmak istediğinizi bildiğinizde, while döngüsü yerine for döngüsünü kullanabilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/dacf0767-8155-4125-b948-fa58cf2122b1)

### C# Arrays
- Diziler, her değer için ayrı değişkenler bildirmek yerine birden fazla değeri tek bir değişkende saklamak için kullanılır.
- Bir dizi bildirmek için, değişken türünü köşeli parantezlerle tanımlanır.
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a5b64454-8c3b-40cc-92ce-9fd943b88d74)

### C# Çok Boyutlu Diziler


Satırları ve sütunları olan bir tablo gibi verileri tablo biçiminde saklamak istiyorsanız, çok boyutlu dizilere aşina olmanız gerekir. Çok boyutlu bir dizi, temelde dizilerden oluşan bir dizidir.Diziler herhangi bir sayıda boyuta sahip olabilir. En yaygın olanları iki boyutlu dizilerdir (2D).


_**Tek virgül [,] dizinin iki boyutlu olduğunu belirtir. Üç boyutlu bir dizide iki virgül bulunur: int[,,].**_

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fab75833-daca-4958-b17e-3eecfb07d65d)