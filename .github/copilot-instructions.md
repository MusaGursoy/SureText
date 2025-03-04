# Copilot Instructions

## 1. Code Style
- Use **C# latest features** and best practices.
- Follow **Microsoft C# coding conventions** (e.g., `PascalCase` for class names, `camelCase` for variables).
- Use **meaningful and descriptive** variable, method, and class names.
- Include **XML documentation comments** (`///`) for all **public classes, methods, and interfaces**.
- Keep methods **small and focused** (Single Responsibility Principle).
- Use **expression-bodied members** where appropriate for brevity.

## 2. Architecture
- Follow **SOLID principles** to improve maintainability and flexibility.
- Implement **Clean Architecture**:
  - **Domain Layer** → Business rules and entities (independent of other layers).
  - **Application Layer** → Services, use cases, DTOs.
  - **Infrastructure Layer** → Database, APIs, repositories.
  - **Presentation Layer** → Controllers, UI.
- Use **Dependency Injection (DI)** for managing dependencies.
- Apply **repository and unit of work patterns** for data access.

## 3. Testing
- Write **testable code** by following **dependency inversion** and using **interfaces**.
- Include **unit tests** for all new business logic.
- Follow the **AAA (Arrange-Act-Assert)** pattern in unit tests.
- Use **mocking frameworks** (e.g., Moq) where necessary.
- Ensure **high test coverage** without over-testing implementation details.

## 4. Error Handling
- Use structured **exception handling** (`try-catch`) where appropriate.
- Implement **centralized error handling** (e.g., middleware in ASP.NET Core).
- Log exceptions using **ILogger** (or a logging framework like Serilog).
- Validate **input parameters** and return appropriate **HTTP status codes** in APIs.

## 5. Performance
- Consider **memory usage** and avoid unnecessary object allocations.
- Optimize **database queries** (e.g., use `AsNoTracking()` for read operations).
- Use **async/await** for I/O-bound operations to prevent thread blocking.
- Cache frequently accessed data using **in-memory caching** (e.g., `IMemoryCache` or Redis).
- Minimize use of `foreach` inside database queries to avoid **N+1 query issues**.

## 6. Security
- Follow **OWASP security best practices**.
- Validate and sanitize **user input** to prevent **SQL injection** and **XSS attacks**.
- Use **ASP.NET Core Identity** or external authentication providers.
- Implement **role-based or claims-based authorization**.
- Store sensitive data **securely** (e.g., **environment variables**, **Azure Key Vault**).