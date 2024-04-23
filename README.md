# ENGLISH/TÜRKÇE

# .NET Project Utilizing Multi-Tenancy Structure

This project is an application developed using the .NET platform and embracing the Multi-Tenancy structure. The application is designed to serve multiple customers using the same infrastructure. Data isolation is achieved by using a separate database for each customer.

## Technologies and Structures Used

- **.NET Core/.NET Framework**: The project is built on the .NET platform. .NET Core or .NET Framework can be preferred.
  
- **C#**: Application codes are written in the C# programming language.
  
- **Dependency Injection**: The built-in Dependency Injection mechanism available in .NET Core and .NET Framework platforms is used. This mechanism reduces dependencies between components, increasing the testability of the code.

## Project Structure and Architecture

The project has a layered architecture, and the fundamental layers are as follows:

- **Presentation Layer**: This layer contains user interface (UI) components. It receives user requests and forwards them to the business logic layer to perform the necessary operations.
  
- **Business Logic Layer**: This layer is where business rules are applied. Operations such as data processing, validation, and authorization are performed in this layer.
  
- **Data Access Layer**: This layer handles database operations. Data isolation is achieved by providing a separate database connection for each customer.
  
- **Service Layer**: This layer manages communication between the business logic layer and the data access layer. It communicates with external services and performs operations.

## Installation and Getting Started

You can follow these steps to run the project:

1. Clone or download the project to your computer.
2. Open the project in Visual Studio or your preferred IDE.
3. Restore the necessary dependencies (using NuGet Package Manager or by running the `dotnet restore` command).
4. Configure the database connection settings.
5. Build and run the project.

## Notes

This project serves as an example for applications embracing the Multi-Tenancy structure and serving multiple customers. Developed on the .NET platform, the project is extensible and scalable.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
