# Dotnet Core Temelleri
## Entity Framework Nedir ?

Hafif, genişletilebilir ve open source olan veri erişim teknolojisidir. Microsoft tarafından geliştirilmektedir.
EF Core kullanırken sıklıkla karşımıza çıkacak iki ifade vardır. 

- ORM (Object-Relational Mapping)
- LINQ (Language Integrated Query)

**ORM:** Veri tabanına erişim tekniğidir. OOP'nin tüm nimetlerinden faydalanarak veri tabanlarına karşı queryler oluşturmamızı sağlar. ( Create,update,delete vb.)
Bu ORM tekniği altında birçok veri erişim teknolojisi vardır. Mini ORM olarak ifade edilen Dapper  veri erişim teknolojisidir. 
**Linq:** C# 3.0 ile hayatımıza giren sorgular oluşturmamıza imkan veren bir teknolojidir. EF core vE linq birbirini tamamlayan teknolojilerdir. Örneğin C# dilindeki collectionlara karşı Queryler oluşturabiliyorsunuz(List,Linked List,Dictionary). Bunlara karşı sorgular oluşturabiliyrsunuz ve bunları tip güvenli olarak gerçekleştirebilirsiniz. Linq ve EF Core farklı teknolojilerdir. EF core veri erişim teknolojisidir. Sorguların SQL cümleciğine çevrilmesi, veri tabanına gönderilmesi, veri tabanından gönderilen datanın Linq tarafında belirtilen tiplere maplenmesi gibi tüm süreçler EF Core tarafından yönetilmektedir. Linq sadece tip güvenli sorgular oluşturmamıza imkan vermektedir. 


