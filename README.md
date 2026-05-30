# 🏃‍♂️ AltRun API

---

![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)
![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)
![Swagger](https://img.shields.io/badge/-Swagger-%2385EA2D?style=for-the-badge&logo=swagger&logoColor=black)

A **AltRun API** é uma API REST robusta desenvolvida para o gerenciamento de usuários com autenticação segura via tokens JWT (JSON Web Tokens). O projeto foi construído seguindo uma **arquitetura em camadas**, garantindo uma estrutura organizada, de fácil manutenção e altamente escalável.

---

## 🚀 Funcionalidades

- ✅ **Cadastro de Usuários:** Criação de novas contas com armazenamento seguro.
- 🔑 **Autenticação Segura:** Sistema de login com geração de Token JWT.
- 🛡️ **Proteção de Rotas:** Endpoints críticos protegidos via atributo `[Authorize]`.
- 👥 **Controle de Acesso (RBAC):** Diferenciação de permissões por Roles (`Usuário` / `Administrador`).
- 💾 **Banco de Dados Leve:** Persistência local utilizando SQLite através do Entity Framework Core.
- 📖 **Documentação Viva:** Interface interativa do Swagger para testes rápidos.

---

## 🏗️ Arquitetura do Projeto

O projeto adota o padrão de separação de responsabilidades em camadas:

```text
📂 AltRun-API
 ├── 📁 Controllers  # Endpoints e recepção das requisições da API
 ├── 📁 Services     # Regras de negócio da aplicação
 ├── 📁 Auth         # Lógica de criptografia e geração do token JWT
 ├── 📁 Data         # Contexto do Entity Framework e acesso ao SQLite
 ├── 📁 DTOs         # Objetos de Transferência de Dados (Data Transfer Objects)
 ├── 📁 Middleware   # Captura global e tratamento amigável de erros
 └── 📁 Models       # Entidades estruturais do banco de dados
