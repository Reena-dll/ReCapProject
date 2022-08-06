using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba İsmi Geçersiz";
        public static string CarDailyPriceInvalid = "Araba Ücreti Geçersiz";
        public static string MaintenanceTime = "Bakım Modu Açık";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string AddedColor = "Renk Eklendi";
        public static string DeletedColor = "Renk Silindi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string UpdatedColor = "Renk Güncellendi";
        public static string AddedBrand = "Marka Eklendi";
        public static string DeletedBrand = "Marka Silindi";
        public static string UpdatedBrand = "Marka Güncellendi";
        public static string BrandsList = "Marka Listelendi";
        public static string AddedUser = "Kullanıcı Eklendi";
        public static string DeletedUser = "Kullanıcı Silindi";
        public static string UpdatedUser = "Kullanıcı Güncellendi";
        public static string UserList = "Kullanıcılar Listelendi";
        public static string AddedCustomer = "Müşteri Eklendi";
        public static string DeletedCustomer = "Müşteri Silindi";
        public static string UpdatedCustomer = "Müşteri Güncellendi";
        public static string CustomerList = "Müşteriler Listelendi";
        public static string AddedRental = "Kiralama Oluşturuldu";
        public static string DeletedRental = "Kiralama Silindi";
        public static string UpdatedRental = "Kiralama Güncellendi";
        public static string RentalList = "Kiralamalar Listelendi";
        public static string CarNotDelivered = "Kiralama Oluşturulamadı";
        public static string CarCountOfBrandError = "Bir kategoride yalnızca 10 ürün olabilir.";
        public static string CarNameExists = "Bu isimde zaten başka bir araba mevcut.";
        public static string CheckIfBrandLimitExceded = "Marka limiti aşıldığı için yeni araba eklenemiyor.";
        public static string UploadedImage = "Resim Veritabanına Yüklendi";
        public static string CarImageCountOfCarError = "Bir araca 5 resimden fazla resim yüklenemez.";
        public static string DeletedImage = "Fotoğraf Silindi";
        public static string ImagesListed = "Fotoğraflar Listelendi";
        public static string UpdatedImage = "Fotoğraf Güncellendi";
        public static string OperationClaimsListed = "Yetkiler Sıralandı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Login işlemi başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
        public static string AuthorizationDenied = "";
    }
}
