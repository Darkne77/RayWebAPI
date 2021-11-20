using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RayWebAPI.Models
{
    [Table("Hospice")]
    public class Hospice
    {
        [Column("Hospice_id")]
        public int HospiceId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        [Column("House_num")]
        public string HouseNumber { get; set; }
        public string Metro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Column("E-mail")]
        public string EMail { get; set; }
        public string Mobile { get; set; }
        [Column("Site")]
        public string Website { get; set; }
        [Column("Photo")]
        public string ImageSource { get; set; }
        public string Details { get; set; }
    }
}