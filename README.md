# Kütahya Belediye Uygulaması
Not:
Kütahya Belediye Uygulaması, C# Forms ile yazılmış ve genel bir fikir oluşturması için bir taslak olarak sunulmaktadır. Gerçek kullanım için uyarlanması, geliştirilmesi ve iyileştirilmesi gerekmektedir.

## Ana Form - Online Tahsilat Çözüm Masası, Şehir Kameraları, Ulaşım, Hal Fiyatları

![Ana Form](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/4feb30f9-bd08-4947-b3c7-0c99b8f14084)

Ana form, Kütahya Belediye Uygulaması'nın başlangıç noktasıdır. Bu sayfada online tahsilat çözüm masası, şehir kameraları, ulaşım bilgileri ve hal fiyatları gibi çeşitli bilgiler bulunmaktadır.

## Giriş Sayfası

![Giriş Sayfası](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/9dbfec7e-f0ff-4591-ba71-f8c0bb5316f1)

Giriş sayfası, kullanıcıların Kütahya Belediye Uygulaması'na giriş yapabilecekleri bir arayüzdür. Kullanıcı adı ve şifreyle sisteme giriş yapılabilir.

## Şikayet Başvuru

![Şikayet Başvuru](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/2b177d1f-7999-470a-b093-3262869fc753)

Bu sayfa, kullanıcıların Kütahya Belediyesine şikayet başvurusunda bulunabilecekleri bir form sunar. Kullanıcılar, şikayetlerini detaylı bir şekilde belirterek başvuruda bulunabilirler.

## Vergi Ödeme

![Vergi Ödeme](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/c8d6f3b5-b660-42de-b1d6-4390815a2e87)

Bu sayfa, kullanıcıların vergi ödemelerini online olarak gerçekleştirebilecekleri bir platform sunar. Kullanıcılar, vergi bilgilerini girerek ödeme işlemlerini tamamlayabilirler.

## Ödeme İşlemleri

![Ödeme İşlemleri](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/7abdcf8d-7827-4a81-a46e-c9c48612c6af)

Bu sayfa, kullanıcıların çeşitli ödeme işlemlerini gerçekleştirebilecekleri bir arayüz sağlar. Kullanıcılar, kart bilgilerini girebilir, CVC, tarih gibi detayları yazabilir ve bu bilgileri girdikçe kart arayüzünde eşzamanlı olarak görüntülenir.

## 360 Görünüm

![360 Görünüm](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/9986d0d6-ce1c-49e7-9e33-db9e0ed0faf2)

Bu sayfa, Kütahya'nın farklı bölgelerinin 360 derece görünümlerini sunar. Kullanıcılar, bu görünümleri keşfedebilir ve ilgi duydukları bölgeleri inceleyebilirler.

## Hava Durumu

![Hava Durumu](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/826d42a1-e3df-44a7-9abc-afced561b88e)

Bu sayfa, Kütahya'nın güncel hava durumu bilgilerini sunar. Kullanıcılar, hava durumu raporunu görebilir ve gelecek günler için tahminlere erişebilirler.

## Admin Paneli

![Admin Paneli](https://github.com/nihatxp/Belediye-Uygulamasi/assets/87497469/4355a1cc-a67b-4e53-8299-4a2069c18db3)

Bu sayfa, yöneticilerin Kütahya Belediye Uygulaması'nı yönetmek için kullandıkları bir panele erişim sağlar. Yöneticiler, kullanıcıları yönetebilir, içerikleri düzenleyebilir ve diğer yönetimsel işlemleri gerçekleştirebilirler.

## MySql Veritabanı Konfigürasyonu:

Ayarları değiştimek için program.cs dosyasına bakabilirsiniz.

```csharp
string server = "127.0.0.1";
int port = 3306;
string uid = "root";
string password = "secret";
string database = "belediye_uygulamasi";
```
<hr/>

Görselleştirme için Guna Framework kullanılmıştır.
