using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace health_and_fitness_app.Models
{
    public class PedometerEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Steps { get; set; }

        public DateTime Date { get; set; }

        public double CaloriesBurned { get; set; }
    }
}
