using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis
{
    class Uzrasai
    {
        private int ID;
        private string pavadinimas;
        private string uzrasai;
        private string naudotojas;
        public Uzrasai(int ID, string pavadinimas, string uzrasai, string naudotojas)
        {
            this.ID = ID;
            this.pavadinimas = pavadinimas;
            this.uzrasai = uzrasai;
            this.naudotojas = naudotojas;
        }
        public int GetID()
        {
            return ID;
        }
        public string GetPavadinimas()
        {
            return pavadinimas;
        }
        public string GetUzrasai()
        {
            return uzrasai;
        }
        public string GetNaudotojas()
        {
            return naudotojas;
        }
    }
}
