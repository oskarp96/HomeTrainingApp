using HomeTrainingApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTrainingApp.Data
{
    public class TrainingContext : IdentityDbContext
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options)
        {

        }
    }

}
