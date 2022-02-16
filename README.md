# RS2-2021
Vjezbe iz predmeta RS2 - 2021


User: admin
Password: test

* GIT COMMANDS: https://www.earthdatascience.org/workshops/intro-version-control-git/basic-git-commands/

* DOCKER SQL IMAGE https://hub.docker.com/_/microsoft-mssql-server

    docker pull mcr.microsoft.com/mssql/server:2019-latest

    docker run -e "ACCEPT_EULA=Y" -e "Password123" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

* NUGET: Microsoft.Aspnetcore.app (db, security, logging etc)

* DB Scaffold

https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=vs

Scaffold-DbContext 'Data Source=DESKTOP-J078S2I;Initial Catalog=eProdaja; User=sa; Password=Password123' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database


* EF core

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

* Automapper
https://code-maze.com/automapper-net-core/

