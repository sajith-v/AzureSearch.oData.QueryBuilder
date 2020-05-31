namespace AzureSearch.OData.Expression
{
    public abstract class ODataOperatorBase : IODataOperator
    {
        public string Value { get; set; }
        public ODataOperatorBase(string value)
        {
            Value = value;
        }
    }
}
