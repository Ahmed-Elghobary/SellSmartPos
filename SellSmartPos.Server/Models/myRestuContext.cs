using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SellSmartPos.Server.Models
{
    public partial class myRestuContext : DbContext
    {
        public myRestuContext()
        {
        }

        public myRestuContext(DbContextOptions<myRestuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<SalelsBilDetail> SalelsBilDetails { get; set; } = null!;
        public virtual DbSet<SellsBill> SellsBills { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-GNA35PN;database=myRestu;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutU>(entity =>
            {
                entity.Property(e => e.Fb).HasColumnName("fb");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Insta).HasColumnName("insta");

                entity.Property(e => e.JopTitle).HasMaxLength(50);

                entity.Property(e => e.Linkedin).HasColumnName("linkedin");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Twitter).HasColumnName("twitter");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductImages_Product");
            });

            modelBuilder.Entity<SalelsBilDetail>(entity =>
            {
                entity.ToTable("SalelsBilDetail");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.SalesBil)
                    .WithMany(p => p.SalelsBilDetails)
                    .HasForeignKey(d => d.SalesBilId)
                    .HasConstraintName("FK_SalelsBilDetail_SellsBill");
            });

            modelBuilder.Entity<SellsBill>(entity =>
            {
                entity.ToTable("SellsBill");

                entity.Property(e => e.Cash).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SellsBills)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SellsBill_Customers");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.CssClass).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
