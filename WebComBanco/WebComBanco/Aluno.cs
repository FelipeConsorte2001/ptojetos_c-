using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebComBanco
{
    public class Aluno
    {
        public Aluno()
        {
        }
        public Aluno(string rgm, string nome, float n1, float n2)
        {
            this.RGM = rgm;
            this.Nome = nome;
            this.Nota1 = n1;
            this.Nota2 = n2;
        }

        public string RGM { set; get; }
        public string Nome { set; get; }
        public float Nota1 { set; get; }
        public float Nota2 { set; get; }

    }
}