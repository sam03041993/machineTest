using System.ComponentModel.DataAnnotations;

namespace DotNetMachineTest.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}