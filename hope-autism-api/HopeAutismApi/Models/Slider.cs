using System.Net.Sockets;

namespace HopeAutismApi.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public required string thumb { get; set; }
        public string? LinkUrl { get; set; }
        public int Status { get; set; }
    }
}