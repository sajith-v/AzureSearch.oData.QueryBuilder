using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression.Operators.Comparison
{
    public class NotEqualOperator:ComparisonBase,IComparison
    {
        public NotEqualOperator():base("ne")
        {

        }
    }
}
