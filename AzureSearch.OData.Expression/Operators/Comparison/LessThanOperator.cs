using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression.Operators.Comparison
{
    public class LessThanOperator:ComparisonBase,IComparison
    {
        public LessThanOperator():base("lt")
        {

        }
    }
}
