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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        //Criar instancia doos metos das classes DAL E BLL para usar eles aqui nos eventos dos botoes
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void btn_Add_Click(object sender, EventArgs e)
        {
            u.first_name = txt_Nome.Text;
            u.last_name = txt_Sobrenome.Text;
            u.email = txt_Email.Text;
            u.username = txt_Username.Text;
            u.password = txt_Senha.Text;
            u.contact = txt_Contacto.Text;
            u.address = txt_Endereco.Text;
            u.gender = cbx_Sexo.Text;
            u.user_type = cbx_Tipo_Usuario.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Insert(u);
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
            dgvUser.DataSource = dt;
        }

        //Metodo para limpar os campos do formulario
        private void Limpar()
        {
            txt_Id_Usuario.Text = "";
            txt_Nome.Text = "";
            txt_Sobrenome.Text = "";
            txt_Email.Text = "";
            txt_Username.Text = "";
            txt_Senha.Text = "";
            txt_Contacto.Text = "";
            txt_Endereco.Text = "";
            cbx_Sexo.Text = "";
            cbx_Tipo_Usuario.Text = "";
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            //Ao inicializar o formulario, vai exibir os dados no datagridview
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;

            //Renomear os elemntos do DataGridView
            dgvUser.Columns[0].HeaderText = "ID";
            dgvUser.Columns[1].HeaderText = "Nome";
            dgvUser.Columns[2].HeaderText = "Sobrenome";
            dgvUser.Columns[3].HeaderText = "E-mail";
            dgvUser.Columns[4].HeaderText = "Usuario";
            dgvUser.Columns[5].HeaderText = "Senha";
            dgvUser.Columns[6].HeaderText = "Telefone";
            dgvUser.Columns[7].HeaderText = "Endereço";
            dgvUser.Columns[8].HeaderText = "Sexo";
            dgvUser.Columns[9].HeaderText = "Conta";
            dgvUser.Columns[10].HeaderText = "Data";
            dgvUser.Columns[11].HeaderText = "Add por";
        }

        private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_Id_Usuario.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Sobrenome.Text = dgvUser.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Email.Text = dgvUser.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Username.Text = dgvUser.Rows[rowIndex].Cells[4].Value.ToString();
            txt_Senha.Text = dgvUser.Rows[rowIndex].Cells[5].Value.ToString();
            txt_Contacto.Text = dgvUser.Rows[rowIndex].Cells[6].Value.ToString();
            txt_Endereco.Text = dgvUser.Rows[rowIndex].Cells[7].Value.ToString();
            cbx_Sexo.Text = dgvUser.Rows[rowIndex].Cells[8].Value.ToString();
            cbx_Tipo_Usuario.Text = dgvUser.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            u.Id = Convert.ToInt32(txt_Id_Usuario.Text); //O Id deve ser convertido em Int
            u.first_name = txt_Nome.Text;
            u.last_name = txt_Sobrenome.Text;
            u.email = txt_Email.Text;
            u.username = txt_Username.Text;
            u.password = txt_Senha.Text;
            u.contact = txt_Contacto.Text;
            u.address = txt_Endereco.Text;
            u.gender = cbx_Sexo.Text;
            u.user_type = cbx_Tipo_Usuario.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Atualizado com sucesso", "Informcao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuario nao foi Atualizado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            //Deleta atreves do Id 
            u.Id = Convert.ToInt32(txt_Id_Usuario.Text); //O Id deve ser convertido em Int

            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Eliminado com sucesso", "Informção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else
            {
                MessageBox.Show("Usuario nao foi Eliminado", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {
            string keywords = txt_Pesquisar.Text;
            if (keywords != null) //se a chave inserida na barra d pesuisa for diferente d nulo ele pesquisa no datagridview
            {
                DataTable dt = dal.Search(keywords);
                dgvUser.DataSource = dt;
            }
            else
            {
                //Caso contrario permaneca tdo q tiver no gridview
                DataTable dt = dal.Search();
                dgvUser.DataSource = dt;
            }
        }
    }
}
