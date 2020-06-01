namespace AzureSearch.OData.Expression
{
    public abstract class ComparisonBase : OperatorBase, IComparison
    {
        public ComparisonBase(string value):base(value)
        {
            this.Value = base.Value;
        }
    }
}
