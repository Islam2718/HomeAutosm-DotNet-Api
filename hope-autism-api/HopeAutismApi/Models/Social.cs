using System.Net.Sockets;

namespace HopeAutismApi.Models
{
    public class Social
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Icon { get; set; }
        public string? Image { get; set; }
        public string? LinkUrl { get; set; }
        public string? Target { get; set; }
        public int Status { get; set; }
    }
}
