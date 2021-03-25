using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineWeb.Dtos
{
    public class WebhookSubscriptionCreateDto
    {

        [Required]
        public string WebhookURI { get; set; }

        [Required]
        public string WebhookType { get; set; }
    }
}
