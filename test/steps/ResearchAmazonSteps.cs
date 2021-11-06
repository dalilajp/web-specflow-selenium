using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using web_specflow_selenium.maps;

namespace web_specflow_selenium.steps
{
    [Binding]
    public class ResearchAmazonSteps
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        public ResearchAmazonSteps(IWebDriver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Given(@"que eu acesse o site da Amazon")]
        public void dadoQueEuAcesseOSiteDaAmazon()
        {
            _driver.Navigate().GoToUrl($"https://www.amazon.com/");
        }

        [Given(@"que eu selecione o idioma Portugues")]
        public void dadoQueEuSelecioneOIdiomaPortugues()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement btnSelecaoIdioma = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdBtnSelecaoIdioma)));
            btnSelecaoIdioma.Click();

            Actions actions = new Actions(_driver);
            IWebElement radIdiomaPortugues = wait.Until(_driver => _driver.FindElement(By.XPath(ResearchAmazonMap.ByValueRadIdiomaPortugues)));
            actions.MoveToElement(radIdiomaPortugues).Click().Build().Perform();

            IWebElement btnSalvarAteracoes = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdBtnSalvarAteracoes)));
            actions.MoveToElement(btnSalvarAteracoes).Click().Build().Perform();
        }
        
        [Given(@"que eu pesquise o produto desejado ""(.*)""")]
        public void dadoQueEuPesquiseOProdutoDesejado(string produto)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement txtPesquisarProduto = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdTxtPesquisarProduto)));
            txtPesquisarProduto.SendKeys(produto);

            IWebElement btnPesquisarProduto = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdBtnPesquisarProduto)));
            btnPesquisarProduto.Click();
        }

        [When(@"seleciono o tamanho dos produtos")]
        public void quandoSelecionoOTamanhoDosProdutos()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement btnPesquisarProduto = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdBtnPesquisarProduto)));
            btnPesquisarProduto.Click();
        }

        [When(@"ordeno o tipo de exibicao dos produtos")]
        public void quandoOrdenoOTipoDeExibicaoDosProdutos()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement btnTamanhoProduto = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.ByIdBtnTamanhoProduto)));
            btnTamanhoProduto.Click();

            IWebElement cboTamanhoProduto = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.byIdCboTamanhoProduto)));
            cboTamanhoProduto.Click();
        }

        [When(@"clico no produto para visualizar")]
        public void quandoClicoNoProdutoParaVisualizar()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement btnOrdernarExibicao = wait.Until(_driver => _driver.FindElement(By.Id(ResearchAmazonMap.byIdBtnOrdernarExibicao)));
            btnOrdernarExibicao.Click();
        }

        [Then(@"a navegacao foi realizada com sucesso")]
        public void entaoANavegacaoFoiRealizadaComSucesso()
        {        }
    }
}