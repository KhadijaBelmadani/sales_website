namespace sales_website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produit")]
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            UserProduits = new HashSet<UserProduit>();
            CommandeProduits = new HashSet<CommandeProduit>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProduit { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public decimal? prix { get; set; }

        public int? pourcentageSolde { get; set; }

        public int? quantite { get; set; }

        [StringLength(100)]
        public string valeursSpecifiques { get; set; }

        public int? idCategorieF { get; set; }

        public virtual Categorie Categorie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProduit> UserProduits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommandeProduit> CommandeProduits { get; set; }
    }
}
