using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public Nullable<Decimal> Price { get; set; }
    }
}