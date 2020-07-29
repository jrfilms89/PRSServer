using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PRSServer.Models {
    public class Requestline {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }

        
        [JsonIgnore]
        public virtual Request Request { get; set; }
        [Required]
        public int RequestId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }

        public Requestline() { }
    }
}
