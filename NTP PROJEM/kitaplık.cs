using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_PROJEM
{
    public class kitaplık
    {

        public int Kitap_ID { get; set; }
        public string Kitap_ad { get; set; }
        public string Kitap_yazar { get; set; }
        public int Kitap_sayi { get; set; }
        public string Kitap_yayinevi { get; set; }

        public kullanicilar KitapEkleyenUsername { get; set; }
    }

    public class Roman : kitaplık
    {
    }

    public class Hikaye : kitaplık
    {
    }

    public class Siir : kitaplık
    {
    }

    public class Deneme : kitaplık
    {
    }
    public class Biyografi_otobiyografi : kitaplık
    {
    }
    public class Arastirma_inceleme : kitaplık
    {
    }
    public class Bilimkurgu : kitaplık
    {
    }
    public class Felsefi : kitaplık
    {
    }
    public class Kisiselgelisim : kitaplık
    {
    }
    public class Cocukkitaplari : kitaplık
    {
    }
}
