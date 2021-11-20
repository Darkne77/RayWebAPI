using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RayWebAPI.Models
{
    public class Donat : EntityBase
    {
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int HospiceId { get; set; }
        [ForeignKey(nameof(HospiceId))]
        public Hospice Hospice { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}