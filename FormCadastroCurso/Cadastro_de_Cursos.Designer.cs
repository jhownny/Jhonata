namespace Jhonata
{
    partial class Cadastro_de_Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtValorCurso = new System.Windows.Forms.TextBox();
            this.txtCategoriaCurso = new System.Windows.Forms.TextBox();
            this.txtCargaHorariaCurso = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.btnInserirCurso = new System.Windows.Forms.Button();
            this.btnAlterarCurso = new System.Windows.Forms.Button();
            this.btnConsultarPorId = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnListarCurso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.txtBuscarCursoPorDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(108, 21);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(54, 20);
            this.txtCodigoCurso.TabIndex = 1;
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.Location = new System.Drawing.Point(108, 126);
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(85, 20);
            this.txtValorCurso.TabIndex = 2;
            // 
            // txtCategoriaCurso
            // 
            this.txtCategoriaCurso.Location = new System.Drawing.Point(108, 73);
            this.txtCategoriaCurso.Name = "txtCategoriaCurso";
            this.txtCategoriaCurso.Size = new System.Drawing.Size(75, 20);
            this.txtCategoriaCurso.TabIndex = 3;
            // 
            // txtCargaHorariaCurso
            // 
            this.txtCargaHorariaCurso.Location = new System.Drawing.Point(108, 100);
            this.txtCargaHorariaCurso.Name = "txtCargaHorariaCurso";
            this.txtCargaHorariaCurso.Size = new System.Drawing.Size(97, 20);
            this.txtCargaHorariaCurso.TabIndex = 4;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(108, 47);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(142, 20);
            this.txtNomeCurso.TabIndex = 5;
            this.txtNomeCurso.TextChanged += new System.EventHandler(this.txtNomeCurso_TextChanged);
            // 
            // btnInserirCurso
            // 
            this.btnInserirCurso.Location = new System.Drawing.Point(37, 179);
            this.btnInserirCurso.Name = "btnInserirCurso";
            this.btnInserirCurso.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCurso.TabIndex = 6;
            this.btnInserirCurso.Text = "&Inserir";
            this.btnInserirCurso.UseVisualStyleBackColor = true;
            this.btnInserirCurso.Click += new System.EventHandler(this.btnInserirCurso_Click);
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Location = new System.Drawing.Point(333, 179);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCurso.TabIndex = 7;
            this.btnAlterarCurso.Text = "&Alterar";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPorId
            // 
            this.btnConsultarPorId.Location = new System.Drawing.Point(118, 179);
            this.btnConsultarPorId.Name = "btnConsultarPorId";
            this.btnConsultarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarPorId.TabIndex = 8;
            this.btnConsultarPorId.Text = "&Consultar";
            this.btnConsultarPorId.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(414, 179);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCurso.TabIndex = 9;
            this.btnExcluirCurso.Text = "&Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnListarCurso
            // 
            this.btnListarCurso.Location = new System.Drawing.Point(228, 179);
            this.btnListarCurso.Name = "btnListarCurso";
            this.btnListarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnListarCurso.TabIndex = 10;
            this.btnListarCurso.Text = "&Listar";
            this.btnListarCurso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cartegoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Carga Horaria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(37, 258);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(452, 184);
            this.dgvCursos.TabIndex = 16;
            // 
            // txtBuscarCursoPorDescricao
            // 
            this.txtBuscarCursoPorDescricao.Location = new System.Drawing.Point(37, 238);
            this.txtBuscarCursoPorDescricao.Name = "txtBuscarCursoPorDescricao";
            this.txtBuscarCursoPorDescricao.Size = new System.Drawing.Size(452, 20);
            this.txtBuscarCursoPorDescricao.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pesquisar Por Descrição";
            // 
            // Cadastro_de_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarCursoPorDescricao);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListarCurso);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnConsultarPorId);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.btnInserirCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.txtCargaHorariaCurso);
            this.Controls.Add(this.txtCategoriaCurso);
            this.Controls.Add(this.txtValorCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_de_Cursos";
            this.Text = "Cadastro de Cursos";
            this.Load += new System.EventHandler(this.Cadastro_de_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtValorCurso;
        private System.Windows.Forms.TextBox txtCategoriaCurso;
        private System.Windows.Forms.TextBox txtCargaHorariaCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Button btnInserirCurso;
        private System.Windows.Forms.Button btnAlterarCurso;
        private System.Windows.Forms.Button btnConsultarPorId;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnListarCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtBuscarCursoPorDescricao;
        private System.Windows.Forms.Label label6;
    }
}