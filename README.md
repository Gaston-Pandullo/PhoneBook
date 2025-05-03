Phone Book
Introduction

In the .NET ecosystem you’ll come across ORMs (Object-Relational Mappers), which helps you to deal with databases using objects. If you have searched for C# tutorials you’ve probably encountered technologies such as Dapper and Entity Framework. You’ll definitely be using one when you start working as a developer.

In this tutorial we’ll implement a very simple Phone Book so you can learn the basics of Entity Framework, the most popular ORM. Even though we at The C# Academy strongly believe C# students should learn raw SQL first and foremost, most .NET C# job applications demand Entity Framework. The good news is that EF’s basic operations are very simple to learn and you’ll be up and running very quickly. Let’s go!

Requirements

    This is an application where you should record contacts with their phone numbers.

    Users should be able to Add, Delete, Update and Read from a database, using the console.

    You need to use Entity Framework, raw SQL isn't allowed.

    Your code should contain a base Contact class with AT LEAST {Id INT, Name STRING, Email STRING and Phone Number(STRING)}

    You should validate e-mails and phone numbers and let the user know what formats are expected

    You should use Code-First Approach, which means EF will create the database schema for you.

    You should use SQL Server, not SQLite.
    Resources

Here are a few resources that might be helpful.

    Entity Framework Docs
    CRUD Console APP with EF on Youtube

There are many other Youtube videos and blog articles about Entity Framework everything else you need. Don’t be ashamed to use Google!
Tips

    Before starting the phone book app, finish the program in the Microsoft Documentation article without any changes and store in your Github repository for reference. Make sure you understand most of the code before you get started.

    Don't forget to create a Github repository for your project from the beginning.

Challenges

    Create a functionality that allows users to add the contact's e-mail address and send an e-mail message from the app.

    Expand the app by creating categories of contacts (i.e. Family, Friends, Work, etc).

    What if you want to send not only e-mails but SMS?

Review Repository

https://github.com/TheCSharpAcademy/CodeReviews.Console.Phonebook
