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
