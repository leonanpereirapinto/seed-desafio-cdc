# Faça um fork desse repositório

Este é um repositório vazio de propósito. A ideia é que você faça um fork para que eu, Alberto, possa usar o github para ter a chance de olhar vários dos códigos produzido por você e seus(as) colegas da Jornada Dev Eficiente :). 

Durante cada uma das seis semanas eu vou pegar código por amostragem e analisar. Feito isso, vou criar um vídeo anonimizando a pessoa que é dona do código, com as minhas observações e postar isso como material de suporte da funcionalidade :). 

# SQL Server
Rodando local com docker:
```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Wk%5k68gU%qo" -p 1433:1433 --name sqlserver-livrariaCDC --hostname sqlserver-livrariaCDC -d mcr.microsoft.com/mssql/server:2022-latest
```

Add migration:
```
dotnet ef migrations add <MigrationName>
```

Atualizar banco:
```
dotnet ef database update
```