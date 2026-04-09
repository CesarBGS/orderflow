# OrderFlow API

API REST para gerenciamento de pedidos desenvolvida em **.NET 8**, aplicando **Clean Architecture**, **CQRS com MediatR** e **autenticação JWT**, utilizando **SQL Server** e **Docker**.

---

## Arquitetura

O projeto segue o padrão **Clean Architecture**, dividido em:

- **Domain** → Entidades e contratos (Order, Product, OrderItem, IOrderRepository)
- **Application** → Regras de negócio com CQRS (Commands, Queries e Handlers via MediatR)
- **Infrastructure** → Acesso a dados com Entity Framework Core
- **API** → Controllers, autenticação JWT e configuração da aplicação

---

## Tecnologias utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core 8
- SQL Server
- MediatR (CQRS)
- JWT Bearer Authentication
- Docker & Docker Compose
- Swagger (OpenAPI)

---

## Como rodar o projeto com Docker

```bash
docker compose up --build
