# Monolith ve Microservices

Mikroservisler mimarisi yaklaşık 5-10 yıldan beri adını duyuran ve oldukça büyük şirketlerin iç yapılarında kullanmayı tercih ettikleri bir mimaridir. Mikroservis mimarisini daha iyi anlayabilmek için öncelikle diğer mimarileri biraz incelmeek gerekmektedir.

## 1- Monolithic Architecture
## 2- SOA Architecture
## 3- Microservices Architecture

### Monolithic Architecture

İsimleme olarak bilmeseniz de aslında Monolitik mimariyi günlük projelerinizde kullanıyor olabilirsiniz. Clientlarınız olduğunu düşünün(sunucuya istekleri atan ) ve sunucunuz var . Bu sunucunuz da bir databaseye bağlanıyor. Örneğin Twitter gibi bir web sitesinde hem mobilde hem de webde çalışma düzenleri var. Siz gidip bir tane postu görmek istediğinizde sunucuya bunun isteğini gönderirsiniz. Aynı şekilde resim veya video görüntlemek için de bu istekleri sunucuya gönderirsiniz. Bu sunucu üzerinde çalışan proje bu veriyi getirebilmek için bunu databaseye sorması gerekir ve veri tabanına gider. Veri tabanından gelen datayla birlikte ekranda postları,iletileri vb göstermiş oluyor. Bu yapı da monolitik mimari olarak geçmektedir. Özetle bir proje üzerinden tüm aksiyonları ürettiğiniz bir proje mimarisi yapısıdır. 

Sadece sunucu kısmını düşünelim, bu sunucu kısmında neler var ?

Monolitik mimari de sizin sunucunuzda 3 adet katman vardır. 
- Presentation Layer

Presentation Layer katmanı adından da anlayabileceğimiz gibi sunum katmanıdır. Kullanıcının gördüğü kodları oluşturduğunuz durumdur. Yani User Interfacedir.

- Business Layer
Bizim normalde mantıksal işlemleri yaptığımız yerdir. Açıkçası kodları yazdığımız bölümdür. Clienttan bir istek geldiğinde Business Layer içerisinde işlerin yapılma işlemi gerçekleşir. Ancak Business kısmında veri tabanına bağlanmamızı gerektiren işlemler olursa bu kısımda 

- Data Access Layer



### SOA Architecture

### Microservices Architecture



