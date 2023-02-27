# Simple Phone Book

Simple web application for education with add-remove-edit-search user functionality.
This project is training project for ASP.NET Core with Blazor functionality.

## Table of Contents
1. [Technology stack](https://github.com/miraDask/QuizHut#technology-stack)
2. [Screenshots](https://github.com/baal98/PhoneBookSimpleApp#screenshots)
3. [Application Configurations](https://github.com/miraDask/QuizHut#application-configurations)
4. [Credits](https://github.com/miraDask/QuizHut#credits)

## Technology stack:

- ASP.NET Core 6.01

- Entity Framework Core 6.01

- Blazor

- JavaScript

- jQuery

- Bootstrap

## Screenshots:

### Home Page
<img width="953" alt="Home page" src="https://github.com/baal98/PhoneBookSimpleApp/blob/master/Sample%20Images/WellcomeScr.jpg">

### Create/Edit Page
<img width="959" alt="Create/Edit page" src="https://github.com/baal98/PhoneBookSimpleApp/blob/master/Sample%20Images/CreateEditFnc.jpg">

### Dasboard
<img width="945" alt="Dashboard" src="https://github.com/baal98/PhoneBookSimpleApp/blob/master/Sample%20Images/AllFieldsFnc.jpg">

### Search Page
<img width="949" alt="Search page" src="https://github.com/baal98/PhoneBookSimpleApp/blob/master/Sample%20Images/SearchFnc.jpg">


## Application Configurations:

1. Check connection string in appsettings.json.
   If you don't use SQLEXPRESS you should replace "Server=.\\SQLEXPRESS..." with "Server=.;...".

2. Add new schema for Hangfire in your database using MSSQL Server Manager (CREATE SCHEMA hangfire).

3. In order to use Distributed Sql Cache, you must create Cache table in your.
   Open your command-line in QuizHut.Web folder and run the following command:
   >dotnet sql-cache create "Server=.\SQLEXPRESS;Database=QuizHut;Trusted_Connection=True;MultipleActiveResultSets=true" dbo Cache

4. To work properly the app needs SendGrid key. There are two ways to deal with that:
- You can comment the following line in Startup.cs, but that way you would not be able to send emails:  
  >services.AddTransient<IEmailSender>(x => new SendGridEmailSender(new LoggerFactory(), this.configuration["Sendgrid"])); (line 113)
- For testing email sending you should have your own key for SendGrid and add it in secrets.json 
   (secrets.json file can be found: -> open Solution Explorer -> right click on QuizHut.Web project -> Manage User Secrets).
   Then add object like this:
   > { "Sendgrid": "your api key"}
  

## Credits
  
 Using ASP.NET-MVC-Template originally developed by:
- [Nikolay Kostov](https://github.com/NikolayIT)
- [Vladislav Karamfilov](https://github.com/vladislav-karamfilov)

Using Lazy Kit Bootstrap template : https://demo.themewagon.com/preview/lazy-kit-is-a-free-bootstrap-4-ui-kit-lazy-kits
