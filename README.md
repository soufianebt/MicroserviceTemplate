# MicroserviceTemplate

## Using the template

This repository is a .NET microservice template intended to bootstrap new services quickly and consistently. Below are the main benefits and the common `dotnet` commands to install and create projects from the template.

- **Consistency:** Provides a well-structured solution layout (API, Data, DAL, Service, SAL, Models) so teams follow a single standard.
- **Productivity:** Saves time by scaffolding common layers, configuration, and a sample controller so you can focus on business logic.
- **Best practices:** Includes sensible defaults (appsettings, EF Core context, DI registration) that you can extend.
- **Extensibility:** Easy to adapt — replace or remove layers you don't need, or add new modules.

**Install the template package**

If this repository is published as a NuGet template package (for example `MicroserviceTemplate.Template`), you can install it globally or locally.

- Install globally (available to all users on the machine):

```powershell
dotnet new -i .
```

**Create a new project from the template**

Once installed, list available templates to verify the template id:

```powershell
dotnet new --list
```

Create a new project using the template id (replace `microservice` with the actual template short name if different):

```powershell
dotnet new microservice -n MyNewService -o MyNewService
cd MyNewService
```

This creates a solution and the recommended project layout. Typical next steps:

- Restore and build:

```powershell
dotnet restore
dotnet build
```

- Run the API project in vscode or visual studio