# InventoryApi

API de gerenciamento de produtos construída com **.NET 7**, **MySQL**, **Entity Framework Core**, **AutoMapper** e **FluentValidation**.

Permite realizar operações de CRUD em produtos, com validações, histórico de erros e documentação via **Swagger**.

---

## Tecnologias Utilizadas

- **.NET 7**
- **Entity Framework Core**
- **MySQL**
- **AutoMapper**
- **FluentValidation**
- **Swagger (Swashbuckle)**

---

## Funcionalidades

- Listar todos os produtos
- Buscar produto por ID
- Criar novo produto
- Atualizar produto existente
- Deletar produto
- Validação de dados usando FluentValidation
- Documentação de API via Swagger

---

## Pré-requisitos

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [MySQL](https://dev.mysql.com/downloads/mysql/)
- IDE (Visual Studio, VS Code, Rider etc.)

---

## Configuração

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/InventoryApi.git
cd InventoryApi/InventoryApi
```
2.Instale os pacotes do projeto:

"dotnet restore"

3.Configure a string de conexão no appsettings.json:
```
"ConnectionStrings": {
  "DefaultConnection": "server=SEU_HOST;port=3306;database=SEU_BANCO;user=SEU_USUARIO;password=SUA_SENHA;SslMode=Required;"
}
```

4.Aplique as migrações para criar o banco de dados:

"dotnet ef database update"

5.Execute a API:

"dotnet run"

6.Acesse a documentação Swagger:
```
https://localhost:5001/swagger/index.html

```

#Endpoints
Método	Endpoint	Descrição
GET	/api/products	Lista todos os produtos
GET	/api/products/{id}	Busca produto pelo ID
POST	/api/products	Cria um novo produto
PUT	/api/products/{id}	Atualiza um produto existente
DELETE	/api/products/{id}	Deleta um produto

#Observações

Certifique-se de que o MySQL esteja rodando e que a string de conexão esteja correta.

Variáveis sensíveis (usuário, senha) podem ser armazenadas em um arquivo .env ou serviço de configuração seguro.

Recomenda-se testar a API usando o Swagger ou ferramentas como Postman.
