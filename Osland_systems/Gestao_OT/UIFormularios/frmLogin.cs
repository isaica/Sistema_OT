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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Tipo_De_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.username = txt_Usuario.Text.Trim();
            l.password = txt_Senha.Text.Trim();
            l.user_type = cbx_Tipo_De_Usuario.Text.Trim();

            bool Success = dal.loginCheck(l);
            if (Success == true)
            {
                MessageBox.Show("Login efetuado com sucesso!!", "Informacao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Abrir formularios d acordoo coom o tipo d usuario
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            frmAdmin admin = new frmAdmin();
                            admin.Show(); //Abrir o Formulario Admin
                            this.Hide(); //Esconde o formulari q tiver aberto
                        }
                        break;
                    case "Usuario":
                        {
                            frmUserDashboard userdash = new frmUserDashboard();
                            userdash.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Tipo de Usuario errado", "Atencao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Erro no Loogin ou Senha estao errados!!", "Atencao",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
