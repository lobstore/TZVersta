# TZVersta
## ���� ��� �������
1. ���� �� ���������� SDK, �� ���������� � ������������ ����� https://dotnet.microsoft.com/ru-ru/download �������� ������
2. ���������� ����� � ��������
3. ���������� ����������� ������ NuGet
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design
4. ���������� pgadmin � postgresql ������ � ������������ ����� https://www.enterprisedb.com/downloads/postgres-postgresql-downloads 
6. ��������� ��������� ��� ��������� postgresql ������ � ����� ������������ appsettings.json, � ������ ����������� "DefaultConnection"
7. ��������� ��������� ������ � ������� ��� �������� ������� � �� � ��������� � ������� ��������������� �������
dotnet ef migrations add InitialCreate
dotnet ef database update
8. ��������� ������ � ������� dotnet run �������� � ����� � ������ �������
9. ������� � �������� �� url https://localhost:7261 ��� http://localhost:5094