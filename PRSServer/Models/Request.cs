using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSServer.Models {
    public class Request {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Description { get; set; }
        [Required]
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [Required]
        [StringLength(30)]
        public string DeliveryMode { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Total { get; set; }

        public virtual User User { get; set; }
        [Required]
        public int UserId { get; set; }

        public virtual IEnumerable<Requestline> Requestlines { get; set; }
        public Request() { }
    }
}
