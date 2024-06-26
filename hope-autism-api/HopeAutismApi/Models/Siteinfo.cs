using System.Net.Sockets;

namespace HopeAutismApi.Models
{
    public class Siteinfo
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        public string? Icon { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? WebUrl { get; set; }
        public string? MapHtml { get; set; }
        public string? Copyright { get; set; }
    }
}
