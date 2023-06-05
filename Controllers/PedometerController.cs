using health_and_fitness_app.Context;
using health_and_fitness_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace health_and_fitness_app.Controllers
{
    public class PedometerController : Controller
    {
        private MyDbContext Context;
        public PedometerController(MyDbContext Pedometer)
        {
            Context = Pedometer;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalories(int steps)
        {
            double totalCaloriesBurned = steps * 0.04;

            // Save the value to the database using a model
            var pedometerEntry = new PedometerEntry
            {
                Steps = steps,
                Date = DateTime.Today,
                CaloriesBurned = totalCaloriesBurned
            };

            // Save the model to the database using Entity Framework or another ORM
            // ...

            return View("StepsToCalories", totalCaloriesBurned);
        }

    }
}
