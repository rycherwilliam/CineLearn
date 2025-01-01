
namespace Domain.Entities.SubscriptionPlans
{
    public class PremiumPlan : SubscriptionPlan
    {
        public PremiumPlan(): base(Enums.SubscriptionPlanType.Premium, 4, Enums.Resolution.UHD4K, 49.99m, true) { }
        
    }
}
