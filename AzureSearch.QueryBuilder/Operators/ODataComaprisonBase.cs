namespace AzureSearch.OData.Expression
{
    public abstract class ODataComaprisonBase : ODataOperatorBase, IODataComparison
    {
        public ODataComaprisonBase(string value):base(value)
        {
            this.Value = base.Value;
        }
    }
}
