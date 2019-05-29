using System;
using System.Threading;
using Cadastro.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Cadastro
{
    [Binding]
    public class CadastroDeUsuarioSteps
    {   
        // Declarando IWebDriver e Chamando classes para instanciar objeto.
        IWebDriver browser;
        PreenchimentoPage validacao;
        MensagemSucesso mensagemValidacao;

        // Tag para executar o método antes do cenário.
        [BeforeScenario]

        // Método de inicialização do navegador Chrome.
        public void Init()
        {
            this.browser = new ChromeDriver(); // Abrir aba.
            validacao = new PreenchimentoPage(browser); // Criar uma instancia de preenchimento.
            mensagemValidacao = new MensagemSucesso(browser); // Criar uma instancia para validar a mensagem.
        }

        [Given(@"que estou na pagina de cadastro")]
        public void DadoQueEstouNaPaginaDeCadastro()
        {
            // Função que inicia no navegador a URL informada.
            validacao.acesso("https://automacaocombatista.herokuapp.com/users/new");
        }

        [When(@"preencher todos os campos")]
        // Definição de parâmetro seguido de uma tabela.
        public void QuandoPreencherTodosOsCampo(Table table)
        {
            // Preenchimento de valores com base nos dados da .feature 
            validacao.preencherDados(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(),
                table.Rows[0][2].ToString(),
                table.Rows[0][3].ToString(),
                table.Rows[0][4].ToString(),
                table.Rows[0][5].ToString(),
                table.Rows[0][6].ToString(),
                table.Rows[0][7].ToString());
        }

        [When(@"clicar em criar")]
        public void QuandoClicarEmCriar()
        {
            // Chamada da função para Criar o cadastrado com base no valor da URL. 
            validacao.botaoCriar("commit");
            Thread.Sleep(1000);
        }

        [Then(@"visualizo a mensagem: Usuário Criado com sucesso")]
        public void EntaoVisualizoAMensagemUsuarioCriadoComSucesso()
        {
            // Validação de mensagem.
            mensagemValidacao.mensagemSucesso("Usuário Criado com sucesso", "notice");
        }

        // Método para fechar e limpar a memória depois de executar o cenário.
        [AfterScenario]
        public void Close()
        {
            this.browser.Close();
            this.browser.Dispose();
        }
    }
}