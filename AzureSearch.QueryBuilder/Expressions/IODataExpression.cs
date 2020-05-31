namespace AzureSearch.OData.Expression
{
    public interface IODataExpression
    {
        string FilterExpression { get; set; }
        IODataExpression Add(IODataLogical logicalOperator, IODataOperation operation);
    }
}
