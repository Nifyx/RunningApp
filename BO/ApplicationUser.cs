//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApplicationUser()
        {
            this.Registration = new HashSet<Registration>();
        }
    
        public int ID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> RoleUserID { get; set; }
    
        public virtual RoleUser RoleUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registration { get; set; }
    }
}
