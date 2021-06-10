using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    abstract class Knjiga
    {
        protected string naziv;
        protected string ime_autora;
        protected string prezime_autora;

        public Knjiga(string naziv, string ime_autora, string prezime_autora)
        {
            if (!String.IsNullOrEmpty(naziv))
                this.naziv = naziv;
            else
                throw new Exception("Izostavljen naziv knjige");
            if (!String.IsNullOrEmpty(ime_autora))
                this.ime_autora = ime_autora;
            else
                throw new Exception("Izostavljeno ime autora");
           
            if (!String.IsNullOrEmpty(naziv))
                this.prezime_autora = prezime_autora;
            else
                throw new Exception("Izostavljeno prezime autora");          
        }

        public virtual string Ispis()
        {
            return "";
        }
    }
}
