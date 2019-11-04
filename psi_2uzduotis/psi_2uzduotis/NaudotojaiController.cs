using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis
{
    public class NaudotojaiController:IDBOperatable
    {
        private int i;
        private int ID;
        private string text;
        public string Insert()
        {
            return "insert into " + text;
        }
        public string Update()
        {
            return "update [Login] set type='" + i + "' where ID='" + ID + "'";
        }
        public string Delete()
        {
            return "delete from " + text;
        }
        public string Read()
        {
            return "select * from "+ text;
        }
        public NaudotojaiController(int i, int ID, string text)
        {
            this.i = i;
            this.ID = ID;
            this.text = text;
        }
    }
}
