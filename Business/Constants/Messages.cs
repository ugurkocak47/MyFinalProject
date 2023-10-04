using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistem bakım arasında";

        public static string ProductCountOfCategoryError = "Bu kategoride olması gerekenden daha fazla ürün var";

        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten var";
        public static string CategoryQuantityTooMuch = "Çok fazla kategori var";

        public static string AuthorizationDenied = "Yetkilendirme reddedildi";

        public static string UserRegistered = "Kullanıcı kayıt edildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatası";

        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten sistemde kayıtlı";

        public static string AccessTokenCreated = "Erişim tokenı oluşturuldu";
    }
}
