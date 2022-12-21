using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAs.Model
{
    public class Kelime
    {
        public string madde_id { get; set; }
        public string madde
        {
            get;
            set;
        }
        public string anlam
        {
            get;
            set;
        }
    }


    public class AnlamlarListe
    {
        public string anlam_id { get; set; }
        public string madde_id { get; set; }
        public string anlam_sira { get; set; }
        public string fiil { get; set; }
        public string tipkes { get; set; }
        public string anlam { get; set; }
        public string gos { get; set; }
        public List<OzelliklerListe> ozelliklerListe { get; set; }
    }

    public class OzelliklerListe
    {
        public string ozellik_id { get; set; }
        public string tur { get; set; }
        public string tam_adi { get; set; }
        public string kisa_adi { get; set; }
        public string ekno { get; set; }
    }

    public class Root
    {
        public string madde_id { get; set; }
        public string kac { get; set; }
        public string kelime_no { get; set; }
        public string cesit { get; set; }
        public string anlam_gor { get; set; }
        public object on_taki { get; set; }
        public string madde { get; set; }
        public string cesit_say { get; set; }
        public string anlam_say { get; set; }
        public object taki { get; set; }
        public string cogul_mu { get; set; }
        public string ozel_mi { get; set; }
        public string lisan_kodu { get; set; }
        public string lisan { get; set; }
        public object telaffuz { get; set; }
        public object birlesikler { get; set; }
        public object font { get; set; }
        public string madde_duz { get; set; }
        public object gosterim_tarihi { get; set; }
        public List<AnlamlarListe> anlamlarListe { get; set; }
    }
}