Projeto Teste Anima Analista - LEIA TODA A ANOTAÇÃO ABAIXO


Passo a passo

Foi usado os seguintes frameworks e extensões:

- Specflow v2.2.0
- Specflow.MsTest v2.2.0
- Specflow.Tools.Ms.Build.Generation v2.3.0

- Selenium.WebDriver v3.141.0
- Selenium.Support v3.141.0
- Selenium.WebDriver.ChromeDriver v3.141.0

- Extensão Specflow for Visual Studio 2019

Caminho dos codigos:

Feature e Steps
- Cadastro/MainTeste/FuncCenario.feature
- Cadastro/MainTeste/CadastroDeUsuarioSteps.cs

PageObject
- Cadastro/PageObject/PreenchimentoPage.cs
- Cadastro/PageObject/MensagemSucesso.cs

Linguagem utilizada C#

TODOS OS CODIGOS ESTÃO DOCUMENTADOS

O CENÁRIO INFORMADO(https://github.com/biancacristtorres/anima-qa-teste/blob/master/cadastroUsuario.feature) FOI MODIFICADO PARA MELHOR IMPLEMENTAÇÃO CONFORME ABAIXO:

[Teste valido]
Cenario 1: Cadastro com sucesso
- Dado que estou na pagina de cadastro
- Quando preencher todos os campos
- |Nome|Ultimo nome|Email|Endereço|Universidade|Profissão|Genero|Idade|
- |Fernanda|Teixeira|fernanda12456@gmail.com.br|Rua X, 1234|Unibh|QA|Feminino|26|
- E clicar em criar
- Então visualizo a mensagem: Usuário Criado com sucesso

PENSANDO DE UM MESMO PRESSUPOSTO PODEMOS REUTILIZAR O MESMO CODIGO E IMPLEMENTAR NOVOS CENÁRIOS DE TESTES COMO POR EXEMPLO:

[Situação onde o usuário cadastra no site preenchendo somente os campos obrigatórios]

[Teste valido]
Cenario 2: Cadastro com sucesso
- Dado que estou na pagina de cadastro
- Quando preencher todos os campos
- |Nome|Ultimo nome|Email|
- |Fernanda|Teixeira|fernanda12456@gmail.com.br|
- E clicar em criar
- Então visualizo a mensagem: Usuário Criado com sucesso

[Situação onde o usuário cadastra no site preenchendo somente nome é ultimo nome(campos obrigatórios)]

[Teste valido]
Cenario 3: Cadastro com sucesso
- Dado que estou na pagina de cadastro
- Quando preencher somente nome e ultimo nome como campos obrigatório
- |Nome|Ultimo nome|
- |Fernanda|Teixeira|
- E clicar em criar
- Então visualizo a mensagem: 2 errors proibiu que este usuário fosse salvo:

[Situação onde o usuário não cadastra o ultimo nome(campo obrigatório)]

[Teste Invalido] - O teste é executado, porém a mensagem apresentada é de usuário criado com sucesso o que pode ser considerado erro pois o campo Ultimo nome é obrigatório.

Cenario 4: Cadastro com sucesso
- Dado que estou na pagina de cadastro
- Quando preencher somente nome e email como campo obrigatório
- |Nome|Email|
- |Fernanda|fernanda12456@gmail.com.br|
- E clicar em criar
- Então visualizo a mensagem: 2 errors proibiu que este usuário fosse salvo:

[Link do Git do cenario 4 = https://github.com/loorao/TesteAnalistaErro]
