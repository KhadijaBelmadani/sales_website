namespace sales_website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commande")]
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            Users = new HashSet<User>();
            CommandeProduits = new HashSet<CommandeProduit>();
        }

        [Key]
        public int IdCommande { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string etatCommande { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommandeProduit> CommandeProduits { get; set; }
    }
}
