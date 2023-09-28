using System.ComponentModel.DataAnnotations;

namespace DotNetMachineTest.Models
{
    public class ConversionRate
    {
        [Key]
        public int Id { get; set; }

        public int FromUnitId { get; set; }

        public int ToUnitId { get; set; }

        public double Rate { get; set; }
    }
}
