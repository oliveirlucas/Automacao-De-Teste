#language: pt

Funcionalidade: Cadastro de Usuário
    Sendo um usuário do site
    Posso acessar o site de Automação
    Para realizar cadastros de um novo usuário


Cenario: Cadastro com sucesso
Dado que estou na pagina de cadastro
Quando preencher todos os campos
|Nome|Ultimo nome|Email|Endereço|Universidade|Profissão|Genero|Idade|
|Fernanda|Teixeira|fernanda12456@gmail.com.br|Rua X, 1234|Unibh|QA|Feminino|26|
E clicar em criar
Então visualizo a mensagem: Usuário Criado com sucesso