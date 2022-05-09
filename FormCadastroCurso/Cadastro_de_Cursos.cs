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

        public Cadastro_de_Cursos()
        {
            InitializeComponent();
        }




        private void Cadastro_de_Cursos_Load(object sender, EventArgs e)
        {

        }




        private void btnInserirCurso_Click(object sender, EventArgs e)
        {
            Curso k = new Curso(txtNomeCurso.Text,txtCategoriaCurso.Text,txtCargaHorariaCurso.Text,txtValorCurso.Text);

            k.InserirCurso();

            if (k.Id > 0) 
            {
                txtCodigoCurso.Text = k.Id.ToString();
                MessageBox.Show("a");

            }
            else 
            {

                MessageBox.Show("deu ruim, meu parceiro.");
                            
            }            


        }

        private void txtNomeCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarCurso_Click(object sender, EventArgs e)
        {
            dgvCursos.Rows.Clear();
            List<Curso> ListaDeCursos = Curso.Listar();
            int count = ListaDeCursos.Count;
            foreach (Curso curso in ListaDeCursos)
            {
                dgvCursos.Rows.Add();
                dgvCursos.Rows[dgvCursos.CurrentRow.Index].Cells[0].Value = curso.Id.ToString();
                dgvCursos.Rows[dgvCursos.CurrentRow.Index].Cells[1].Value = curso.Nome.ToString();
                dgvCursos.Rows[dgvCursos.CurrentRow.Index].Cells[2].Value = curso.Categoria.ToString();
                dgvCursos.Rows[dgvCursos.CurrentRow.Index].Cells[3].Value = curso.CargaHoraria.ToString();
                dgvCursos.Rows[dgvCursos.CurrentRow.Index].Cells[4].Value = curso.Valor.ToString();

            }
     
        
        }

        private void btnConsultarPorId_Click(object sender, EventArgs e)
        {
            if(btnConsultarPorId.Text == "Consultar")
            {
                txtCodigoCurso.ReadOnly = false;
                txtCodigoCurso.Focus();
                btnConsultarPorId.Text = "Buscar";


            }
            else
            {
                Curso curso = Curso.ConsultarPorId(int.Parse(txtCodigoCurso.Text));
                if(curso.Id > 0)
                {
                    txtNomeCurso.Text = curso.Nome.ToString();
                    txtCategoriaCurso.Text = curso.Categoria.ToString();
                    txtCargaHorariaCurso.Text = curso.CargaHoraria.ToString();
                    txtValorCurso.Text = curso.Valor.ToString();

                    btnConsultarPorId.Text = "Consultar";
                    txtCodigoCurso.ReadOnly = true;
                    btnAlterarCurso.Enabled = true;
                    txtNomeCurso.ReadOnly = true;

                }
                else
                {

                    MessageBox.Show("Este Curso Não Existe.");

                }


            }



        }
                



    }
}
