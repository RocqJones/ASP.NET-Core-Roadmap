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
## Adding a database context.
The `database context` is the main class that coordinates Entity Framework functionality for a data model. This class is created by deriving from the [Microsoft.EntityFrameworkCore.DbContext class](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-5.0).
* ## Add NuGet packages
  - From the **Tools menu**, select `NuGet Package Manager > Manage NuGet Packages for Solution`.
  - Select the Browse tab, and then enter **Microsoft.EntityFrameworkCore.InMemory** in the search box.
  - Select **Microsoft.EntityFrameworkCore.InMemory** in the left pane.
  - Select the **Project checkbox** in the right pane and then select `Install`.
* ## Add the TodoContext database context
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
