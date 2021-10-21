# SOLID PRENSİPLERİ

SOLID,iyi bir yazılım mimarisi oluşturmaya yarayan 5 temel ilkedir.

- Bu ilkelerin amacı yazılan kodların okunabirliliğini arttırıp daha anlaşılır hale getirmek,güncellenmesini kolaylaştırmak ve esnek bir kod yapısı oluşturmaktır.Temelinde Object Oriented Programming (L)iskov Substitution Principle (Liskov’un yerine geçme prensibi)bulunmaktadır. 


 ## [S-ingle Responsibility Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/1.Single_Responsibility_Principle)

“Tek Sorumluluk” anlamına gelen bu prensipte amaç; geliştirilen projede bir güncelleme veya değişiklik yapılması istendiğinde kodların içinde kaybolmadan, yalnızca ilgili metoda giderek istenilen değişikliğin yapılmasının sağlanmasıdır.Yani; bir fonksiyona birden fazla iş verip onu birçok işten sorumlu tutmak yerine, her bir iş için ayrı bir metot oluşturmalı ve ilerleyen zamanlarda bir değişiklik yapılacağında da kolaylıkla ilgili metoda giderek gerekli değişiklikleri yapabilmemiz gerekmektedir.

## [O-pen Closed Prenciple](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/2.Open_Closed_Principle)

Bu prensibe göre uygulamada bulunan yazılım varlıkları geliştirilmeye açık ancak kod değişimine kapalıdır.Yani bir nesne davranışını değiştirmeden yeni özellikler kazabiliyor olmalıdır. Bu prensip, sürdürülebilir ve tekrar kullanılabilir yapıda kod yazmanın temelini oluşturur.

## [L-iskov Substitution Principle](https://github.com/ezgiyaman/SoftwarePrinciples/tree/master/3.Liskov_Substitution%20_Principle)

Bu prensip,alt sınıflardan oluşan nesnelerin üst sınıftaki nesnelerle değiştirildikleri zaman aynı şekilde davranmasını, böylece alt sınıflarda oluşturulan nesnelerin üst sınıfların nesneleri ile değiştirilebilir olmasını beklemektedir.
