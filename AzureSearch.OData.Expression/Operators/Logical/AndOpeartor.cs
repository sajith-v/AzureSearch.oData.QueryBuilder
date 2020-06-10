namespace AzureSearch.OData.Expression
{
    public sealed class AndOpeartor:LogicalBase,ILogical
    {
        public AndOpeartor() : base("and")
        {
            this.Value = base.Value;
        }
    }
}
