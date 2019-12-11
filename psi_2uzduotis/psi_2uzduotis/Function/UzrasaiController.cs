using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis
{
    public class UzrasaiController : IDBOperatable
    {
        private string usr;
        private string text;
        private int ID;
        public string Insert()
        {
            return "insert [Uzrasai] (name, data, username) VALUES ('" + text + "', '', '" + usr + "')";
        }
        public string Update()
        {
            return "update [Uzrasai] set data='" + text + "' where ID='" + ID + "'";
        }
        public string Delete()
        {
            return "delete from [Uzrasai] where ID='" + ID + "'";
        }
        public string Read()
        {
            return "select * from [Uzrasai] where username ='" + usr + "' order by ID desc";
        }
        public UzrasaiController(string usr, string text, int ID)
        {
            this.usr = usr;
            this.text = text;
            this.ID = ID;
        }
    }
}