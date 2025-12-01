# 🏪 Sistema de Controle - Clientes e Produtos

## 📋 Descrição
Sistema web desenvolvido em ASP.NET Core para gerenciamento de clientes e produtos. Projeto desenvolvido como parte do curso técnico em informática.
<img width="1018" height="594" alt="Tela-Principal" src="https://github.com/user-attachments/assets/a7fb3242-3794-402f-bfdc-7027e270d68c" />

## 🚀 Tecnologias Utilizadas
- **ASP.NET Core** 6.0
- **C#** 10.0
- **MVC** (Model-View-Controller)
- **Bootstrap** 5.2.3
- **jQuery** 3.6.0
- **HTML5** e **CSS3**

## 📂 Estrutura do Projeto

PtccAsp.net/
├── Controllers/ # Controladores MVC
│ ├── HomeController.cs
│ ├── ClienteController.cs
│ ├── CadastroClienteController.cs
│ ├── CadastroProdutoController.cs
│ ├── LoginController.cs
│ └── ProdutosCadastradosController.cs
├── Models/ # Modelos de dados
│ ├── Cliente.cs
│ ├── CadastroProduto.cs
│ ├── Usuario.cs
│ ├── Login.cs
│ └── ErrorViewModel.cs
├── Views/ # Páginas web
│ ├── Home/
│ │ ├── Index.cshtml
│ │ └── Privacy.cshtml
│ ├── Cliente/
│ │ └── Cliente.cshtml
│ ├── CadastroCliente/
│ │ └── CadastroCliente.cshtml
│ ├── CadastroProduto/
│ │ └── CadastroProduto.cshtml
│ ├── Login/
│ │ └── LoginFuncionario.cshtml
│ ├── ProdutosCadastrados/
│ │ └── ProdutosCadastrados.cshtml
│ └── Shared/
│ ├── _Layout.cshtml
│ └── Error.cshtml
├── wwwroot/ # Arquivos estáticos (CSS, JS, imagens)
└── Program.cs # Arquivo principal


## 🎯 Funcionalidades
- ✅ **Cadastro de Clientes** - Registrar novos clientes no sistema
- ✅ **Cadastro de Produtos** - Adicionar produtos ao estoque
- ✅ **Login de Funcionários** - Acesso restrito para funcionários
- ✅ **Listagem de Produtos** - Visualizar produtos cadastrados
- ✅ **Interface Responsiva** - Funciona em computador e celular
- ✅ **Validação de Formulários** - Verificação de dados inseridos

## 🛠️ Como Executar o Projeto
1. **Clone o repositório:**
   ```bash
   git clone https://github.com/OrlandoRoberto/PtccAsp.net.git

   Abra no Visual Studio 2022:

Abra o arquivo PtccAsp.net.slnx

Restaure os pacotes:

O Visual Studio faz automaticamente

Execute o projeto:

Pressione F5 ou clique em "IIS Express"

📝 Requisitos do Sistema
Windows 10/11

Visual Studio 2022

.NET 6.0 SDK

Navegador moderno (Chrome, Edge, Firefox)

👨‍🏫 Para Professores e Avaliadores
Este projeto foi desenvolvido como Trabalho de Conclusão de Curso (TCC) seguindo todos os requisitos solicitados na disciplina. O sistema implementa os conceitos aprendidos durante o curso técnico em informática.

👤 Autor
Orlando Roberto
Estudante de Desenvolvimento de Sistemas
Curso Técnico em Informática

📄 Licença
Este é um projeto educativo desenvolvido para fins acadêmicos.

Desenvolvido com dedicação para o curso técnico 🎓
