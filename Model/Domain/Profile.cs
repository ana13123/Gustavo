using System;

namespace Model.Domain
{
    public class Profile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string PhotoProfile { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
