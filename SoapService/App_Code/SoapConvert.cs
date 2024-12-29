using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// SoapConvert için özet açıklama
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
// [System.Web.Script.Services.ScriptService]
public class SoapConvert : System.Web.Services.WebService
{

    public SoapConvert()
    {
    }

    [WebMethod]
    public double TurkishLiraToDollar(double TurkishLira)
    {
        return (TurkishLira / 29.75);
    }

    [WebMethod]
    public double TurkishLiraToEuro(double TurkishLira)
    {
        return (TurkishLira / 32.56);
    }

}
