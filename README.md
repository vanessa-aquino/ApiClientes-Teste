# ApiClientes
Este projeto foi desenvolvido como parte de um desafio técnico e consiste em uma API REST simples para cadastro e listagem de clientes.

## 🚀 Como rodar o projeto

### Pré-requisitos
- .NET SDK 9.0 ou superior

### Passos
1. Clone o repositório:
   ```bash
   git clone <https://github.com/vanessa-aquino/ApiClientes-Teste>
2. Acessa a pasta do projeto
   ```bash
   cd ApiClientes-Teste/ApiClientes
3. Execute a aplicação
   ```bash
   dotnet run
4. A API será iniciada e o Swagger abrirá automaticamente no navegador:
   ```bash
   http://localhost:<porta>/swagger
   
## 🛠 Tecnologias utilizadas

- .NET 9  
- ASP.NET Core Web API  
- Entity Framework Core  
- SQLite  
- Swagger (Swashbuckle.AspNetCore)

## 🧠 Decisões técnicas

- A aplicação foi desenvolvida utilizando uma **API REST simples**, evitando complexidade desnecessária e focando no escopo do desafio.
- O **SQLite** foi escolhido por ser um banco de dados leve, local e de fácil execução, não exigindo configurações adicionais para rodar o projeto.
- A persistência de dados é feita através do **Entity Framework Core**, utilizando convenções padrão.
- As validações de entrada são realizadas com **DataAnnotations**, aproveitando o comportamento automático do atributo `[ApiController]`.
- Foi implementada uma validação para garantir que não existam clientes com **email duplicado**.
- O **Swagger** foi utilizado para facilitar a visualização e testes dos endpoints da API.

## 📌 Endpoints disponíveis

### POST /api/clientes
Cadastra um novo cliente.

### GET /api/clientes
Retorna a lista de clientes cadastrados.
