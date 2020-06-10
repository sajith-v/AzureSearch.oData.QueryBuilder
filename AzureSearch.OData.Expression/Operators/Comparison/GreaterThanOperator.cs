using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression
{
    public class GreaterThanOperator:ComparisonBase,IComparison
    {
        public GreaterThanOperator():base("gt")
        {
            
        }
    }
}
