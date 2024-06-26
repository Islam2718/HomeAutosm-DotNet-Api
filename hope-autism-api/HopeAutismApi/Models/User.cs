using System.Net.Sockets;

namespace HopeAutismApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public required string Phone { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NidNo { get; set; }
        public string? BirthDate { get; set; }
        public string? BloodGroup { get; set; }
        public string? FathersName { get; set; }
        public string? FathersPhone { get; set; }
        public string? MothersName { get; set; }
        public string? MothersPhone { get; set; }
        public string? PresentAddress { get; set; }
        public string? ParmanentAddress { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? Password { get; set; }
        public required string Role { get; set; }
    }
}
