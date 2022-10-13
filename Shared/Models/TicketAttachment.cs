using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Extensions;

namespace Shared.Models
{
    public class TicketAttachment
    {
        public int Id { get; set; }

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [DisplayName("File Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Team Member")]
        public string? UserId { get; set; }

        [DisplayName("File Description")]
        public string Description { get; set; }


        [NotMapped]
        [DisplayName("Select a file")]
        [DataType(DataType.Upload)]
        [MaxFileSize(1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".ppt", ".png", ".html", ".zip", ".doc", ".docx", ".xls", ".xlsx", ".pdf" })]
        public IFormFile ImageFormFile { get; set; }

        [DisplayName("File Name")]
        public string? ImageFileName { get; set; }

        public byte[]? ImageFileData { get; set; }

        [DisplayName("File Extension")]
        public string? ImageFileContentType { get; set; }



        //Navigation Properties  Nameconvention is important User => UserId   Ticket => TicketId
        public virtual Ticket? Ticket { get; set; }

        public virtual User? User { get; set; }

    }
}
