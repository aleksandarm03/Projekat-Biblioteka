using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    class OstaliZanrovi:Knjiga
    {
        private string zanr;

        public OstaliZanrovi(string zanr, string naziv, string ime_autora, string prezime_autora)
            : base(naziv, ime_autora, prezime_autora)
        {
            if (!String.IsNullOrEmpty(zanr))
                this.zanr = zanr;
            else
                throw new Exception("Neispravno unet zanr");
        }

        public override string Ispis()
        {
            return naziv + " - " + ime_autora + " " + prezime_autora + " / " + zanr;
        }
    }
}
