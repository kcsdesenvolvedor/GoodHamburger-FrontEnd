# 🍔 Good Hamburger Web (Blazor)

Aplicação frontend desenvolvida em **Blazor WebAssembly** para consumo da API Good Hamburger, permitindo criação, visualização, edição e exclusão de pedidos de forma interativa.

---

## 📌 Funcionalidades

* Visualização do cardápio
* Criação de pedidos com validações em tempo real
* Listagem de pedidos
* Edição de pedidos existentes
* Exclusão de pedidos com confirmação
* Feedback visual para validações e estados da aplicação

---

## 🎯 Diferencial

Este frontend foi desenvolvido como um **diferencial opcional do desafio**, com foco em:

* Experiência do usuário (UX)
* Integração completa com a API
* Interface limpa e intuitiva

---

## 🧱 Estrutura do projeto

* **Pages**

  * `Menu.razor` → criação de pedidos
  * `Orders.razor` → listagem de pedidos
  * `EditOrder.razor` → edição de pedidos

* **Models**

  * DTOs para comunicação com a API

* **Shared**

  * Layout e Sidebar

* **Services**

  * Comunicação com a API via HttpClient

---

## ⚙️ Decisões técnicas

* Utilização de **Blazor WebAssembly** para uma aplicação leve e moderna
* Separação de DTOs para evitar acoplamento com o backend
* Uso de **HttpClient configurado via appsettings.json**
* Controle de estado local para gerenciamento do pedido em tela
* Validações em tempo real com `@bind:event="oninput"`
* Uso de ícones (Font Awesome) para melhorar a UX

---

## ▶️ Como executar o projeto

### Pré-requisitos

* .NET 10 SDK
* Backend (API) rodando

---

### 1. Clonar o repositório

```bash id="z7f9x2"
https://github.com/kcsdesenvolvedor/GoodHamburger-FrontEnd.git
```

---

### 2. Acessar o projeto Web

```bash id="9h3lxp"
cd GoodHamburger.FrontEnd
```

---

### 3. Configurar URL da API

Editar o arquivo:

```text id="r5s8d1"
wwwroot/appsettings.json
```

```json id="9m2kqp"
{
  "ApiBaseUrl": "https://localhost:7023/"
}
```

---

### 4. Executar aplicação

```bash id="q8x1pl"
dotnet run
```

---

### 5. Acessar no navegador

```text id="w7v3df"
https://localhost:7136/
```

---

## 🔗 Integração com API

A aplicação consome os seguintes endpoints:

* `GET /menu`
* `POST /orders`
* `GET /orders`
* `GET /orders/{id}`
* `PUT /orders`
* `DELETE /orders/{id}`

---

## 🎨 Experiência do usuário

* Botões desativados com feedback visual
* Validação em tempo real de campos obrigatórios
* Prevenção de itens duplicados no pedido
* Confirmação antes de exclusão
* Navegação fluida entre telas

---

## 📌 O que foi deixado de fora

* Autenticação e autorização
* Responsividade completa

---

## 👨‍💻 Autor

Desenvolvido por [Kellton Castro Silva]
