using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Mapeo
/// </summary>
public class Mapeo : DbContext
{
    static Mapeo()
    {
        Database.SetInitializer<Mapeo>(null);
    }
    private readonly string schema;

    //nombre de conexion
    public Mapeo() : base("name= postgres2")
    {

    }
    //apunto al encapsulado
    public DbSet<EDatos> usuario { get; set; }
    public DbSet<EVideo> video { get; set; }

    //public DbSet<EVideo>videos { get; set; }

    protected override void OnModelCreating(DbModelBuilder builder)
    {

        builder.HasDefaultSchema(this.schema);

        base.OnModelCreating(builder);
    }
}