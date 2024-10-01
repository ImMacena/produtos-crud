# Teste Técnico: CRUD API em ASP.NET Core WebAPI

## Descrição

Este projeto implementa uma API RESTful para gerenciar produtos, com operações de CRUD (Create, Read, Update, Delete). A API é desenvolvida utilizando **ASP.NET Core WebAPI** e **Entity Framework Core**, seguindo boas práticas de desenvolvimento, como validação, tratamento de exceções e injeção de dependência.

## Funcionalidades

- **Criar um Produto** (`POST /api/produtos`)
- **Listar todos os Produtos** (`GET /api/produtos`)
- **Obter um Produto por ID** (`GET /api/produtos/{id}`)
- **Atualizar um Produto** (`PUT /api/produtos/{id}`)
- **Deletar um Produto** (`DELETE /api/produtos/{id}`)

### Produto

O Produto contém as seguintes propriedades:

- `Id` (int ou GUID): Identificador único.
- `Nome` (string): Nome do produto (obrigatório, até 100 caracteres).
- `Descrição` (string): Descrição opcional (até 500 caracteres).
- `Preço` (decimal): Preço do produto (obrigatório, positivo).
- `DataCadastro` (DateTime): Data de cadastro, gerada automaticamente.

## Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- SQL Server
- Injeção de dependência
- Tratamento de exceções global

## Configuração do Projeto

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Passo a Passo para Rodar a Aplicação

1. **Clone o repositório**:

   ```bash
   git clone https://github.com/immacena/produtos-crud.git
   ```

2. **Instale as dependências**:
   No diretório do projeto, execute o comando:

   ```bash
   dotnet restore
   ```

3. **Configure o banco de dados**:
   Altere a string de conexão com o SQL Server no arquivo `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server={your_server_name};Database={database_name};Trusted_Connection=True"
   }
   ```

4. **Rodar as Migrations**:

   ```bash
   dotnet ef database update
   ```

5. **Execute a aplicação**:

   ```bash
   dotnet run
   ```

6. **Testar a API**:
   Utilize uma ferramenta como **Postman** ou **Swagger** (disponível em `/swagger`) para testar os endpoints da API.

## Testes de Integração (Opcional)

- Se foram implementados, rode os testes de integração com:
  ```bash
  dotnet test
  ```

## Observações

- Lembre-se de garantir que o SQL Server esteja rodando corretamente antes de executar a aplicação.

## Autor

Desenvolvido por Guilherme Macena Lopes.
