using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvoiceManager.Models.Domains
{
    public class InvoicePosition
    {
        public int Id { get; set; }
        public int Nr { get; set; }
        [Display(Name = "Invoice")]

        public int InvoiceId { get; set; }
        public decimal Value { get; set; }
        [Display(Name = "Product")]
        [Required(ErrorMessage = "The Field Product is required.")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }




        public Invoice Invoice { get; set; }
        public Product Product { get; set; }



    }
}