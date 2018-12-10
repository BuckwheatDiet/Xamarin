using System;

namespace MealPlanner.Models
{
    public class Meal
    {
		public long MealId { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string HowToCook { get; set; }
        public string MealType { get; set; }
    }

    public class MealLine
    {
        public long ItemId { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
    }
}
