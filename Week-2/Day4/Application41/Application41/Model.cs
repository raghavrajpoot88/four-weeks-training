using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;



public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite($"Data Source={DbPath}");
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .HasMany(e => e.Comments)
            .WithOne(e => e.Blog)
            .HasForeignKey(e => e.BlogId)
            .HasPrincipalKey(e => e.Id);
    }

}


public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }

    public List<Comment> Comments { get; } = new();
}

public class Comment
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public int BlogId { get; set; }

    public Blog Blog { get; set; }
}