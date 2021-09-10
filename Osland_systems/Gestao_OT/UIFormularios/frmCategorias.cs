using Gestao_OT.BLLClasses;
using Gestao_OT.DALdados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_OT.UIFormularios
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        //Criar instancia doos metos das classes DAL E BLL para usar eles aqui nos eventos dos botoes
        categoriaBLL c = new categoriaBLL();
        categoriaDAL dal = new categoriaDAL();
        userDAL udal = new userDAL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Pegando valores dos nossos campos do formulari para enviar pra BD
            c.title = txt_Titulo_Categoria.Text;
            c.description = txt_Descricao.Text;
            c.added_date = DateTime.Now;
            //Pegando valor do Id do usuario logado
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.Id;

            bool success = dal.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Usuario cadastrado com sucesso", "Informcao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuario nao foi cadastrado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dt = dal.Select();
            dgvCategoria.DataSource = dt;
        }
        private void Limpar()
        {
            txt_Id_Categoria.Text = "";
            txt_Descricao.Text = "";
            txt_Titulo_Categoria.Text = "";
            txt_Pesquisar.Text = "";
        }
    }
}
