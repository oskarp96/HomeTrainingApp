using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrainingApp.Models
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }
    }
}
