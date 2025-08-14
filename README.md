# Desafio Técnico - API e Front-end de Produtos

Este é um projeto desenvolvido como parte de um desafio técnico, focado na criação de uma API REST para gerenciamento de produtos e um front-end simples para consumi-la.

## Tecnologias Utilizadas

**Back-end:**
- **.NET 8.0:** Framework para a construção da API.
- **ASP.NET Core:** Para a criação da API RESTful.
- **Entity Framework Core:** ORM utilizado para interagir com o banco de dados em memória (SQLite).
- **Swagger/OpenAPI:** Para a documentação e testes da API.

**Front-end:**
- **React:** Biblioteca para a interface do usuário.
- **Axios:** Cliente HTTP para comunicação com a API.

## Boas Práticas de Desenvolvimento

Neste projeto, foram aplicadas as seguintes boas práticas:
- **Separação de Responsabilidades (SRP):** A lógica de negócio e de acesso a dados foi isolada em uma camada de serviço (`Services`), deixando o controlador responsável apenas pelo tratamento das requisições HTTP.
- **Injeção de Dependência (DIP):** O serviço e o contexto do banco de dados são injetados nos controladores, garantindo um código mais flexível e fácil de manter.
- **Data Transfer Objects (DTOs):** Utilizei DTOs (`ProdutoPostDTO` e `ProdutoGetDTO`) para separar o modelo de dados do banco da estrutura de dados exposta pela API, o que aumenta a segurança e flexibilidade.

## Como Executar o Projeto

### Pré-requisitos

Certifique-se de que você tem o seguinte instalado:
- SDK do .NET 8.0
- Node.js e npm
- Visual Studio (ou Visual Studio Code)

### Back-end

1.  Abra o arquivo `ProvaTecnica.sln` no Visual Studio.
2.  Execute o projeto. A API será iniciada em `https://localhost:7194`.

### Front-end

1.  Abra o terminal na pasta `frontend-app`.
2.  Instale as dependências: `npm install`
3.  Inicie o servidor de desenvolvimento: `npm start`
4.  O front-end estará disponível em `http://localhost:3000` (ou outra porta disponível).

### Uso da Aplicação
- O front-end permite cadastrar novos produtos e visualizá-los em uma lista.
- Para testar a API diretamente, acesse o Swagger em `https://localhost:7194/swagger/index.html`.
