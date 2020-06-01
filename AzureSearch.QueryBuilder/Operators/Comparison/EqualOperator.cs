namespace AzureSearch.OData.Expression
{
    public sealed class EqualOperator : ComparisonBase, IComparison
    {
        public EqualOperator():base("eq")
        {
            this.Value = base.Value;
        }
    }
}
