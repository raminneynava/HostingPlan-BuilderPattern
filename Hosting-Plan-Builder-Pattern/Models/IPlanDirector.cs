namespace Hosting_Plan_Builder_Pattern.Models
{
    public interface IPlanDirector
    {
        void SetPlanBuilder(IPlanBuilder builder);

        void BuildBasicPlan();

        void BuildEnterprisePlan();
    }
}
