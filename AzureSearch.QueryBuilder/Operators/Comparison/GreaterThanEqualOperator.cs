using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression.Operators.Comparison
{
    public class GreaterThanEqualOperator:ComparisonBase,IComparison
    {
        public GreaterThanEqualOperator():base("ge")
        {

        }
    }
}
