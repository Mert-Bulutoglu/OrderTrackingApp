# OrderTrackingApp
-TABLO AÇIKLAMALARI-
PRODUCT TABLOSU

![image](https://user-images.githubusercontent.com/107191110/211139822-cd0fa545-d67b-4fd9-9f5b-9e84b1944050.png)

-Product ve Company Tabloları arasında One to Many ilişkisi vardır.

Code first yaklaşım gösterimi ;

![Screenshot 2023-01-07 104324](https://user-images.githubusercontent.com/107191110/211139936-751d9fbb-c06f-4cbe-8aa3-9b29c8725c5b.png)

ORDER TABLOSU

![image](https://user-images.githubusercontent.com/107191110/211139997-39f99012-80fc-4ff7-8d7f-1e22ccaf1b80.png)

-Order ve Company arasında One to Many  ve Order ile Product arasında da One to Many ilişkisi vardır.

Code first yaklaşım gösterimi ;

![Screenshot 2023-01-07 104632](https://user-images.githubusercontent.com/107191110/211140042-a31c6f43-2a2a-40b7-b3ca-585a8722878c.png)

COMPANY TABLOSU

![image](https://user-images.githubusercontent.com/107191110/211140112-4d869e4e-0257-47f4-9b85-9c8a4393bbea.png)


Company tablosu many to one özelliği taşıdığından bu kısımda bağlantı işareti kullanmamıza gerek yoktur. Entity Framework bu ilişkinin Many to One olduğunu otomatik sağlayacaktır.

Code first yaklaşım gösterimi ;

![image](https://user-images.githubusercontent.com/107191110/211140138-3bd3ce26-8e45-4d35-9f34-a6f7f2013ec1.png)

KULLANILAN TEKNOLOJİLER

.NET Core 6 API

MSSQL

Swagger UI

Entity Framework Code First

Repository Design Pattern

YAPILAN SERVİSLER

FİRMA SERVİSLERİ

![image](https://user-images.githubusercontent.com/107191110/211140252-5cdd4757-01f9-44d0-8aac-35451525c1aa.png)

FİRMA EKLEME

![image](https://user-images.githubusercontent.com/107191110/211140306-f78f1cf5-1939-4d48-b2b6-7ffa8ffc39d1.png)  --->   

![image](https://user-images.githubusercontent.com/107191110/211140275-4ffe5ed2-f33e-4a87-bbdb-cd3d8e207542.png)

FİRMA GÜNCELLEME

![image](https://user-images.githubusercontent.com/107191110/211140371-3dc9e827-ba9b-43c9-994c-1e60450fe940.png)

![image](https://user-images.githubusercontent.com/107191110/211140378-a93e28eb-2686-43ca-b75f-beffec72f80c.png)

FİRMA LİSTELEME

![image](https://user-images.githubusercontent.com/107191110/211140401-3302ddea-359b-46e6-ad62-d660ea22d5d9.png)

PRODUCT SERVİSLERİ

![image](https://user-images.githubusercontent.com/107191110/211140420-f79ce8f0-9b69-414f-b882-ed85634528e2.png)

![image](https://user-images.githubusercontent.com/107191110/211140425-a80fee07-274e-4da1-9460-53c6e095c4fc.png)

ORDER SERVİSLERİ

Bu kısımda 2 adet kontrol sağlandı;

1. si eğer order eklerken company verified değeri false ise bu company den sipariş verilemez.

![image](https://user-images.githubusercontent.com/107191110/211140479-6a6a9ad8-c975-4cb0-83e6-9d995b8d572c.png)

Order oluşturmaya çalıştığımız şirketin isVerified değeri false ;

![image](https://user-images.githubusercontent.com/107191110/211140561-5f535998-bba2-40a6-a99a-69fb45c315c7.png)

Order oluşturmaya çalıştığımız şirketin isVerified değeri true ;

![image](https://user-images.githubusercontent.com/107191110/211140676-07cf8ff5-6a8e-4b14-b5c7-791d7e255c80.png)




2. si order eklerken order ın entity si olan OrderDate, Company nin entity si olan permissionStartDate ve permissionEndDate aralığında olursa sipariş verilebilir.
Eğer bu aralıkta değilse sipariş verilemez

İstek yapmaya çalıştığımız şirketin sipariş izin saatleri 08:45:00 ile 16:45:00 arası

Öncelikli olarak sipariş başlangıç saati öncesinde değer giriyorum;

![image](https://user-images.githubusercontent.com/107191110/211140737-01d0aff1-dd54-4644-b14e-4db23300f3a4.png)

![image](https://user-images.githubusercontent.com/107191110/211140748-5663bf55-5a72-4f2d-a8ba-9be3cbfb761a.png)

Sipariş bitiş saati sonrasında değer giriyorum;

![image](https://user-images.githubusercontent.com/107191110/211140762-ba14d065-0868-4992-a885-c7342585aa6f.png)

![image](https://user-images.githubusercontent.com/107191110/211140766-3623e1e1-0ea5-47be-b902-5016dc16fdf8.png)

Eğer bu aralık arasında istek atarsak sonucumuz olumlu olacaktır;

![image](https://user-images.githubusercontent.com/107191110/211140782-edeca8a5-8b42-4a1f-8b6b-311d3a638d2b.png)

![image](https://user-images.githubusercontent.com/107191110/211140791-04b2df20-a50f-4b7b-9069-cdf5ea10be3b.png)


ÖNEMLİ NOT : Sipariş verilirken product ve company değerleri aynı girilmelidir. Örneğin product entity sinin içerisinde company id bulunduğundan
istek atılırken birbirleriyle eşleştirilmiş id ler girilmelidir aksi halde program hata fırlatır.





