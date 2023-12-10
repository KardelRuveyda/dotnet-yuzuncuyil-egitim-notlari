# Monolith ve Microservices

Mikroservisler mimarisi yaklaşık 5-10 yıldan beri adını duyuran ve oldukça büyük şirketlerin iç yapılarında kullanmayı tercih ettikleri bir mimaridir. Mikroservis mimarisini daha iyi anlayabilmek için öncelikle diğer mimarileri biraz incelmeek gerekmektedir.

### 1- Monolithic Architecture
### 2- SOA Architecture
### 3- Microservices Architecture

#### Monolithic Architecture

İsimleme olarak bilmeseniz de aslında Monolitik mimariyi günlük projelerinizde kullanıyor olabilirsiniz. Clientlarınız olduğunu düşünün(sunucuya istekleri atan ) ve sunucunuz var . Bu sunucunuz da bir databaseye bağlanıyor. Örneğin Twitter gibi bir web sitesinde hem mobilde hem de webde çalışma düzenleri var. Siz gidip bir tane postu görmek istediğinizde sunucuya bunun isteğini gönderirsiniz. Aynı şekilde resim veya video görüntlemek için de bu istekleri sunucuya gönderirsiniz. Bu sunucu üzerinde çalışan proje bu veriyi getirebilmek için bunu databaseye sorması gerekir ve veri tabanına gider. Veri tabanından gelen datayla birlikte ekranda postları,iletileri vb göstermiş oluyor. Bu yapı da monolitik mimari olarak geçmektedir. Özetle bir proje üzerinden tüm aksiyonları ürettiğiniz bir proje mimarisi yapısıdır. 

Sadece sunucu kısmını düşünelim, bu sunucu kısmında neler var ?

**Monolitik mimari de sizin sunucunuzda 3 adet katman vardır.**

![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/5ee04f1d-ce4a-4255-b361-610ef6cb79e3)


- **Presentation Layer**

Presentation Layer katmanı adından da anlayabileceğimiz gibi sunum katmanıdır. Kullanıcının gördüğü kodları oluşturduğunuz durumdur. Yani User Interfacedir.

- **Business Layer**
  
Bizim normalde mantıksal işlemleri yaptığımız yerdir. Açıkçası kodları yazdığımız bölümdür. Clienttan bir istek geldiğinde Business Layer içerisinde işlerin yapılma işlemi gerçekleşir. Ancak Business kısmında veri tabanına bağlanmamızı gerektiren işlemler olursa bu kısımda Data Access Layer içerisinde bu işlemi gerçekleştirir. 

- **Data Access Layer**

veri tabanına bağlanma işlemleri için ise bu katman kullanılır. Modellerle beraber veri tabanına atılır ve  buradan alınan bilgiler Business katmanına aktarılır. Oradan da Presentation Layer'a aktarılarak kullanıcıların görmeleri sağlanır. 

_**Bu kullanımda bir problem yok ama Twitter gibi bir yapıyı Monolith mimari de çalışırsan neler olur ?**_

- Post getirmek için ana sayfaya istek atarsın. Ancak bu endpoint üzerine gelen trafik artmaya başlar. Twitter'ın ana sayfası mı yoksa sizin hesabınızın kullanıcı adınızı değiştirdiğiniz kısım mı ? Tabii ki de ana sayfa :)
- Böyle bir durumda bu yapıyı ölçeklendirmek istersek sunucuyu dublicate etmeniz gerekebilir.

_**E-Ticaret sitesi örneği üzerinden ilerleyelim;**_

- Sizin bir sunucunuz olsun. Yukarıdaki gibi katmanlarınız olsun. Monolith bir uygulamanız application server içerisinde çalışıyorsa ( Java,php,c# olsun.)
- Bu e-ticaret sitesi örneğinde birçok servisiniz olsun. (**ProductService**,**AccountingService**,**PaymentService** vb.). Bu servislerin içinden yoğun olarak trafik alan servis Productservice olsun. Kitlenmeye başlayan bu serviste veri tabanı sorgularına yetişemez oldunuz ve kaynaklar yetersiz gelmeye başladı. Bu durumda ölçeklendirmek gerekebilir. O nedenle bu kısımda sunucunun snapshotunu alıp kopyalama işlemi gerçekleştiriyorsunuz . Yani 8080 'de çalışıyorsa 8081 de çalışan bir sunucu daha oluşturuyorsunuz. Bu durumda ölçekleme gerçekleştikten sonra buradaki yük dağılımı nasıl gerçekleşir ?  Bu işlemi gerçekleştirmek için **LoadBalancer** yapısını kullanırsınız.

**Pekala Load Balancer nedir ?**

Client üzerinden gelen istekleri duruma göre sunucular arasında paylaşmayı hedefler. Benim yoğunluğum ProductService'de olmasına rağmen tüm sunucuyu dublicate ettim. Bu da monolithic mimarideki bir dezavantajdır. :(

![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/c0993a88-91d9-4e69-b852-82d8f827579e)


#### SOA Architecture

#### Microservices Architecture



