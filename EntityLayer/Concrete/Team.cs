using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string PersonName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string FacebookUrl { get; set; } = string.Empty;
        public string InstagramUrl { get; set; } = string.Empty;
        public string XUrl { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
    }
}
