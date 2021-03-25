using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineWeb.Dtos
{
    public class WebhookSubscriptionReadDto
    {
        public int Id { get; set; }

        public string WebhookURI { get; set; }

        public string Secret { get; set; }

        public string WebhookType { get; set; }

        public string WebhhokPublisher { get; set; }
    }
}
