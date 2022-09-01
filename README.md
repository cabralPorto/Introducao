# Entity FrameworkCore

### SqlServer:

* C:\doc\introducao> dotnet add Curso\CursoEFCoreDev.csproj package microsoft.EntityFrameworkCore.SqlServer --version 3.1.5

#### Instal Pacotes via Nuget
* PS C:\doc\introducao> dotnet add .\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.Design --version 3.1.5
* PS C:\doc\introducao> dotnet add .\CursoEFCore.csproj package Microsoft.EntityFrameworkCore.Tools --version 3.1.5

####  Migração Com Verbosidade

* PS C:\doc\introducao> dotnet ef migrations add PrimeiraMigracao -p .\Curso\CursoEFCore.csproj -v   
* **Observações: Esse Comando serve para fazer pequenas migrações também. Após executa-lo, 
é preciso Aplicar ao Banco com o código abaixo.**

#### Aplicar Migração ao Banco de Dados:

* PS C:\doc\introducao> dotnet ef database update -p .\Curso\CursoEFCore.csproj -v

#### Gerando Script SQL Idempotente

* PS C:\doc\introducao> dotnet ef migrations script -p .\Curso\CursoEFCore.csproj -o .\Curso\Idempotente.SQL -I

#### RollBack de Migrações:

* PS C:\doc\introducao> dotnet ef database update PrimeiraMigracao -p .\Curso\CursoEFCore.csproj
* **Observação: Update Atualiza o Banco para o estado da Migração desejada, após executar o camando acima execute:**
* PS C:\doc\introducao> dotnet ef migrations remove -p .\Curso\CursoEFCore.csproj
* **Para remover as Migrations da pasta do projeto.**


#### link
[Curso desenvolvedor.io](www.desenvolvedor.io)
