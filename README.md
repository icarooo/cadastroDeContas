# cadastroDeContas

Para executar este projeto, siga os passos:

- Crie um banco de dados com o nome "banco" no servidor sql
- Edite a DefaultConnection no arquivo appsettings.json com as credencias corretas para conectar no SqlServer
- Execute as migrations no terminal para criar as tabelas: "dotnet ef database update"
- Execute "dotnet run" na raiz do projeto para iniciar a webapi
