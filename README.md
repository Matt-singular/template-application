# .NET 8 Project

Welcome to the .NET 8 project template! 

This project is organized into several key components, each responsible for different aspects of the application. Below is an overview of each project and its responsibilities.

## Project Structure Overview

```mathematica
Solution
├── Application/
│   ├── Application.API
│   ├── Application.GUI
│   │   ├── Properties/
│   │   ├── Platforms/
│   │   ├── Resources/
│   │   ├── Views/
│   │   └── ViewModels/
│   ├── Application.Console
│   └── README.md
├── Business/
│   ├── Application.Domain
│   │   ├── Config/
│   │   ├── DataRepository/
│   │   ├── Extensions/
│   │   ├── Services/
│   │   └── ThirdPartyServices/
│   └── Application.Infrastructure
│       ├── DataRepository/
│       ├── Extensions/
│       ├── Services/
│       └── ThirdPartyServices/
├── Common/
│    ├── Application.Authorisation
│    └── Application.Shared
└── Tests/
     ├── Application.Console.Tests
     ├── Application.Domain.Tests
     ├── Application.Infrastructure.Tests
     ├── Application.Benchmarks
     └── Application.IntegrationTests
         ├── ConsoleIntegrationTests/
         ├── DomainIntegrationTests/
         └── InfrastructureIntegrationTests/
```


## Project Layers in more details

# Application
### Application.API
This project is responsible for the API layer of the application. It handles HTTP requests and responses, routing, and API-specific logic.

### Application.GUI
This project contains the graphical user interface (GUI) for the application. It is organized into the following subfolders:
- **Views/**: Contains the user interface elements.
- **ViewModels/**: Contains the logic and data bindings for the views.
- **Resources/**: Contains additional resources such as images, styles, and other assets.

### Application.Console
This project provides a console interface for the application. It includes:
- **Program.cs**: The entry point of the console application.
- **Services/**: Contains the services used by the console application.

# Business
### Application.Domain
This project encapsulates the core business logic of the application. It includes:
- **Config/**: Defines value objects used in the domain model.
- **Extensions/**: Contains extension methods for various purposes.
- **Services/**: Business logic services.
- **ThirdParty/**: Integrations with third-party libraries or services.

### Application.Infrastructure
This project handles data access and other infrastructure concerns. It includes:
- **Extensions/**: Contains extension methods for various purposes.
- **Data/**: Contains data access logic and database-related code.
- **Services/**: Infrastructure services such as logging, caching, etc.
- **ThirdParty/**: Integrations with third-party infrastructure services.

# Common
## Application.Authorisation
This project handles the authorization and authentication logic for the application.

## Application.Shared
This project contains shared resources and utilities that are used across multiple projects within the solution.

# Tests
This folder contains various test projects to ensure the quality and correctness of the application. It includes:
- **Application.Console.Tests/**: Unit tests for the console application.
- **Application.Domain.Tests/**: Unit tests for the domain logic.
- **Application.Infrastructure.Tests/**: Unit tests for the infrastructure layer.
- **Application.Benchmarks/**: Performance benchmarks for different parts of the application.
- **Application.IntegrationTests/**: Integration tests, further divided into:
  - **ConsoleIntegrationTests/**: Integration tests for the console application.
  - **DomainIntegrationTests/**: Integration tests for the domain logic.
  - **InfrastructureIntegrationTests/**: Integration tests for the infrastructure layer.