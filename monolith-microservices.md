![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/305fe91d-1ac4-463a-bb47-e476b3083538)# Monolith ve Microservices

Mikroservisler mimarisi yaklaşık 5-10 yıldan beri adını duyuran ve oldukça büyük şirketlerin iç yapılarında kullanmayı tercih ettikleri bir mimaridir. Mikroservis mimarisini daha iyi anlayabilmek için öncelikle diğer mimarileri biraz incelemek gerekmektedir.

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

**Monolotik Mimari Avantajları Nelerdir ?**

- Geliştirmesi basittir.
- Test edilebilirliği kolaydır. Modülleri tek bir projede geliştirildiği için tabii ki daha kolaydır.
- Deployment oldukça kolaydır çünkü tek bir projeyi deploy ediyorsunuz.
- Ölçeklendirme oldukça kolaydır. Yatay olarak mimarinin kopyasını Load balancer arkasında çalıştırabilirsiniz. Yatay bir sunucunun kopyasını alıp yanına koymaktır. Dikey ise varolan sunucunun kaynaklarını arttırmaktır(Diskini arttırmak vb.)

**Monolotik Mimari Dezavantajları Nelerdir?**

- Bakım proje büyüdükçe zorlaşır. Yüz tane modülünüz projeye kod yazmak yerine iki tane modüle kod yazmak arasında büyük bir fark vardır.
- Uygulamanın boyutu başlama süresini yavaşlatır. Monolitik bir uygulama kapandığında veya çalışmadığında tekrardan ayağa kaldırmak için belirli süreler beklemek gerekir. ( Eğer proje çok büyürse. )
- Uygulama güncelleneceği zaman tüm uygulamayı tekrardan deploy etmek gerekir. Yani User üzerinde geliştirme yaparsanız tek User üzerinde deploy etmek mümkün değildir. Tüm projeyi canlıya çıkmak gerekir. Uygulama büyüdüğü zaman bu biraz külfet haline gelebilir.
- Monolitik uygulamalar ölçeklendirileceği zaman sorun çıkartabilir. Uygulamanızın kesinlikle bazı sistem gereksinimleri olabilir. Yeni sunucu ölçeklendirmeye yapabileceğiniz sunucuda bunu veremezseniz,yaptığınız klon istediğiniz gibi çalışmayabilir.
- Ölçeklendirme tüm proje genelinde yapılır. Bir serviste yoğunluk olduğunda tüm projeyi dublicate etmek gerekebilir. Aslında yoğun olan servisi kopyalamam yeterli olacaktı ama uygulama monolitik olduğu için maalesef bu mümkün değil :-(
- Güvenilirlik,sağlamlık ve dayanıklık kısmında sıkıntı çıkabilir. Büyük bir proje kapsamında takım arkadaşı alacağınızı düşünün. Ancak uygulamada yeterli dokümantasyon yok. O nedenle uzun süreler takım arkadaşınızın takıma uyum sağlamasını bekleyeceksiniz. Aslında bu bir nevi zaman ve nakit kaybı olabilir. Bu şekildeki handikapları içeren bir mimariyi kullanmalı mıyız ? Monolitik mimari çok kötü bir mimari değil. Çünkü sektörün devleri de bir zamanlar monolitik mimariyle çalışıyordu. ( Amazon, Netflix, Twitter ) . Sonrasında başka başka mimarilere geçiş yaptılar. Proje büyüdükçe siz artık monolitik mimariden çıkabilirsiniz. Başlangıçta monolitik mimariyle başlayan projeler sonradan mikroservis mimarilerine evrilebilir.
  
<div align="center">
  <img src="https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/a3dda0e1-43d6-4804-95f3-512230673ad6" alt="Image 1" width="200"/>
  <img src="https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/e688b828-8a23-4125-90e8-cbd8a3befc95" alt="Image 2" width="200"/>
  <img src="https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/8ffd6d2a-d316-40d5-9e26-068afd8ce905" alt="Image 3" width="200"/>
</div>



#### SOA Architecture ( Service Roiented Architecture ) 

Servislerin ayrı ayrı tasarlanıp bir yapı oluşturmasını sağlar. Monolitik mimaride bir proje içerisinde projenin içerisinde servislerimiz bulunuyordu. Bunların her biri projenin bir controller dosyası olarak geçiyordu. Bunları bunun içerisinden monolitik mimaride çıkarabilmek mümkün değildir. O yüzden ilk hedeflediği nokta **"Servisleri ayırmak!"**.

![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/d0b6808a-16f0-451a-9164-eee815098a36)


**Peki bunların kontrollerini nasıl yapacağım ?**

- Özet olarak servislerin ayrı ayrı tasarlanıp bir yapı oluşturmasını sağlar.
- Yapılar birbirinden bağımsız olarak çalışabilirler. ( Loose Coupling. ) Loose Coupling düşük bağ anlamına geliyor . Birbirleriyle iletişimde olan servisler de olabilir, iletişimde olmayan servisler de olabilir.
- Birden çok sistemin yer aldığı yapılarda kullanılır.
- Kendi içerisinde birçok bileşeni vardır. ( Policies, Contracts, Sevices ve daha fazlası. ) Bu bileşenler oldukça yer kaplıyor.
- Dağıtık yazılım sistemlerinin kalitelerini arttırmayı hedefler. ( Tekrar Kullanılabirlik, Uyumluluk, Bakım Yeteneği) . Servisleri bir yapı oluşturmak için kullanılan bir mimaridir. Bu servisler kendi aralarında iletişim halinde olabilirler. Client üzerinden bir servise erişmek isterseniz direkt erişemezsiniz. Bunun için Enterprise Bus Service yapısı kullanılır. Bu yapıda clienttan gelen isteğe göre hangi servise gitmek istiyorsa onu ayarlar. Kendi içerisinde ve dış dünyayla kurdukları iletişim için web servislerden yararlanılmaktadır. Bu web servisler SOAP, WDS gibi yapılardan yararlanılabilir.

**SOA Avantajları nelerdir?**

- Servisler tekrar tekrar kullanılabilir.(Reusable) 
- Servislerin bakım ve onarım süreçler kolaydır. Çünkü koca projeyi değiştirmiyorsunuz o yüzden monolotiğe göre daha kolaydır.
- Güvenilirlik ve dayanıklık açısından iyidir. Servisler birbirinden farklı farklı projelerle ayrılmış oldukları için böyle bir sorunla karşılaşmazsınız.
- Up time oranları yüksektir.
- Yatay ve dikey ölçeklendirme yapabilirsiniz.( Servisler ayrı olduğu için servis bazlı kopyalama yapabilirsiniz. )
- Platform bağımsızdır. ( Bu mimarinin içerisindeki kullanmış olduğunuz servislerin dillerinin neyle yazılmış olduğu bağımsızdır.)
- Üretkenlik artacaktır. ( Yetkinliğiniz C# ise eğer işe başlayan kişi PHP biliyorsa servisi o dille yazıp geliştirebilir. Herhangi bir sıkıntı olmaz.)
  
**SOA Dezavantajları nelerdir?**

- Overload( Servisler kendi aralarında konuşurken SOAP gibi yapıları kullanırlar ve Enterprise kısmında yapılan validasyonlarda bu oldukça bir yük oluşturabilir.)
- Yüksek Maliyet
- Yüksek Bant Genişliği ( Oldukça büyük bir bant genişliğine ihtiyaç olabilir, bu da sunucuyu beraberinde getiriyor. )

#### Microservices Architecture

Mikroservisler mimarisi aslında bir mimari değildir. SOA da servislerin birbirinden ayrılmasını hedefleyen bir mimaride yazmayı bahsetmiştik. Mikroservisin de amacı farklı değil. Mikroservislerin de amacı büyük servisleri küçük serviscikler halinde gerçekleşmektir. O nedenle aslında SOA'nın bir yorumudur. Bir kalıba sokulmuş bir mimari değildir. 

- Her bir servis kendine ait bir dünyada çalışır. Soa'da bir sunucu üzerinde servisleri ayırıyorduk. Ancak mikroservislerde her bir servis kendi sunucusunda çalışacak. ( Server Stack )
- Kendine ait veri tabanları vardır. (Ee yok artık, kremasına bandık :-D )
- Sadece 1 küçük işi çok iyi yapması gerekir. ( Biraz I shaped misin acaba ? :) )
- Her bir farklı sunucu olursa nasıl iletişime geçilecek ? Api Gateway üzerinden dış ve iç dünyaya açılırlar. Gateway bir geçit bir kapı anlamına gelir. Bunu kod üzerinde de yapabilirsiniz. Ya da Reverse Proxy ile de yapabilirsiniz.
- Herhangi bir teknoloji ve dile ait bir kısıtlama olunamaz. ( İstersen A sunucusunda Ruby ve Mongo, diğerinde Dotnet ve Postgre kullanabilirsin.
- Staless yapılardır. ( Mikroservisin kendi sunucusu kendi veri tabanı vardır. Sunucu üzerinde bağımlı, sunucuya yazdığı bir dosya olmamalı. )
- Kolay ölçeklendirilebilir. (Dikey(gerek yok), yatay. ) Dikeye ihtiyacınız yok çünkü bir servisi gidip bir sunucu içerisine bir proje içerisine koyduğunuzda minimal anlamda bir küçük sunucu işinizi görebilir.
- Şematik olarak bağtığınızda Api Gateaway'in yaptığı şey ona gelen istekleri alıyor ve uygun sunuculara gönderiyor. Gönderdiğiniz Post ise bir JSON bilgisi gönderiyor. Api Gateaway de Client'a bu JSON'u gönderiyor.
- Api Gateaway ve mikroservisler arasındaki iletişim JSON ile gerçekleşmektedir. Ancak bunu siz belirleyebilirsiniz. Daha kolay ve hızlı gerçekleştirebilirsiniz. Bu yüzden JSON döndüren servislerin hangi dilde yazıldığı ve hangi veri tabanını kullandığı hiç önemli değildir. Bu sayede hem servisleri ayırabilmiş olduk hem de farklı teknolojiler kullanabileceğini öğrenmiş olduk.

**Mikroservislerin Avantajları**

- Çok dilli mimari
- Kolay ölçeklendirme 

**Mikroservislerin Dezavantajları**





![image](https://github.com/KardelRuveyda/dotnet-yuzuncuyil-egitim-notlari/assets/33912144/974b2648-8756-47b6-b53f-d7d6792b9b6a)





