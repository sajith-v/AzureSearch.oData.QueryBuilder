namespace AzureSearch.OData.Expression
{
    public class LogicalBase : OperatorBase,ILogical
    {
        public LogicalBase(string value):base(value)
        {
            this.Value = base.Value;
        }
    }
}
