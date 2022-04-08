using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Lista_Compras
{
    internal class Utilizador
    {
        public int ID { get; set; }
        public string nomeUtilizador { get; set; }
        public string email { get; set; }
        public string password { get; set; } 
        public string pais { get; set; }

        public bool Login(string _userName, string _password)
        {
          

            if(_userName == nomeUtilizador && _password == password)
                return true;
            else
                return false;
        }


    }
}
