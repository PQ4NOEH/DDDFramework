using DDD.Framework.Core.CQS;
using System;

namespace Bgg.FamilyMenu.Contracts.Commands.MenuPlanification
{
    public class DishPayload
    {
        public DateYear Year { get; set; }
        public WeekOfYear Week { get; set; }
        public DayOfWeek Day { get; set; }
        public Meal Meal { get; set; }
        public string RecipeRef { get; set; }
    }

    public class SetStarter: BaseCommand<DishPayload> { }
    public class SetMainCourse : BaseCommand<DishPayload> { }
    public class SetDessert : BaseCommand<DishPayload> { }

    public class CleanMealPayload
    {
        public DateYear Year { get; set; }
        public WeekOfYear Week { get; set; }
        public DayOfWeek Day { get; set; }
        public Meal Meal { get; set; }
    }
    public class CleanMeal : BaseCommand<CleanMealPayload> { }

    public class CleanDayPayload
    {
        public DateYear Year { get; set; }
        public WeekOfYear Week { get; set; }
        public DayOfWeek Day { get; set; }
    }
    public class CleanDay : BaseCommand<CleanDayPayload> { }

    public class CleanWeekPayload
    {
        public DateYear Year { get; set; }
        public WeekOfYear Week { get; set; }
    }
    public class CleanWeek : BaseCommand<CleanWeekPayload> { }
}
