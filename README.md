1. Projeto de Cadastro

2. Stack
   1. .NET 6
   2. EF 6
   3. Docker (apenas para o banco de dados)
   4. Swagger


+ Como rodar a aplicação:

1> Database
Para subir o banco de dados, precisamos executar um docker compose.
A descrição de como subir e desmontar o ambiente estão nas duas primeiras linhas do mariadb_phpmyadmin.yml dentro da pasta database
Feito isso, em tese vc não precisara alterar a string de conexão, que esta no arquivo appsettings.json

PS: Lembre que vc vai precisar ter o docker e o docker compose instalados, preferencialmente no WSL-2

2> EF Migrations
Acesse um powershell com o perfil de administrador para:
dotnet tool install --global dotnet-ef

Agora acesse a pasta que tem o arquivo .csproj para executar o "ef migrations" para criar o banco de dados:
dotnet ef database update -- --environment Production

Para maiores detalhes: https://docs.microsoft.com/en-us/ef/core/cli/dotnet

Pronto.

Agora só apertar F5 no Visual Studio e rodar a aplicação.