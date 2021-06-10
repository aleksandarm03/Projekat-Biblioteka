using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    class Ljubavni:Knjiga
    {
        private int godina_izdavanja;
        private int mesec_izdavanja;
        private int dan;

        public Ljubavni(int dan, int mesec_izdavanja, int godina_izdavanja, string naziv, string ime_autora, string prezime_autora)
            : base(naziv, ime_autora, prezime_autora)
        {
            if (dan <= 31 && dan >= 1)
                this.dan = dan;
            else
                throw new Exception("Neispravan dan izdavanja");
            if (godina_izdavanja <= 2021 && godina_izdavanja >= 1700)
                this.godina_izdavanja = godina_izdavanja;
            else
                throw new Exception("Neispravna godina izdavanja");

            if (mesec_izdavanja <= 12 && mesec_izdavanja > 0)
                this.mesec_izdavanja = mesec_izdavanja;
            else
                throw new Exception("Neispravan mesec izdavanja");
        }

        public override string Ispis()
        {
            return naziv + " - " + ime_autora + " " + prezime_autora + " / "+dan+"." + mesec_izdavanja + "." + godina_izdavanja;
        }
    }
}
