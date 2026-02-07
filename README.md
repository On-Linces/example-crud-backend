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

## License

Proprietary
