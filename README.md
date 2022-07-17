# Clean Architecture API Solution Template
![.NET Core](https://github.com/jasontaylordev/CleanArchitecture/workflows/.NET%20Core/badge.svg) [![Clean.Architecture.Solution.Template NuGet Package](https://img.shields.io/badge/nuget-1.1.1-blue)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template) [![NuGet](https://img.shields.io/nuget/dt/Clean.Architecture.Solution.Template.svg)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template) [![Twitter Follow](https://img.shields.io/twitter/follow/jasontaylordev.svg?style=social&label=Follow)](https://twitter.com/jasontaylordev)

<br/>

### Database Migrations

To use `dotnet-ef` for your migrations please add the following flags to your command (values assume you are executing from repository root)

* `--project src/Infrastructure` (optional if in this folder)
* `--startup-project src/<YOUR_PROJECT_NAME>.API`
* `--output-dir Persistence/Migrations`

For example, to add a new migration from the root folder:

 `dotnet ef migrations add "SampleMigration" --project Carpool.Infrastructure --startup-project Carpool.API --output-dir Persistence\Migrations`
 

If you're using Package Manager Console, running the migrations is a bit different:

`Add-Migration -Name "SampleMigration" -Project "src\Infrastructure" -Context "ApplicationDbContext" -StartupProject "src\Carpool.API" -OutputDir "Persistence\Migrations" -Verbose`

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### API

This layer is a REST API based on .NET Core 6. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection.

## Support

If you are having problems, please let us know by [raising a new issue](https://github.com/jasontaylordev/CleanArchitecture/issues/new/choose).

## License

This project is licensed with the [MIT license](LICENSE).