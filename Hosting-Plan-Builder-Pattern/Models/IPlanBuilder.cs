namespace Hosting_Plan_Builder_Pattern.Models
{
    public interface IPlanBuilder
    {
        void BuildDiskSpaceFeature();
        void BuildDatabaseFeature();
        void BuildBandwidthFeature();
        void BuildSslFeature();

        Plan GetPlan();
    }
}
