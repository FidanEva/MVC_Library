using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Library.Models.Entity;
namespace MVC_Library.Models.Classes
{
    public class Class1
    {
        public IEnumerable<tbl_book> Book { get; set; }
        public IEnumerable<tbl_about> About { get; set; }
    }
}