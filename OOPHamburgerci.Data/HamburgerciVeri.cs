using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOPHamburgerci.Data
{
    public static class HamburgerciVeri
    {

        public static List<Menu> Menuler { get; set; } = new List<Menu>();
        public static List<EkstraMalzeme> EkstraMalzemeler { get; set; } = new List<EkstraMalzeme>();
        public static List<Siparis> TumSiparisler { get; set; } = new List<Siparis>();

        public static void VerileriYukle()
        {
            try
            {
                if (File.Exists("menuler.json"))
                {
                    string menuData = File.ReadAllText("menuler.json");
                    Menuler = JsonSerializer.Deserialize<List<Menu>>(menuData);
                }
                else
                    Menuler = new List<Menu>();

                if (File.Exists("ekstraMalzeme.json"))
                {
                    string ekstraMalzemelerData = File.ReadAllText("ekstraMalzeme.json");
                    EkstraMalzemeler = JsonSerializer.Deserialize<List<EkstraMalzeme>>(ekstraMalzemelerData);
                }
                else
                    EkstraMalzemeler = new List<EkstraMalzeme>();

            }
            catch (Exception e)
            {

                throw new Exception("Verileri yüklerken hata oluştu" + e.Message);
            }
        }
        public static void VerileriKaydet()
        {
            try // Verileri Kaydederken Sorun Olması Durumunda Hata Mesajı Fırlattık.
            {
                var options = new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // Okunabilirlik için yaptığımız işlemler. 
                    WriteIndented = true

                };
                //Menü verilerini json formatında kaydetmemizi sağlar.
                string menuData = JsonSerializer.Serialize(Menuler, options);
                File.WriteAllText("menuler.json", menuData);

                // Ekstra Malzemle Verilierni json formatında kaydetmemizi sağlar.
                string EkstraMalzemeData = JsonSerializer.Serialize(EkstraMalzemeler, options);
                File.WriteAllText("ekstraMalzeme.json", EkstraMalzemeData);
            }
            catch (Exception e)
            {
                throw new Exception("Verileri kaydederken hata oluştu" + e.Message);
            }

        }
    }
}



