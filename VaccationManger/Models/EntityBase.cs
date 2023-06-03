using System.ComponentModel.DataAnnotations;

namespace VaccationManger.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
