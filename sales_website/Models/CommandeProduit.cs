namespace sales_website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommandeProduit")]
    public partial class CommandeProduit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCommandeF { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProduitF { get; set; }

        public int? quantite { get; set; }

        public virtual Commande Commande { get; set; }

        public virtual Produit Produit { get; set; }
    }
}
