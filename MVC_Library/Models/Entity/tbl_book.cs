//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Library.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_book()
        {
            this.tbl_action = new HashSet<tbl_action>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<byte> category { get; set; }
        public Nullable<int> writer { get; set; }
        public string publication_year { get; set; }
        public string publisher { get; set; }
        public string page { get; set; }
        public Nullable<bool> book_status { get; set; }
        public string img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_action> tbl_action { get; set; }
        public virtual tbl_category tbl_category { get; set; }
        public virtual tbl_writer tbl_writer { get; set; }
    }
}