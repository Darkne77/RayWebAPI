using System.ComponentModel.DataAnnotations;

namespace RayWebAPI.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        
        //TODO
        //[Timestamp]
        //public byte[] Timestamp { get; set; }
    }
}