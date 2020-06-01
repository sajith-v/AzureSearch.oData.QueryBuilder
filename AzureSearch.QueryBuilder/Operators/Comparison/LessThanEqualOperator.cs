using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression.Operators.Comparison
{
    public class LessThanEqualOperator:ComparisonBase,IComparison
    {
        public LessThanEqualOperator():base("le")
        {

        }
    }
}
