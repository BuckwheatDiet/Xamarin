using System;
using Java.Sql;

namespace MealPlanner.Models
{
    public class Schedule
    {
        public Date MealDate { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string HowToCook { get; set; }
    }

    public class ScheduleLine
    {
        public Date MealDate { get; set; }
        public string MealType { get; set; }
        public long MealId { get; set; }
    }
}
