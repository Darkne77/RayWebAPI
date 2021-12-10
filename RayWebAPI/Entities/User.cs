using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RayWebAPI.Entities
{
    [Table("User")]
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Mobile { get; set; }
        public DateTime RegDate { get; set; }
        public int Rank { get; set; }
        [NotMapped]
        public string ImageSource { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}