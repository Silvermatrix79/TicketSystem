using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Notification
    {

        public int Id { get; set; }

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [DisplayName("Title")]
        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Message")]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }


        [DisplayName("Recipient")]
        [Required]
        public string RecipientId { get; set; }

        [DisplayName("Sender")]
        [Required]
        public string SenderId { get; set; }

        [DisplayName("Has been viewed")]
        public bool Viewed { get; set; }


        // Navigation Properties
        public virtual Ticket Ticket { get; set; }

        public virtual User Recipient { get; set; }

        public virtual User Sender { get; set; }

    }
}
