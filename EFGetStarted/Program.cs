using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

// Context
using var db = new BloggingContext();

// Antes de que se ejecute esta linea hay que asegurarse que
// ya esté creada la base de datos.
Console.WriteLine($"Database path: {db.DbPath}");

// Create
Console.WriteLine("Insertign a new blog");
db.Add(new Blog { BlogUrl = "http://blogs.msdn.com/adonet" });
await db.SaveChangesAsync();

//Read
Console.WriteLine("Query for a blog");
var blog = await db.Blog.OrderBy(b => b.BlogId).FirstAsync();

//Update
Console.WriteLine("Updating the blog and adding the post");
blog.BlogUrl = "https://devblogs.microsoft.com/dotnet";
blog.Posts.Add(new Post { Title = "Hello world!", Content = "I wrote an app using EF Core!" });
await db.SaveChangesAsync();

//Delete 
Console.WriteLine("Delete the blog");
db.Remove(blog);
await db.SaveChangesAsync();