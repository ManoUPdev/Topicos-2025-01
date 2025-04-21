-------- Comandos para manipular C# e React -----------


Solução ou Solution (C#)

Uma solution no ambiente Microsoft é uma estrutura organizacional no ambiente de desenvolvimento, que engloba um ou mais projetos. Cada projeto dentro de uma solution é uma unidade separada de código, recursos e configurações, permitindo que diferentes partes de um programa sejam desenvolvidas e mantidas de forma isolada, mas ainda trabalhando juntas. A solution oferece benefícios como a facilitação da compilação, gerenciamento de dependências entre projetos e a organização de todos os recursos necessários para desenvolver, testar e implantar uma aplicação Microsoft.
No desenvolvimento C#, uma solution serve como um contêiner que reúne projetos relacionados, permitindo que desenvolvedores coordenem, compensem dependências e mantenham uma estrutura organizada para construir aplicativos complexos. Ela ajuda a melhorar a colaboração entre equipe, simplificar testes e depuração e oferece uma visão holística do panorama do desenvolvimento, unificando projetos independentes em um fluxo de trabalho coeso.

Comandos:

Criação de uma Solução: 
dotnet new sln --output MySolution

Criação de uma aplicação console: 
dotnet new console --name NomeDoProjeto

Criação de uma aplicação console com o método Main: 
dotnet new console --name NomeDoProjeto –use-program-main

Criação de uma aplicação console escolhendo a versão do .NET: 
dotnet new console --name NomeDoProjeto -f net8.0

Criação de uma aplicação Web API: 
dotnet new webapi --name NomeDoProjeto -f net8.0

Adicionando um projeto dentro de uma solução: 
dotnet sln add NomeDoProjeto

Rodar uma aplicação: 
dotnet run

Rodar uma aplicação com o watch: 
dotnet watch run

Restaura as dependências e as ferramentas de um projeto: 
dotnet restore

Adiciona uma referência de pacote a um projeto:
dotnet add package NomeDoPacote

Instalar a ferramenta de gerenciamento do Entity Framework: 
dotnet tool install --global dotnet-ef --version x

Adicionar uma nova migração: 
dotnet ef migrations add NomeMigracao

Atualizar o banco de dados conforme a última migração: 
dotnet ef database update


---------Um breve resumo de React -------------

React é uma biblioteca de JavaScript de código aberto utilizada para a construção de interfaces de usuário interativas e escaláveis. Desenvolvida pelo Facebook, ela permite a criação de componentes reutilizáveis que podem ser combinados para formar complexas interfaces de usuário, facilitando o desenvolvimento e manutenção de aplicações web. Com o React, é possível renderizar o conteúdo da página de forma dinâmica e eficiente, além de possibilitar a atualização de componentes específicos sem a necessidade de recarregar toda a página. 

	
Criar uma aplicação em React: 
npx create-react-app my-app --template typescript

Rodar a aplicação: 
npm start

Instalar dependências: 
npm i


