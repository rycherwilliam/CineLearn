
namespace Domain.Entities.SubscriptionPlans
{
    public class StandardPlan : SubscriptionPlan
    {
        public StandardPlan(): base(Enums.SubscriptionPlanType.Standard, 2, Enums.Resolution.HD, 29.99m, true) { }
    }
}
