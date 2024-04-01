using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste_de_funcionalidades
{
    public partial class FormPrincipal : Form
    {
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
            System.Diagnostics.Process.Start
               (@"C:\Program Files (x86)\SSH Communications Security\SSH Secure Shell\SshClient.exe");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Administrador\Downloads\winbox-3.38-installer.exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"E:\dbeaver\dbeaver.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string caminhoPadrao = @"C:\puTTy\putty.exe";
            string caminhoAlternativo = @"E:\puTTy\putty.exe";

            if (File.Exists(caminhoPadrao))
                System.Diagnostics.Process.Start(caminhoPadrao);

            else if (File.Exists(caminhoAlternativo))
                System.Diagnostics.Process.Start(caminhoAlternativo);
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
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }
    }
}