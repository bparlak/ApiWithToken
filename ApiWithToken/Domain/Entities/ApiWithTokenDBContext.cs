using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiWithToken.Domain
{
    //ApiWithTokenDBContext veritabanına denk gelen sınıfımız.
    public partial class ApiWithTokenDBContext : DbContext
    {
        public ApiWithTokenDBContext()
        {
        }

        public ApiWithTokenDBContext(DbContextOptions<ApiWithTokenDBContext> options)
            : base(options)
        {
        }

        //Database üzerinde tablolara karşılık gelen sınıflarımız.
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Data Source=PARLAK-PC;Initial Catalog=ApiWithTokenDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //}
        }

        //Database tablolarının nasıl oluşacağının ayarları yapılıyor. Veritabanında bu tabloların olup olmadığını her uygulama çalıştığında kontrol eder olmayan tabloları method içerisinde belirlediğimiz kurallara göre oluşturur. Tekrar tekrar kontrol edilmesini istemediğimiz için yorum satırı haline getirdik.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(e => e.Category).HasMaxLength(50);

            //    entity.Property(e => e.Name).HasMaxLength(50);

            //    entity.Property(e => e.Price).HasColumnType("money");
            //});

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.Property(e => e.Email).HasMaxLength(100);

            //    entity.Property(e => e.Name).HasMaxLength(50);

            //    entity.Property(e => e.Password).HasMaxLength(100);

            //    entity.Property(e => e.RefreshToken).HasMaxLength(500);

            //    entity.Property(e => e.RefreshTokenDate).HasColumnType("datetime");

            //    entity.Property(e => e.Surname).HasMaxLength(50);
            //});
        }
    }
}
