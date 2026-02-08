# Api — ASP.NET Core (.NET 10)

API REST en C# usando ASP.NET Core (.NET 10) y SQLite.

## Stack

- ASP.NET Core (.NET 10)
- C#
- Entity Framework Core
- SQLite

## Requirements

- .NET 10 SDK

## Quick Start

```bash
cd Api
dotnet run
```

## Instalación
- Instala los paquetes necesarios:
  - `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
  - `dotnet add package Microsoft.EntityFrameworkCore.Design`
  - `dotnet add package Microsoft.EntityFrameworkCore.Tools`

- Instala la CLI de EF Core:
  - Global: `dotnet tool install --global dotnet-ef`
  - Local (opcional): `dotnet new tool-manifest` (solo la primera vez) y `dotnet tool install dotnet-ef`

- Verifica: `dotnet ef --version`

- Crear una nueva migración:
  - `dotnet ef migrations add NombreDeLaMigracion`

- Aplicar las migraciones y actualizar la base de datos:
  - `dotnet ef database update`

- Eliminar la última migración (si necesitas deshacerla antes de aplicar):
  - `dotnet ef migrations remove`

- La API crea automáticamente la base de datos `productos.db` al iniciar.
- CORS está configurado para permitir peticiones desde `http://localhost:5173` (dev frontend).
- Swagger/OpenAPI está disponible en entorno de desarrollo.

## Endpoints principales

- GET /api/productos
- GET /api/productos/{id}
- POST /api/productos
- PUT /api/productos/{id}
- DELETE /api/productos/{id}

## Base de datos

- Archivo SQLite: `Api/productos.db`

---
