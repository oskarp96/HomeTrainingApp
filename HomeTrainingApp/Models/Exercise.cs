using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrainingApp.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int RestTime { get; set; }
        public string Description { get; set; }
    }
}
