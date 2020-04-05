using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeTrainingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeTrainingApp.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult PushWorkout()
        {
            // Todo: Hämta övningar från databas istället
            var pushWorkout = new Workout();
            pushWorkout.Exercises.Add(new Exercise { Name = "One-armed pushups", Sets = 3, Reps = 8, RestTime = 120, Description = "Start the exercise in a normal push-up position, then place one hand on your lower back. Start descending down to the floor by bending your elbow. when your nose almost touches the floor, begin ascending by extending the elbow and push yourself off the ground." });
            pushWorkout.Exercises.Add(new Exercise { Name = "Elevated pushups", Sets = 3, Reps = 10, RestTime = 120 });
            pushWorkout.Exercises.Add(new Exercise { Name = "Tricep dips", Sets = 3, Reps = 12, RestTime = 120 });
            return View(pushWorkout);
        }

        public IActionResult PullWorkout()
        {
            // Todo: Hämta övningar från databas istället
            var pullWorkout = new Workout();
            pullWorkout.Exercises.Add(new Exercise { Name = "Pistol squat", Sets = 3, Reps = 12, RestTime = 120 });
            pullWorkout.Exercises.Add(new Exercise { Name = "Kettlebell row", Sets = 3, Reps = 12,  RestTime = 120 });
            pullWorkout.Exercises.Add(new Exercise { Name = "Close-grip kettlebell curl", Sets = 3, Reps = 12, RestTime = 15 });

            return View(pullWorkout);
        }
    }
}