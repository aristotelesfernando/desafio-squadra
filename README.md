# desafio-squadra
Teste App com CQRS e MediatR e talvez... mas talvez um frontend

Necessário ter Docker instalado para executar o SqlServer Express 2019

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=sql@server123" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
