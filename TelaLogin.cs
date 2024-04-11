using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.DevTools.V121.Runtime;

namespace Teste_de_funcionalidades
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();


        }        

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "supervisor" && txtSenha.Text == "abc,123")
            {
                this.Hide();
                FormPrincipal frm = new FormPrincipal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
                       

        }


    }
}
