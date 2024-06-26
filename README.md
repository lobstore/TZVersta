# TZVersta
## Шаги для запуска
1. Если не установлен SDK, то установите с официального сайта https://dotnet.microsoft.com/ru-ru/download последюю версию
2. Распакуйте архив с проектом
3. Установите необходимые пакеты NuGet: 
 dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
 dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design
5. Установите pgadmin и postgresql сервер с официального сайта https://www.enterprisedb.com/downloads/postgres-postgresql-downloads 
6. Пропишите указанные при установке postgresql данные в файле конфигурации appsettings.json, в строке подключения "DefaultConnection"
7. Пропишите следующие команды в консоли для создания таблицы в БД и убедидесь в наличии соответствующей таблицы: 
 dotnet ef database update
8. Запустите проект с помощью dotnet run находясь в папке с файлом проекта
9. Перейти в браузере на url https://localhost:7261 или http://localhost:5094
