namespace AzureSearch.OData.Expression
{
    public abstract class OperatorBase : IOperator
    {
        public string Value { get; set; }
        public OperatorBase(string value)
        {
            Value = value;
        }
    }
}
