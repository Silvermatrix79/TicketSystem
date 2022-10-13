using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Project
    {

        public int Id { get; set; }

        [DisplayName("Department")]
        public int? DepartmentId { get; set; }

        [DisplayName("Project Name")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        private DateTimeOffset _StartDate;
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset EndDate { get; set; }

        [DisplayName("Priority")]
        public int? ProjectPriorityId { get; set; }

        [DisplayName("Archived")]
        public bool Archived { get; set; }


        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFormFile { get; set; }

        [DisplayName("File Name")]
        public string? ImageFileName { get; set; }

        public byte[]? ImageFileData { get; set; }

        [DisplayName("File Extension")]
        public string? ImageContentType { get; set; }



        //Navigation Properties

        public virtual Department Department { get; set; }
        public virtual ProjectPriority ProjectPriority { get; set; }

        public virtual ICollection<User> Members { get; set; } = new HashSet<User>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

    }
}
