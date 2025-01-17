### Day 1 We will cover Controllers and Routes (Endpoints)

We are going to create a Controller with the following routes
1. Retrieves a list of students. [HttpGet]
2. Add a student to the list. [HttpPost]
3. Remove a student from the list. [HttpDelete]
4. Edit a student in our list. [HttpPut]

We gave our Endpoints (Routes) specific paths using /{parameter} for user interaction
Did Psudo CRUD Functions which is Create (Post), Read (Get), Update (Put), Delete (Delete).

dotnet new gitignore.

### Day 2 We will cover services and Dependancy injections


We are going to create a services file that houses our logic and then we will inject that class into our controller.

1. Created a Services folder and file
2. Transfered Function / Logic Over to our Services (Typically we would do our services first)
3. We had to add our Services into our progrom.cs in order to provide our services throughout our file. 
4. We injected the data into our controller via "Dependancy Injection"
5. We were able to use and access our methods from our object(_studentListServices).

### Day 3 Today we are Covering Models and Built in C# Methods (Find & FindIndex)

- What is a model

A model is a Representation of Data that we will use throughout our app aka a blueprint for objects.

Eventually When we get into databases our models will represent the data we will be sending and retreiving from our DB.

### Day 4 We will be Creating A Database with Azure and Connecting to it VIA EFCore

What is EF Core?

Entity Framework Core: It allows our application to interact with our database without using any SQL commands

1. Set up our Database using Azure
2. Configuring our database connection in our Appsetting.json
3. Installing EFCore Packages and SQL Server Packages
4. We will be making a class called DataContext which will act as a bridge from our C# to our Database Tables
5. Register our database within our app (program.cs)
6. we will be changing our logic for our services to account for our Database