# Multi-Tenancy Yapısını Kullanan .NET Projesi

Bu proje, .NET platformu kullanılarak geliştirilmiş ve Multi-Tenancy yapısını benimseyen bir uygulamadır. Uygulama, aynı altyapıyı kullanarak birden fazla müşteriye hizmet vermek üzere tasarlanmıştır. Her müşteri için ayrı bir veritabanı kullanılarak veri izolasyonu sağlanmıştır.

## Kullanılan Teknolojiler ve Yapılar

- **.NET Core/.NET Framework**: Proje, .NET platformu üzerine inşa edilmiştir. .NET Core veya .NET Framework tercih edilebilir.
  
- **C#**: Uygulama kodları C# programlama dili kullanılarak yazılmıştır.
  
- **Dependency Injection (Bağımlılık Enjeksiyonu)**: .NET Core ve .NET Framework platformlarında yerleşik olarak bulunan Dependency Injection mekanizması kullanılmıştır. Bu mekanizma, bileşenler arasındaki bağımlılıkları azaltarak kodun test edilebilirliğini artırır.

## Proje Yapısı ve Mimari

Proje, katmanlı bir mimariye sahiptir ve temel katmanlar aşağıdaki gibidir:

- **Sunum Katmanı (Presentation Layer)**: Bu katman, kullanıcı arayüzü (UI) bileşenlerini içerir. Kullanıcı isteklerini alır ve iş mantığı katmanına ileterek gerekli işlemlerin yapılmasını sağlar.
  
- **İş Mantığı Katmanı (Business Logic Layer)**: İş mantığı kurallarının uygulandığı katmandır. Veri işleme, doğrulama ve yetkilendirme gibi işlemler bu katmanda gerçekleştirilir.
  
- **Veri Erişim Katmanı (Data Access Layer)**: Veritabanı işlemlerinin gerçekleştirildiği katmandır. Her müşteri için ayrı bir veritabanı bağlantısı sağlanarak veri izolasyonu sağlanır.
  
- **Servis Katmanı (Service Layer)**: İş mantığı katmanıyla veri erişim katmanı arasındaki iletişimi yöneten katmandır. Bu katmanda, harici servislerle iletişim kurulur ve işlemler gerçekleştirilir.

## Kurulum ve Başlangıç

Projenin çalıştırılması için aşağıdaki adımları izleyebilirsiniz:

1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz bir IDE ile projeyi açın.
3. Gerekli bağımlılıkları restore edin (NuGet Paket Yöneticisi kullanarak veya `dotnet restore` komutunu çalıştırarak).
4. Veritabanı bağlantı ayarlarınızı yapılandırın.
5. Projeyi derleyin ve çalıştırın.

## Notlar

Bu proje, Multi-Tenancy yapısını benimseyen ve birden fazla müşteriye hizmet veren uygulamalar için bir örnek oluşturur. Proje, .NET platformunda geliştirilmiş olup, genişletilebilir ve ölçeklenebilir bir yapıya sahiptir.
