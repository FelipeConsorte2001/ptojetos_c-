using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookie
{
    public class Usuario
    {
        public int ID { set; get; }
        public string Login { set; get; }
        public string Senha { set; get; }

        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

    }
}