using System.ComponentModel.DataAnnotations;

namespace RV_RPGServer.Entities
{
    public class Character
    {
        [Required]
        public required int Id { get; set; }
        [Required]
        public required string Name { get; set; }
    }
}