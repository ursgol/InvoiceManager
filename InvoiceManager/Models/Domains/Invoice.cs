using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InvoiceManager.Models.Domains
{
    public class Invoice
    {
        public Invoice()
        {
            InvoicePositions = new Collection<InvoicePosition>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "The field Title is required.")]
        public string Title { get; set; }
        public decimal Value { get; set; }

        [Display(Name = "Method of payment")]
        [Required(ErrorMessage = "The Field Method of Payment Id is required.")]
        public int MethodOfPaymentId { get; set; }
        [Display(Name = "Payment date")]

        public DateTime PaymentDate { get; set; }
        [Display(Name = "Created date")]

        public DateTime CreatedDate { get; set; }
        public string Comments { get; set; }
       
        
        [Display(Name = "Client")] 
        public int ClientId { get; set; }


        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public MethodOfPayment MethodOfPayment { get; set; }
       
        public Client Client { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<InvoicePosition> InvoicePositions { get; set; }

    }
}