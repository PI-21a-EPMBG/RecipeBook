using Microsoft.EntityFrameworkCore;
using RecipeBook.Models;

namespace RecipeBook.db;

public partial class RecipesContext : DbContext
{
    public RecipesContext()
    {
        Database.EnsureCreated();
    }

    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cookery> Cookeries { get; set; }
    public virtual DbSet<Dish> Dishes { get; set; }
    public virtual DbSet<DishIngridient> DishIngridients { get; set; }
    public virtual DbSet<DishTag> DishTags { get; set; }
    public virtual DbSet<Favorite> Favorites { get; set; }
    public virtual DbSet<Ingridient> Ingridients { get; set; }
    public virtual DbSet<MeasureUnit> MeasureUnits { get; set; }
    public virtual DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=db\\\\\\\\recipes.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cookery>(entity =>
        {
            entity.ToTable("cookery");

            entity.HasIndex(e => e.Id, "IX_cookery_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.ToTable("dish");

            entity.HasIndex(e => e.Id, "IX_dish_id").IsUnique();

            entity.HasIndex(e => e.Name, "IX_dish_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CookeryId).HasColumnName("cookery_id");
            entity.Property(e => e.CookingTime).HasColumnName("cooking_time");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Recipe).HasColumnName("recipe");

            entity.HasOne(d => d.Cookery).WithMany(p => p.Dishes)
                .HasForeignKey(d => d.CookeryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<DishIngridient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dish_ingridients");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.IngridientId).HasColumnName("ingridient_id");
            entity.Property(e => e.MeasureUnitId).HasColumnName("measure_unit_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Dish).WithMany()
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ingridient).WithMany()
                .HasForeignKey(d => d.IngridientId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.MeasureUnit).WithMany()
                .HasForeignKey(d => d.MeasureUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });
        modelBuilder.Entity<DishTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dish_tag");

            entity.Property(e => e.DishId).HasColumnName("dish_id");
            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.HasOne(d => d.Dish).WithMany()
                .HasForeignKey(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Tag).WithMany()
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("favorites");

            entity.HasIndex(e => e.DishId, "IX_favorites_dish_id").IsUnique();

            entity.Property(e => e.DateAdded).HasColumnName("date_added");
            entity.Property(e => e.DishId).HasColumnName("dish_id");

            entity.HasOne(d => d.Dish).WithOne()
                .HasForeignKey<Favorite>(d => d.DishId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Ingridient>(entity =>
        {
            entity.ToTable("ingridient");

            entity.HasIndex(e => e.Id, "IX_ingridient_id").IsUnique();

            entity.HasIndex(e => e.Name, "IX_ingridient_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MeasureUnit>(entity =>
        {
            entity.ToTable("measure_unit");

            entity.HasIndex(e => e.Id, "IX_measure_unit_id").IsUnique();

            entity.HasIndex(e => e.Name, "IX_measure_unit_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("tags");

            entity.HasIndex(e => e.Id, "IX_tags_id").IsUnique();

            entity.HasIndex(e => e.Name, "IX_tags_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
