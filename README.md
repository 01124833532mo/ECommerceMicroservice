# ECommerceMicroservice-UserService

A .NET 8 microservice for managing user authentication and registration in an e-commerce system.

## Overview

`ECommerceMicroservice-UserService` is a layered ASP.NET Core Web API built with:

- **ECommerce.Api** – API layer with controllers, middleware, Swagger, and HTTP pipeline setup
- **ECommerce.Core** – business logic, DTOs, service contracts, validators, and domain entities
- **ECommerce.Infrastructure** – data access layer using Dapper and PostgreSQL

The service currently supports:

- User registration
- User login
- Validation of request payloads
- Centralized exception handling
- Swagger API documentation
- Docker support

## Features

- ASP.NET Core Web API on .NET 8
- Clean layered architecture
- Dapper-based PostgreSQL data access
- FluentValidation for request validation
- CORS configuration for frontend integration
- Swagger UI for API testing
- Custom exception-handling middleware
- Dockerfile included for containerized deployment

## Solution Structure

```text
ECommerceSoloution.sln
├── ECommerce.Api
├── ECommerce.Core
└── ECommerce.Infrastructure
```

### ECommerce.Api
Contains the API entry point, middleware, controllers, and application startup.

### ECommerce.Core
Contains:
- DTOs
- Service contracts
- Service implementations
- Validators
- Core entities

### ECommerce.Infrastructure
Contains:
- Database context
- Dapper repository implementations
- Dependency injection setup for infrastructure services

## Requirements

- .NET 8 SDK
- PostgreSQL database
- Docker (optional)

## Configuration

Update the connection string in `ECommerce.Api/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "Postgres": "Host=localhost;Port=5432;Database=your_db;Username=your_user;Password=your_password"
  }
}
```

## Running Locally

### 1. Clone the repository
```bash
git clone https://github.com/01124833532mo/ECommerceMicroservice-UserService.git
cd ECommerceMicroservice-UserService
```

### 2. Restore dependencies
```bash
dotnet restore
```

### 3. Build the solution
```bash
dotnet build
```

### 4. Run the API
```bash
dotnet run --project ECommerce.Api
```

The API should start with Swagger enabled.

## Docker

Build the image:

```bash
docker build -t ecommerce-userservice -f ECommerce.Api/Dockerfile .
```

Run the container:

```bash
docker run -p 8080:8080 -p 8081:8081 ecommerce-userservice
```

## API Endpoints

The repository appears to include user authentication endpoints such as:

- `POST /api/.../register`
- `POST /api/.../login`

> Note: Replace these with the exact controller routes from your project if needed.

## Authentication Flow

### Register
1. Client sends registration data
2. API validates the request
3. Core service creates an `ApplicationUser`
4. Infrastructure layer inserts the user into PostgreSQL
5. API returns an auth response with user details and token placeholder

### Login
1. Client sends email/password
2. Core service verifies credentials through the repository
3. API returns authentication result

## Technologies Used

- C#
- ASP.NET Core Web API
- .NET 8
- Dapper
- PostgreSQL
- FluentValidation
- Swagger / Swashbuckle
- Docker

## Notes

- The current token value in the register flow appears to be a placeholder:
  - `"This is a dummy token"`
- The repository uses a custom exception-handling middleware.
- CORS is configured for `http://localhost:4200`, likely for an Angular frontend.

## License

No license file was found in the repository.
