using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Actividad3_DACS.Models
{
    public class Sale
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int SaleId{ get; set;}

       [Required]
       public string ProductName{ get; set;}

       [Required]
       public double Amount{get; set;}

       [Required]
       public virtual CollectionExtensions Client{get;set;} 
    }
}