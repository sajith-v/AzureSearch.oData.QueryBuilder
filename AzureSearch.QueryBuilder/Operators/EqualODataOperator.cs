namespace AzureSearch.OData.Expression
{
    public sealed class EqualODataOperator : ODataComaprisonBase, IODataComparison
    {
        public EqualODataOperator():base("eq")
        {
            this.Value = base.Value;
        }
    }
}
