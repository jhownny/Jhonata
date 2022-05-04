using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Jhonata;
using System.Data;

namespace Jhonata
{
    public static class Banco
    {

        public static string StrConexao { get; set; }

        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConexao = @"server=127.0.0.1;database=ti91_jhonata;user id=root;password=;port=3306";
            MySqlConnection conexaoConnection = new MySqlConnection(StrConexao);


            try
            {

                conexaoConnection.Open();

            }
            catch {}
            cmd.Connection = conexaoConnection;
            return cmd;

        }



    }
}
