namespace AzureSearch.OData.Expression
{
    public class ODataLogicalBase : ODataOperatorBase,IODataLogical
    {
        public ODataLogicalBase(string value):base(value)
        {
            this.Value = base.Value;
        }
    }
}
