using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis
{
    public class Naudotojai
    {
        private int ID;
        private string vardas;
        private string slaptazodis;
        private int type;
        public Naudotojai(int ID, string vardas, string slaptazodis, int type)
        {
            this.ID = ID;
            this.vardas = vardas;
            this.slaptazodis = slaptazodis;
            this.type = type;
        }
        public int GetID()
        {
            return ID;
        }
        public string GetVardas()
        {
            return vardas;
        }
        public string GetSlap()
        {
            return slaptazodis;
        }
        public int GetTypeN()
        {
            return type;
        }
    }
}
