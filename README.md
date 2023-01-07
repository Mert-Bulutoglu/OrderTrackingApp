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

![image](https://user-images.githubusercontent.com/107191110/211140266-ebc3bef2-b432-4e75-b459-7396abeaabbf.png)    --- >    ![image](https://user-images.githubusercontent.com/107191110/211140275-4ffe5ed2-f33e-4a87-bbdb-cd3d8e207542.png)





