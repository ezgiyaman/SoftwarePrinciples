# SOLID PRENSİPLERİ

SOLID,iyi bir yazılım mimarisi oluşturmaya yarayan 5 temel ilkedir.

- Bu ilkelerin amacı yazılan kodların okunabirliliğini arttırıp daha anlaşılır hale getirmek,güncellenmesini kolaylaştırmak ve esnek bir kod yapısı oluşturmaktır.Temelinde Object Oriented Programming (L)iskov Substitution Principle (Liskov’un yerine geçme prensibi)bulunmaktadır. 


## [S-ingle Responsibility Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/1.Single_Responsibility_Principle)

“Tek Sorumluluk” anlamına gelen bu prensipte amaç; geliştirilen projede bir güncelleme veya değişiklik yapılması istendiğinde kodların içinde kaybolmadan, yalnızca ilgili metoda giderek istenilen değişikliğin yapılmasının sağlanmasıdır.Yani; bir fonksiyona birden fazla iş verip onu birçok işten sorumlu tutmak yerine, her bir iş için ayrı bir metot oluşturmalı ve ilerleyen zamanlarda bir değişiklik yapılacağında da kolaylıkla ilgili metoda giderek gerekli değişiklikleri yapabilmemiz gerekmektedir.

## [O-pen Closed Prenciple](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/2.Open_Closed_Principle)

Bu prensibe göre uygulamada bulunan yazılım varlıkları geliştirilmeye açık ancak kod değişimine kapalıdır.Yani bir nesne davranışını değiştirmeden yeni özellikler kazabiliyor olmalıdır. Bu prensip, sürdürülebilir ve tekrar kullanılabilir yapıda kod yazmanın temelini oluşturur.

## [L-iskov Substitution Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/3.Liskov_Substitution%20_Principle)

Liskov’un yerine geçme prensibi alt sınıflardan oluşturulan nesnelerin üst sınıfların nesneleriyle yer değiştirdiklerinde aynı davranışı göstermek zorunda olduklarını söyler. Yani; türetilen sınıflar,türeyen sınıfların tüm özelliklerini kullanmak zorundadır.

## [I-nterface Segregation Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/4.Interface_Segregation_Principle)

Arayüz ayırım prensibi, bir arayüze gerektiğinden fazla yetenek eklemememiz gerektiği söylemektedir.Bu prensibe göre,herbir interface’in belirli bir amacı olmalıdır. Tüm metodları kapsayan tek bir interface kullanmak yerine, herbiri ayrı metod gruplarına hizmet veren birkaç interface tercih edilmektedir.

## [D-ependency Inversion Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/5.Dependency_Inversion%20_Principle)

Bu prensip, bileşenler arasındaki bağımlılıklarla ilgilidir ve bu prensibe göre;

* Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara dayanmalıdır.

* Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır.

Basit bir deyişle, yazılımın bileşenleri arasında sıkı bir bağlantı olmaması gerektiğini ve bundan kaçınmak için bileşenlerin soyutlamaya bağlı olması gerektiğini söylemektedir.

## [DRY-DON'T REPEAT YOURSELF](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/DRY_Principle)
Yazılım kalıplarının tekrarlanmasını ve buna bağlı olarak ortaya çıkabilecek fazlalıkların karmaşıklığın önlenmesini amaçlayan yazılım geliştirme ilkesidir. 
* Dry Prensibi ; Her bilginin bir sistem içinde tek ve kesin yetkili bir temsili ile var olması gerektiğini vurgulamaktadır. Bu prensibe göre kodu tek bir yerde yazıp onu diğer yerlerde kullanılabilir hale getirmek gerekmektedir.
Eğer daha önce yazılmış bir kod ya da kod bloğunu tekrar kullanmaya ihtiyacımız olursa; mevcut kodu bir fonksiyona,sınıfa,metoda dönüştürerek eski kullanılan yeri bu noktaya bağlayıp, sonrasında yeni yazacağımız kodlarda da bu merkezileştirdiğimiz nokta üzerinden kullanmamız gerekmektedir.


