# OrderTrackingApp
-TABLO AÇIKLAMLARI-
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

![image](https://user-images.githubusercontent.com/107191110/211140125-a6b58a4a-a8e7-4fbb-ba6f-0d89507577a7.png)


