using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGMF
{
    public class IdObjItem
    {
        public int ID;
        public string Nom;

        public IdObjItem(int id, string nom)
        {
            this.ID = id;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
       

    }
}
