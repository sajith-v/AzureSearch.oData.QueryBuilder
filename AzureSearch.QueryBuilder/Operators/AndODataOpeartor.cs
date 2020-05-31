namespace AzureSearch.OData.Expression
{
    public sealed class AndODataOpeartor:ODataLogicalBase,IODataLogical
    {
        public AndODataOpeartor() : base("and")
        {
            this.Value = base.Value;
        }
    }
}
