
using Domain.Enums;

namespace Domain.Entities.SubscriptionPlans
{
    public class BasicPlan : SubscriptionPlan
    {
        public BasicPlan() : base(SubscriptionPlanType.Basic,1,Resolution.SD,19.99m,false) { }

        public override string GetPlanDetails()
        {
            return $"Plan: {Name}, Avaible Screens: {MaxScreens}, Avaible Resolution: {Resolution}, Full Catalog Access: {HasFullCatalogAccess}";
        }

    }
}
