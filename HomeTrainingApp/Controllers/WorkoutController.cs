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
            pushWorkout.Exercises.Add(new Exercise { Name = "Elevated pushups", Sets = 3, Reps = 10, RestTime = 120, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            pushWorkout.Exercises.Add(new Exercise { Name = "Tricep dips", Sets = 3, Reps = 12, RestTime = 120, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            return View(pushWorkout);
        }

        public IActionResult PullWorkout()
        {
            // Todo: Hämta övningar från databas istället
            var pullWorkout = new Workout();
            pullWorkout.Exercises.Add(new Exercise { Name = "Pistol squat", Sets = 3, Reps = 12, RestTime = 120, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            pullWorkout.Exercises.Add(new Exercise { Name = "Kettlebell row", Sets = 3, Reps = 12,  RestTime = 120, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            pullWorkout.Exercises.Add(new Exercise { Name = "Close-grip kettlebell curl", Sets = 3, Reps = 12, RestTime = 15, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });

            return View(pullWorkout);
        }
    }
}