using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        //convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi.."+urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama,int stokadet)
        {
            Console.WriteLine("Sepete Eklendi.." + urunAdi);
        }
    }
}
