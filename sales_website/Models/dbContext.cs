using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace sales_website.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CommandeProduit> CommandeProduits { get; set; }
        public virtual DbSet<UserProduit> UserProduits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Categorie>()
                .Property(e => e.attributsSpecifiques)
                .IsUnicode(false);

            modelBuilder.Entity<Categorie>()
                .HasMany(e => e.Produits)
                .WithOptional(e => e.Categorie)
                .HasForeignKey(e => e.idCategorieF);

            modelBuilder.Entity<Commande>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Commande>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Commande>()
                .Property(e => e.etatCommande)
                .IsUnicode(false);

            modelBuilder.Entity<Commande>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Commande)
                .HasForeignKey(e => e.idCommandeF);

            modelBuilder.Entity<Commande>()
                .HasMany(e => e.CommandeProduits)
                .WithRequired(e => e.Commande)
                .HasForeignKey(e => e.idCommandeF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produit>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Produit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Produit>()
                .Property(e => e.prix)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Produit>()
                .Property(e => e.valeursSpecifiques)
                .IsUnicode(false);

            modelBuilder.Entity<Produit>()
                .HasMany(e => e.UserProduits)
                .WithOptional(e => e.Produit)
                .HasForeignKey(e => e.idProduitF);

            modelBuilder.Entity<Produit>()
                .HasMany(e => e.CommandeProduits)
                .WithRequired(e => e.Produit)
                .HasForeignKey(e => e.idProduitF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nomComplet)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.specialite)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.tel)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserProduit)
                .WithRequired(e => e.User);
        }
    }
}
