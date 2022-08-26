//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Optique.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vente()
        {
            this.Facture = new HashSet<Facture>();
        }
    
        public int num_vente { get; set; }
        public Nullable<System.DateTime> Date_Vente { get; set; }
        public Nullable<int> Prix { get; set; }
        public string Avence { get; set; }
        public string Reste { get; set; }
        public string Mode_Paiment { get; set; }
        public string Commentaire { get; set; }
        public Nullable<int> num_client { get; set; }
        public Nullable<int> num_produit { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture> Facture { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
