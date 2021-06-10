using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    class NaucnaFantastika:Knjiga
    {
        private int godina_izdavanja;
        public NaucnaFantastika(int godina_izdavanja,string naziv,string ime_autora,string prezime_autora)
            : base(naziv,ime_autora,prezime_autora)
        {
            if (godina_izdavanja <= 2021 && godina_izdavanja >= 1700)
                this.godina_izdavanja = godina_izdavanja;
            else
                throw new Exception("Neispravna godina izdavanja");
        }
        public override string Ispis()
        {
            return naziv + " - " + ime_autora + " " + prezime_autora + " / " + godina_izdavanja;
        }
    }
}
