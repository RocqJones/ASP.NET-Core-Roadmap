# ASP.NET-Core-Roadmap

**ASP.NET Core** is a *cross-platform, high-performance, open-source* framework for building modern, cloud-enabled, Internet-connected apps. With ASP.NET Core, you can: Build web apps and services, Internet of Things (IoT) apps, and mobile backends.

## Updating initial migrations steps.
In this section, the **Package Manager Console (PMC)** is used to:
* Add an initial migration.
* Update the database with the initial migration.

From the **Tools menu**, select **NuGet Package Manager > Package Manager Console**.
* In the PMC, enter the following commands:

PowerShell
```Powershell
Add-Migration Initial
Update-Database
```
* The `Add-Migration` command generates code *to create the initial database schema*. The schema is based on the model specified in the DbContext, in the RazorPagesMovieContext.cs file. The InitialCreate argument is used to name the migration.
* The `Update-Database` command *runs the Up method* in the **Migrations/<time-stamp>_InitialCreate.cs file**. The Up method creates the database.
  
## The @model directive.
```CSHTML
@page
@model RazorPagesMovie.Pages.Movies.IndexModel
```
The `@model` directive specifies the type of the model passed to the Razor Page. In the preceding example, the `@model` line makes the `PageModel`-derived class available to the Razor Page. The model is used in the `@Html.DisplayNameFor` and `@Html.DisplayFor` HTML Helpers on the page.

## Examine the lambda expression used in the following HTML Helper.
```CSHTML
@Html.DisplayNameFor(model => model.Movie[0].Title)
```
## API Development.
## 1. Adding a database context.
The `database context` is the main class that coordinates Entity Framework functionality for a data model. This class is created by deriving from the [Microsoft.EntityFrameworkCore.DbContext class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-5.0).
* ### Add NuGet packages
  - From the **Tools menu**, select `NuGet Package Manager > Manage NuGet Packages for Solution`.
  - Select the Browse tab, and then enter **Microsoft.EntityFrameworkCore.InMemory** in the search box.
  - Select **Microsoft.EntityFrameworkCore.InMemory** in the left pane.
  - Select the **Project checkbox** in the right pane and then select `Install`.
* ### Add the TodoContext database context
  - Right-click the Models folder and select `Add > Class`. Name the class `ExampleContext` and click Add.
```CSharp
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options): base(options)
        {
        }
        public DbSet<TodoItem> ExampleItems { get; set; }
    }
}
```
## 2. Register the database context.
In ASP.NET Core, services such as the **DB context** must be registered with the **dependency injection (DI) container**. The container provides the service to controllers (update Startup.cs). 
## 3. Scaffold a controller.
* Right-click the Controllers folder.
* Select Add > `New Scaffolded Item`.
* Select `API Controller with actions, using Entity Framework`, and then select `Add`.
* In the Add API Controller with actions, using Entity Framework dialog:
  - Select `TodoItem (TodoApi.Models)` in the Model class.
  - Select `ExampleContext (TodoApi.Models)` in the Data context class and Select Add.

The generated code:
* Marks the class with the [[ApiController]](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.apicontrollerattribute?view=aspnetcore-5.0) attribute. This attribute indicates that `the controller responds to web API requests`. For information about specific behaviors that the attribute enables, see [Create web APIs with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0).
* Uses DI to inject the database context (ExampleContext) into the controller. The database context is used in each of the [create, read, update, and delete(CRUD) methods](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete) in the controller.
The ASP.NET Core templates for:

Controllers with views include [action] in the route template.
API controllers don't include [action] in the route template.
When the [action] token isn't in the route template, the action name is excluded from the route. That is, the action's associated method name isn't used in the matching route.
