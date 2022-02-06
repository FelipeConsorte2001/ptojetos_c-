using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace veiculos
{

    public class Caro
    {
    public String id { set; get; }
    public String desc_veiculos { set; get; }
    public String val_veiculos { set; get; }
    public String flex_veiculos { set; get; }

    public Caro(String desc_veiculos,String val_veiculos,String flex_veiculos)
        {
            this.desc_veiculos = desc_veiculos;
            this.val_veiculos = val_veiculos;
            this.flex_veiculos = flex_veiculos;
        }
        public Caro(String id)
        {
            this.id = id;
        }
    }

}