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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_LIBRARYEntities : DbContext
    {
        public DB_LIBRARYEntities()
            : base("name=DB_LIBRARYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_action> tbl_action { get; set; }
        public virtual DbSet<tbl_book> tbl_book { get; set; }
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_employers> tbl_employers { get; set; }
        public virtual DbSet<tbl_fines> tbl_fines { get; set; }
        public virtual DbSet<tbl_safe> tbl_safe { get; set; }
        public virtual DbSet<tbl_users> tbl_users { get; set; }
        public virtual DbSet<tbl_writer> tbl_writer { get; set; }
        public virtual DbSet<tbl_about> tbl_about { get; set; }
        public virtual DbSet<tbl_contact> tbl_contact { get; set; }
    }
}
