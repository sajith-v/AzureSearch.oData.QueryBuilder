namespace AzureSearch.OData.Expression
{
    public sealed class ODataOperation : IODataOperation
    {
        public string Expression { get; set; }
        /// <summary>
        /// Creates a new instance of an operation with operand, operator, and value
        /// </summary>
        /// <param name="operand">Operand in string format, eg: for a=5 , a is the operand </param>
        /// <param name="comparison">Operator can be equal, not equal. ie, anything inherits from IODataComparison</param>
        /// <param name="value">Value of the operation, eg: for a=5, 5 is the value. if the value is a string pass this in a single quote.</param>
        public ODataOperation(string operand, IComparison comparison, string value)
        {
            Expression = $"{operand} {comparison.Value} {value}";
        }
    }
}
