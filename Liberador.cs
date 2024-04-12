using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutoItX3Lib;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace Teste_de_funcionalidades
{
    public partial class Liberador : Form
    {
        private IWebDriver driver; // Declare uma instância global do IWebDriver

        public Liberador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (driver == null)
            {
                var cnpj = txtCnpj.Text;

                ChromeOptions options = new ChromeOptions();
                options.AddArguments("start-maximized"); // Maximiza a janela do navegador
                driver = new ChromeDriver(options);

                driver.Navigate().GoToUrl("http://liberacao.socin.com.br:8089/GeradorSenhaWEB/senha/senha.jsf");
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoCnpj = driver.FindElement(By.Id("cnpj"));
                campoCnpj.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoLogin = driver.FindElement(By.CssSelector(".ui-inputfield.ui-inputmask.ui-widget.ui-state-default.ui-corner-all"));
                campoLogin.SendKeys(cnpj);

                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoBuscar = driver.FindElement(By.ClassName("botao-visualizar"));
                campoBuscar.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoBaixar = driver.FindElement(By.ClassName("botao-download"));
                campoBaixar.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.Until(d => campoBaixar.Displayed);

            }
            else
            {
                var cnpj = txtCnpj.Text;

                // Abre uma nova aba e navega para a página 2
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open('http://liberacao.socin.com.br:8089/GeradorSenhaWEB/senha/senha.jsf');");
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoCnpj = driver.FindElement(By.Id("cnpj"));
                campoCnpj.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoLogin = driver.FindElement(By.CssSelector(".ui-inputfield.ui-inputmask.ui-widget.ui-state-default.ui-corner-all"));
                campoLogin.SendKeys(cnpj);

                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoBuscar = driver.FindElement(By.ClassName("botao-visualizar"));
                campoBuscar.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoBaixar = driver.FindElement(By.ClassName("botao-download"));
                campoBaixar.Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.Until(d => campoBaixar.Displayed);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string caminhoDoBat = @"C:\socin\econect\conc\lib\liberacao.jar";
            string caminhoDoBat2 = @"D:\socin\econect\conc\lib\liberacao.jar";
            string caminhoDoBat3 = @"E:\socin\econect\conc\lib\liberacao.jar";
            string caminhoDoBat4 = @"F:\socin\econect\conc\lib\liberacao.jar";

            if (File.Exists(caminhoDoBat))
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {caminhoDoBat}",
                    WorkingDirectory = Path.GetDirectoryName(caminhoDoBat)
                };

                System.Diagnostics.Process.Start(startInfo);
                MessageBox.Show("Aguarde um pouco! O liberador da Socin pode demorar um pouco para abrir.", "Informativo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }

}
