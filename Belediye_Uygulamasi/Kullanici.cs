using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belediye_Uygulamasi
{
    public class Kullanici
    {
        public string ID { get; set; }
        public string TC { get; set; }
        public object Isim { get; set; }
        public string Tam_Ad { get; set; }
        public string Vergi_No { get; set; }
        public string Borc_Miktari { get; set; }

        public override string ToString()
        {
            return TC + "--" + Isim;
        }

    }
}
