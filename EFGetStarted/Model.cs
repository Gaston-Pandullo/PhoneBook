using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

public class BloggingContext : DbContext
{
    DbSet<Blog> Blog { get; set; }
    DbSet<Post> Post { get; set; }
    public string DbPath { get; }
    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    // Configuracion de EF para crear un archivo de base de datos Sqlite
    // En la "carpeta especial" de la plataforma.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Blog
{
    public int BlogId { get; set; }
    public string BlogUrl { get; set; }
    public List<Post> ListPosts { get; } = new();
}
public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}