namespace sales_website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProduit")]
    public partial class UserProduit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUserF { get; set; }

        public int? idProduitF { get; set; }

        public DateTime? date { get; set; }

        public int? quantite { get; set; }

        public virtual Produit Produit { get; set; }

        public virtual User User { get; set; }
    }
}
