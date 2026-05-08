# 🚀 AltRun API

API backend desenvolvida em **.NET 8** com autenticação JWT, organização em camadas e banco de dados SQLite.

---

## Sobre o projeto

A **AltRun API** é uma API REST criada para gerenciar usuários com autenticação segura via JWT, utilizando arquitetura organizada para facilitar manutenção e escalabilidade.

---

## Funcionalidades

- ✔ Registro de usuários
- ✔ Login com geração de JWT
- ✔ Proteção de rotas com `[Authorize]`
- ✔ Controle de roles (User/Admin)
- ✔ Banco de dados SQLite
- ✔ Swagger para testes da API

---

## Autenticação

A API utiliza **JWT Bearer Token**.

Para acessar rotas protegidas:

1. Faça login:
