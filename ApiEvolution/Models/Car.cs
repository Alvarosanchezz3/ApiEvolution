using System.ComponentModel.DataAnnotations;

namespace ApiEvolution.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Model { get; set; }

        public string FuelType { get; set; }

        public int Year { get; set; }

        public string Description { get; set; }
    }
}