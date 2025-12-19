## 📌 Sobre o projeto

Esta API, desenvolvida utilizando **.NET 8**, adota os princípios do **Domain-Driven Design (DDD)** para oferecer uma solução estruturada e eficaz no gerenciamento de despesas pessoais.  
O principal objetivo é permitir que os usuários registrem suas despesas, detalhando informações como **título, data e hora, descrição, valor e tipo de pagamento**, com os dados sendo armazenados de forma segura em um banco de dados **MySQL**.

A arquitetura da API baseia-se em **REST**, utilizando métodos HTTP padrão para uma comunicação eficiente e simplificada.  
Além disso, é complementada por uma documentação **Swagger**, que proporciona uma interface gráfica interativa para que os desenvolvedores possam explorar e testar os endpoints de maneira fácil.

Dentre os pacotes **NuGet** utilizados:

- **AutoMapper** é responsável pelo mapeamento entre objetos de domínio e requisição/resposta, reduzindo a necessidade de código repetitivo e manual.
- **FluentAssertions** é utilizado nos testes de unidade para tornar as verificações mais legíveis, ajudando a escrever testes claros e compreensíveis.
- **FluentValidation** é usado para implementar regras de validação de forma simples e intuitiva nas classes de requisições, mantendo o código limpo e fácil de manter.
- **EntityFramework** atua como um ORM (Object-Relational Mapper), simplificando as interações com o banco de dados e permitindo o uso de objetos .NET para manipular dados diretamente, sem a necessidade de lidar com consultas SQL manualmente.

---

## 🚀 Features

- **Domain-Driven Design (DDD)**  
  Estrutura modular que facilita o entendimento e a manutenção do domínio da aplicação.

- **Testes de Unidade**  
  Testes abrangentes com FluentAssertions para garantir a funcionalidade e a qualidade do sistema.

- **Geração de Relatórios**  
  Capacidade de exportar relatórios detalhados para **PDF** e **Excel**, oferecendo uma análise visual e eficaz das despesas.

- **RESTful API com Documentação Swagger**  
  Interface documentada que facilita a integração e o teste por parte dos desenvolvedores.

---

## 🛠️ Construído com

- **.NET 8**
- **Windows**
- **Visual Studio**
- **MySQL**
- **Swagger**

---

## ▶️ Getting Started

Para obter uma cópia local funcionando, siga estes passos simples.

---

## ✅ Requisitos

- **Visual Studio 2022+** ou **Visual Studio Code**
- **Windows 10+**, **Linux** ou **MacOS** com **.NET SDK** instalado
- **MySQL Server**
- 
## ⚙️ Instalação


Siga os passos abaixo para executar o projeto localmente:

1. **Clonar o repositório**
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git

3. Acessar o diretório do projeto
   ```bash
    cd seu-repositorio

3. Configurar o ambiente
Preencha as informações necessárias no arquivo: appsettings.Development.json

Principalmente:

String de conexão com o MySQL

Configurações específicas da aplicação, se houver

4. Executar a API

Pelo Visual Studio:

Abra a solução

Selecione o projeto de inicialização

Execute (F5 ou Ctrl + F5)
