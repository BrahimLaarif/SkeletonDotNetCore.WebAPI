# ASP.NET Core Web API Skeleton

A simple ASP.NET Core Web API application with:
- Sqlite provider
- Entity Framework Core
- Data Seeder
- Repository design pattern
- Data Transfer Object (DTO)
- AutoMapper

## Installation

1. Install [.Net Core 2.1](https://www.microsoft.com/net/core)
2. Clone this repository
    ```bash
    git clone https://github.com/BrahimLaarif/SkeletonDotNetCore.WebAPI.git
    cd SkeletonDotNetCore.WebAPI
    ```
3. Install the dependencies
    ```bash
    dotnet restore
    ```
4. Run the migrations
    ```bash
    dotnet ef database update
    ```
5. Run the application
    ```bash
    dotnet run
    ```

## Endpoint List
- GET /api/values
- GET /api/values/:id
- POST /api/values
- PUT /api/values/:id
- DELETE /api/values/:id