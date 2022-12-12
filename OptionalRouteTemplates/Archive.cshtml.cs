using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivityTracker.Pages
{
    public class ActivityModel : PageModel
    {
        private int idealSteps = 10000;
        private int idealMinutesExercise = 30;

        public List<Day> Days = new List<Day>
    {
      new Day(3000, 20),
      new Day(6000, 12),
      new Day(10000, 40),
      new Day(7000, 25)
    };
        public int CurrentDay { get; set; }
        public int DisplaySteps { get; set; }
        public int DisplayMinutesExercise { get; set; }
        public double PercentProgressSteps { get; set; }
        public double PercentProgressMinutesExercise { get; set; }
        public bool IsWeeklyDisplay { get; set; }

        public void OnGet(int? day)
        {
            if (day.HasValue)
            {
                CurrentDay = day.Value;
                DisplaySteps = Days[CurrentDay].Steps;
                DisplayMinutesExercise = Days[CurrentDay].MinutesExercise;
                PercentProgressSteps = PercentProgress(DisplaySteps, idealSteps);
                PercentProgressMinutesExercise = PercentProgress(DisplayMinutesExercise, idealMinutesExercise);
            }
            else
            {
                CurrentDay = 0;
                IsWeeklyDisplay = true;
                DisplaySteps = Days.Sum(d => d.Steps);
                DisplayMinutesExercise = Days.Sum(d => d.MinutesExercise);
                PercentProgressSteps = PercentProgress(DisplaySteps, idealSteps * Days.Count);
                PercentProgressMinutesExercise = PercentProgress(DisplayMinutesExercise, idealMinutesExercise * Days.Count);
            }
        }

        private static double PercentProgress(double actual, double expected)
        {
            return Math.Clamp(actual / expected, 0, 1);
        }
    }

    public class Day
    {
        public int Steps { get; set; }
        public int MinutesExercise { get; set; }

        public Day(int steps = 0, int minutes = 0)
        {
            Steps = steps;
            MinutesExercise = minutes;
        }
    }
}