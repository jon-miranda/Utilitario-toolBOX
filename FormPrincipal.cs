using System.Configuration;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste_de_funcionalidades
{
    public partial class FormPrincipal : Form
    {
        string app6;
        string caminho7 = ConfigurationManager.AppSettings["caminho7"];
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string caminhoDoBat = @"C:\socin\econect\conc\lib\concentrador.jar";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C {caminhoDoBat}",
                WorkingDirectory = Path.GetDirectoryName(caminhoDoBat)
            };

            System.Diagnostics.Process.Start(startInfo);
        }

        private static void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\socin\\econect\\conc\\lib\\concentrador.jar");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                (@"C:\Program Files (x86)\SSH Communications Security\SSH Secure Shell\SshClient.exe");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"E:\puTTy\putty.exe");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Administrador\Downloads\winbox-3.38-installer.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string caminhoDoBat = @"C:\socin\econect\conc\lib\concentrador.jar";
            string caminhoDoBat2 = @"D:\socin\econect\conc\lib\concentrador.jar";
            string caminhoDoBat3 = @"E:\socin\econect\conc\lib\concentrador.jar";
            string caminhoDoBat4 = @"F:\socin\econect\conc\lib\concentrador.jar";

            if (File.Exists(caminhoDoBat))
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {caminhoDoBat}",
                    WorkingDirectory = Path.GetDirectoryName(caminhoDoBat)
                };

                System.Diagnostics.Process.Start(startInfo);

            }

            else if (File.Exists(caminhoDoBat2))
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {caminhoDoBat2}",
                    WorkingDirectory = Path.GetDirectoryName(caminhoDoBat2)
                };

                System.Diagnostics.Process.Start(startInfo);

            }
            else if (File.Exists(caminhoDoBat3))
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {caminhoDoBat3}",
                    WorkingDirectory = Path.GetDirectoryName(caminhoDoBat3)
                };

                System.Diagnostics.Process.Start(startInfo);

            }

            else if (File.Exists(caminhoDoBat4))
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {caminhoDoBat4}",
                    WorkingDirectory = Path.GetDirectoryName(caminhoDoBat4)
                };

                System.Diagnostics.Process.Start(startInfo);

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                (@"C:\Program Files (x86)\MySQL\MySQL Tools for 5.0\MySQLQueryBrowser.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start
                (@"C:\Program Files (x86)\MySQL\MySQL Tools for 5.0\MySQLQueryBrowser.exe");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string caminhoPadrao = (@"C:\Program Files (x86)\SSH Communications Security\SSH Secure Shell\SshClient.exe");
            string caminhoAlternativo = (@"D:\SSH Communications Security\SSH Secure Shell\SshClient.exe");
            //System.Diagnostics.Process.Start(@"C:\Program Files (x86)\SSH Communications Security\SSH Secure Shell\SshClient.exe");
            string caminho7 = ConfigurationManager.AppSettings["caminho7"];

            if (File.Exists(caminhoPadrao))
                System.Diagnostics.Process.Start(caminhoPadrao);

            else if (File.Exists(caminhoAlternativo))
                System.Diagnostics.Process.Start(caminhoAlternativo);

            else

                try
                {
                    System.Diagnostics.Process.Start(caminho7);
                }

                catch
                {
                    MessageBox.Show("Caminho não encontrado!");
                }


        }
        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Administrador\Downloads\winbox-3.38-installer.exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string caminhoPadrao = ("caminho");
            string caminhoAlternativo = ("caminho");

            System.Diagnostics.Process.Start(@"E:\dbeaver\dbeaver.exe");

            if (File.Exists(caminhoPadrao))
                System.Diagnostics.Process.Start(caminhoPadrao);

            else if (File.Exists(caminhoAlternativo))
                System.Diagnostics.Process.Start(caminhoAlternativo);

            else barraStatus.Text = "Caminho não encontrado";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string caminhoPadrao = @"C:\puTTy\putty.exe";
            string caminhoAlternativo = @"E:\puTTy\putty.exe";


            if (File.Exists(caminhoPadrao))
            {
                System.Diagnostics.Process.Start(caminhoPadrao);
            }

            else if (File.Exists(caminhoAlternativo))
            {
                System.Diagnostics.Process.Start(caminhoAlternativo);
            }

            else
            {

                try
                {
                    System.Diagnostics.Process.Start(app6);
                    //app6 (aplicação 6 / putty) é uma variável criada no escopo geral do projeto 
                    //para armazenar o caminho novo selecionado.

                }
                catch
                {
                    MessageBox.Show("Caminho não encontrado!");
                }
            }


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = ".exe";

            // if (openFileDialog.Filter != "Executáveis|*.exe|Todos os arquivos|*.*")
            // MessageBox.Show("Selecione um arquivo .exe!");

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Obtém o caminho completo do arquivo selecionado e armazena na variável
                app6 = openFileDialog.FileName;

                // Exibe o caminho do arquivo em um TextBox ou Label, se desejado
                // textBoxCaminhoDoArquivo.Text = caminhoDoArquivo;
                // labelCaminhoDoArquivo.Text = caminhoDoArquivo;
            }
            MessageBox.Show($"Caminho alterado para {app6}");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Salva o caminho do arquivo selecionado no arquivo de configuração
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["caminho7"].Value = openFileDialog.FileName;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show($"Caminho alterado para {config.AppSettings.Settings["caminho7"].Value}");

                try
                {
                    if (!string.IsNullOrEmpty(caminho7))
                    {
                        //Abre o arquivo
                        System.Diagnostics.Process.Start(caminho7);
                    }
                }
                catch
                {
                    MessageBox.Show("Nenhum arquivo foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!string.IsNullOrEmpty(caminho7))
                System.Diagnostics.Process.Start(caminho7);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caminho não encontrado");
        }


    }
}