# Prueba Técnica - Clientes API & Frontend

Este repositorio contiene dos proyectos principales organizados de la siguiente forma:

- **Backend (API REST en .NET 8 / SQL Server)**
  - Ubicación: `ApiClientes/`
  - Arquitectura por capas (API, Services, Repositories, DTOs, Data).
  - Expone endpoints REST para consultar clientes.
  - Documentación con Swagger disponible.

- **Frontend (Angular 18)**
  - Ubicación: `ClientesFrontend/clientes-app/`
  - Aplicación web para consultar clientes por número de identificación.
  - UI con Angular Material.
  - Consume la API del backend mediante `HttpClient`.

---

## 📂 Estructura del Repositorio

```
PruebaTecnica/
│── ApiClientes/                  # Proyecto backend .NET 8
│   ├── ClientesApi.API/          # Controladores y configuración
│   ├── ClientesApi.Services/     # Lógica de negocio
│   ├── ClientesApi.Repositories/ # Acceso a datos (EF Core)
│   ├── ClientesApi.DTOs/         # Data Transfer Objects
│   └── README.md (opcional)
│
│── ClientesFrontend/
│   └── clientes-app/             # Proyecto Angular 18
│       ├── src/app/              # Componentes y servicios
└── README.md                     # Este archivo
```

---

## 🛠️ Tecnologías Utilizadas

- **Backend**
  - .NET 8 (ASP.NET Core Web API)
  - Entity Framework Core (Code First)
  - AutoMapper
  - SQL Server 2019+
  - Swagger (Swashbuckle)

- **Frontend**
  - Angular 18
  - Angular Material
  - RxJS & HttpClient
  - TypeScript

---

### Como Activar el proyecto
### 1. Backend (.NET 8 API)

1. Ir a la carpeta del proyecto API:   
   cd ApiClientes/ClientesApi.API   

2. Restaurar paquetes:   
   dotnet restore   

4. Ejecutar la API:
   dotnet run

5. Swagger disponible en:   
   https://localhost:5001/swagger   

---

### 2. Frontend (Angular 18)

1. Ir a la carpeta del proyecto Angular:   
   cd ClientesFrontend/clientes-app   

2. Instalar dependencias:   
   npm install   

3. Ejecutar el servidor de desarrollo:   
   ng serve -o   

4. La app estará disponible en:   
   http://localhost:4200   

## Endpoints principales

- **GET** `/api/clientes/{identificacion}`  
  Retorna los datos del cliente por número de identificación.  
  - **200 OK** → Datos del cliente.  
  - **404 Not Found** → Cliente no encontrado.  

Ejemplo de respuesta:
```json
{
  "idCliente": 1,
  "identificacion": "12345678",
  "nombre": "Josep",
  "apellido": "Pérez",
  "email": "josep.perez@email.com",
  "fechaCreacion": "2025-09-10T10:00:00",
  "fechaActualizacion": "2025-09-15T14:00:00"
}

## Conexión Frontend ↔ Backend
En `ClientesFrontend/clientes-app/src/app/services/cliente.service.ts`,  
asegúrate de configurar la **URL base de la API** (ejemplo):
```ts
private apiUrl = 'https://localhost:5001/api/clientes';
```
## Notas
- Habilitar **CORS** en el backend (`Program.cs`) para permitir peticiones desde Angular:
  ```csharp
  builder.Services.AddCors(options =>
  {
      options.AddPolicy("AllowAngular",
          policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
  });

  var app = builder.Build();
  app.UseCors("AllowAngular");
- Base de datos: `DBClientes` con tabla `Clientes`.

Autor: **JOSE WILLIAM CAIPA**   
Repositorio: [https://github.com/jowcat/PruebaTecnica](https://github.com/jowcat/PruebaTecnica)
