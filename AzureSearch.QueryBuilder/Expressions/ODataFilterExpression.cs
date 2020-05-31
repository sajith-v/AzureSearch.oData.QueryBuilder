namespace AzureSearch.OData.Expression
{
    public sealed class ODataFilterExpression : IODataExpression
    {
        public ODataFilterExpression(IODataOperation operation)
        {
            FilterExpression = operation.Expression;
        }

        public string FilterExpression { get; set; }


        public IODataExpression Add(IODataLogical logicalOperator, IODataOperation operation)
        {
            FilterExpression = $"{FilterExpression} {logicalOperator.Value} {operation.Expression}";
            return this;
        }
    }
}
