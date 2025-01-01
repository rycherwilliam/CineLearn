using Domain.Enums;

namespace Domain.Entities.SubscriptionPlans
{
    public abstract class SubscriptionPlan
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public SubscriptionPlanType Name { get; protected set; }
        public int MaxScreens { get; protected set; }
        public Resolution Resolution { get; protected set; }
        public decimal MonthlyPrice { get; protected set; }
        public bool HasFullCatalogAccess { get; protected set; }

        protected SubscriptionPlan(SubscriptionPlanType name, int maxScreens, Resolution resolution, decimal monthlyPrice, bool hasFullCatalogAccess) {
            Name = name;
            MaxScreens = maxScreens;
            Resolution = resolution;
            MonthlyPrice = monthlyPrice;
            HasFullCatalogAccess = hasFullCatalogAccess;
        }

        public virtual string GetPlanDetails()
        {
            return $"Plan: {Name}, Avaible Screens: {MaxScreens}, Avaible Resolution: {Resolution}, Full Catalog Access: {HasFullCatalogAccess}";
        }

    }
}
