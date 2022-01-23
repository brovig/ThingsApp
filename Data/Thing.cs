using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThingsStorage.Data
{
    public class Thing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, 50, ErrorMessage = "Quantity should be in range 0-50")]
        public int Quantity { get; set; }
    }
}