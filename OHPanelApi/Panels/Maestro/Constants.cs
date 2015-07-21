using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class Constants
    {
        //İşlem başarılı
        public const int DOMAIN_OPERATION_SUCCESS = 0;
        //İşlem başarısız
        public const int DOMAIN_OPERATION_ONERROR = -1;
        public const int RESELLER_OPERATION_SUCCESS = 0;
        public const int RESELLER_OPERATION_ONERROR = -1;
        //Kimlik doğrulama işlemi geçersiz.
        public const int API_AUTHENTICATION_ERROR = 5;
        //Beklenen parametre eksik veya boş.
        public const int API_PARAMETER_ERROR = 6;
        //İstenilen eylemin gerçekleşmesi için kullanıcı hakları yetersiz.
        public const int API_ACCESS_DENIED = 7;
        //İstenilen domain adı yanlış veya domain sistemde yok
        public const int API_DOMAIN_NOT_FOUND = 8;
        public const int API_INVALID_REQUEST = 9;
        public const int API_PARAMETER_EXPECTED = 10;
        public const int API_GENERAL_ERROR = 11;


   


    }
}
