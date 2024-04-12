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

                //driver.Navigate().GoToUrl("http://www.socin.com.br/mediawiki/index.php/Libera%C3%A7%C3%A3o_nova_e-conect");
                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

                IWebElement campoBaixar = driver.FindElement(By.Name("j_idt18"));
                campoBaixar.Click();


            }
            else
            {

                // Abre uma nova aba e navega para a página 2
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.open('https://telegra.ph/raphanet-12-12');");

                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            }
        }
    }
}
