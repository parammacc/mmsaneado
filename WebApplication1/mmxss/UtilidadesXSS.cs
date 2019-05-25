using Ganss.XSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.mmxss
{
    public class UtilidadesXSS
    {
        static public String getRuta()
        {
            return "<a href=\"/Articulos/Index\">INICIO</a>";
        //    return "<ul><li><a href=\"onmouseover=alert(12345)\">ESTO ES UNA PRUEBA DE XSS</a></li></a>";
        }
        
        static public String getRutaXSS0()
        {
            return "<a href=\"/Articulos/Index/onmouseover=alert(123)\">INICIO</a>";
        }

        static public String getRutaXSS1()
        {
            return "<a href=\"/Articulos/Index/%22onmouseover=%22alert(123)%22\">INICIO/\"onmouseover=\"alert(123)\"</a>";
        }

        static public String getRutaXSS2()
        {
            return "<a href=\"/Articulos/Index/\"onmouseover=\"alert(1234567890)\">INICIO/onmouseover=alert(1234567890)</a>";
        }

        static public HtmlString getRutaXSS22()
        {
            return new HtmlString("<a href=\"/Articulos/Index/\"onmouseover=\"alert(1234567890)\">INICIO/onmouseover=alert(1234567890)</a>");
        }

        static public String getRutaXSS3()
        {
            string ruta = "<a href=\"/Articulos/Index/\"onmouseover=\"alert(1234567890)\">INICIO/onmouseover=alert(1234567890)</a>";
            var sanitizer = new HtmlSanitizer();
                string rutaSaneada = sanitizer.Sanitize(ruta);
                    return rutaSaneada;

        //    return new HtmlSanitizer().Sanitize("<a href=\"/Articulos/Index/\"onmouseover=\"alert(1234567890)\">INICIO/onmouseover=alert(1234567890)</a>");
        }

        static public string getRutaXSS4()
        {
            string ruta = "<a href=\"/Articulos/Index/\"onmouseover=\"alert(1234567890)\">INICIO/onmouseover=alert(1234567890)</a>";
        //    var ruta2 = new HtmlString(ruta); //por sí solo no evita xss
            ruta = ruta.Replace("\"","");
            ruta = ruta.Replace("'", "");
            ruta = ruta.Replace("%22", "");
            return ruta;
        }
    }
}