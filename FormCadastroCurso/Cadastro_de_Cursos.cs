using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Jhonata;

namespace Jhonata
{
    public partial class Cadastro_de_Cursos : Form
    {


        private void btnInserirCurso_Click(object sender, EventArgs e)
        {
            Curso k = new Curso(txtNomeCurso.Text,txtCategoriaCurso.Text,txtCargaHorariaCurso.Text,txtValorCurso.Text);




        }

        private void txtNomeCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
