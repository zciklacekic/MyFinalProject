using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımı var";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategory = "Aynı kategoride en fazla belirlenmiş sayıda urun olabilir";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Aynı ürün ismi daha once veritabanına girilmiş";
        public static string CategoryLimitExceeded = "Kategori Limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
