using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgentWeb.Models
{
    public class WebhookSecret
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Secret { get; set; }

        [Required]
        public string Publisher { get; set; }
    }
}
