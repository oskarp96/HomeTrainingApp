using HomeTrainingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrainingApp.Data
{
    public class TrainingContext : DbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        {

        }
    }

}
