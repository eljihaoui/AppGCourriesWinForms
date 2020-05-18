//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppGCourries.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arrivee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arrivee()
        {
            this.ArriveeDocs = new HashSet<ArriveeDocs>();
        }
    
        public int idArrivee { get; set; }
        public int idCateg { get; set; }
        public int idUser { get; set; }
        public int idEntite { get; set; }
        public int Annee { get; set; }
        public int NumOrdre { get; set; }
        public System.DateTime DateOrdre { get; set; }
        public string NumCourrier { get; set; }
        public Nullable<System.DateTime> DateCourrier { get; set; }
        public string Sujet { get; set; }
        public string Remarques { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual Entites Entites { get; set; }
        public virtual TUsers TUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArriveeDocs> ArriveeDocs { get; set; }
    }
}
