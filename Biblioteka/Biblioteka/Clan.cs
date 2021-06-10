using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    class Clan:IClan
    {
        private string imeClana, prezimeClana;
        private int brojGodina;

        public Clan(string imeClana, string prezimeClana, int brojGodina)
        {
            if (imeClana.Equals(string.Empty))
                throw new Exception("Izostavljeno ime clana");                
            else
                this.imeClana = imeClana;

            if (!String.IsNullOrEmpty(prezimeClana))
                this.prezimeClana = prezimeClana;
            else
                throw new Exception("Izostavljeno prezime clana");
            if (brojGodina > 1)
                this.brojGodina = brojGodina;
            else
                throw new Exception("Izostavljen broj godina");
        }

        public string DodajClana()
        {
            return imeClana + " " + prezimeClana + " - " + brojGodina;
        }
    }
}
