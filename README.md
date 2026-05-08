AltRun API

API backend desenvolvida em .NET 8 com autenticação JWT, arquitetura em camadas e banco de dados SQLite.

Sobre o projeto

A AltRun API é uma API REST para gerenciamento de usuários com autenticação via JWT. O projeto foi estruturado em camadas para facilitar organização, manutenção e escalabilidade.

Funcionalidades
Cadastro de usuários
Login com geração de JWT
Proteção de rotas com Authorize
Controle de roles (User/Admin)
Banco de dados SQLite
Swagger para testes
Autenticação

A API utiliza JWT Bearer Token.

Para acessar rotas protegidas:

Fazer login em:
POST /api/user/login
Copiar o token retornado
No Swagger clicar em Authorize
Usar o formato:

Bearer SEU_TOKEN

Endpoints

Usuário:

POST /api/user → criar usuário
POST /api/user/login → login
GET /api/user → listar usuários (protegido)

Estrutura do projeto

Controllers → endpoints da API
Services → regras de negócio
Auth → geração de JWT
Data → acesso ao banco de dados
DTOs → transferência de dados
Middleware → tratamento de erros
Models → entidades

Tecnologias

.NET 8
ASP.NET Core Web API
Entity Framework Core
JWT Authentication
SQLite
Swagger

Como rodar o projeto

git clone https://github.com/Bleckoutz/altrun-api.git

dotnet restore

dotnet run

Acesso Swagger:
http://localhost:5087/swagger

Banco de dados

SQLite (arquivo local: AltRun.db)

Autor

Rafael Eduardo
