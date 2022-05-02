using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jhonata
{
    internal class Curso
    {
        //atributos
        public int id;
        public string nome;
        public string categoria;
        public int cargaHoraria;
        public double valor;
        public bool ativo;
        public DateTime dataCadastro;



        //Propriedades
        public int Id{ get { return id;  } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Categoria { get { return categoria; }set { categoria = value; } }
        public int CargaHoraria {get { return cargaHoraria; }set{ cargaHoraria = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public bool Ativo { get { return ativo; }set { ativo = value; } }
        public DateTime DataCadastro { get { return dataCadastro; }set{ dataCadastro = value; } }



        //Métodos Construtores
        public Curso()
        {
        }

        public Curso(string nome, string categoria, int cargaHoraria, double valor)
        {
            Nome = nome;
            Categoria = categoria;
            CargaHoraria = cargaHoraria;
            Valor = valor;
        }

        public Curso(int id, string nome, string categoria, int cargaHoraria, double valor, bool ativo, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            CargaHoraria = cargaHoraria;
            Valor = valor;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }

       



    }





    
}
