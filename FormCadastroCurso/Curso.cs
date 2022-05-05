using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Jhonata
{
    internal class Curso
    {
        //atributos
        public int id;
        public string nome;
        public string categoria;
        public int cargaHoraria;
        public string valor;
        public bool ativo;
        public DateTime dataCadastro;



        //Propriedades
        public int Id{ get { return id;  } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Categoria { get { return categoria; }set { categoria = value; } }
        public int CargaHoraria {get { return cargaHoraria; }set{ cargaHoraria = value; } }
        public string Valor { get { return valor; } set { valor = value; } }
        public bool Ativo { get { return ativo; }set { ativo = value; } }
        public DateTime DataCadastro { get { return dataCadastro; }set{ dataCadastro = value; } }



        //Métodos Construtores
        public Curso()
        {
        }

        public Curso(string nome, string categoria, int cargaHoraria, string valor)
        {
            Nome = nome;
            Categoria = categoria;
            CargaHoraria = cargaHoraria;
            Valor = valor;
        }

        public Curso(int id, string nome, string categoria, int cargaHoraria, string valor, bool ativo, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            CargaHoraria = cargaHoraria;
            Valor = valor;
            Ativo = ativo;
            DataCadastro = dataCadastro;
        }

        public void InserirCurso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_NovoCurso";
            cmd.Parameters.AddWithValue("_crs_nome",Nome);
            cmd.Parameters.AddWithValue("_crs_categoria",Categoria);
            cmd.Parameters.AddWithValue("_crs_valor",Valor);
            cmd.Parameters.AddWithValue("_crs_carga_horaria",CargaHoraria);

            Id = Convert.ToInt32 (cmd.ExecuteScalar());
            cmd.Connection.Close();

        } 

        public bool Alterar(int _id,string _nome,string _categoria,int _cargaHoraria ,string _valor)
        {
            bool resultado = false;
            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AtualizarCurso";
                cmd.Parameters.Add("_crs_codigo",MySqlDbType.Int32).Value = _id;
                cmd.Parameters.Add("_crs_nome",MySqlDbType.VarChar).Value = _nome;
                cmd.Parameters.Add("_crs_categoria",MySqlDbType.VarChar).Value = _categoria;
                cmd.Parameters.Add("_crs_carga_horaria",MySqlDbType.Int32).Value = _cargaHoraria;
                cmd.Parameters.Add("_crs_valor",MySqlDbType.Decimal).Value = _valor;

                cmd.ExecuteNonQuery();

                resultado = true;


                cmd.Connection.Close ();


            }
            catch (Exception)
            {




            }
            return resultado;











        }

    }





    
}
