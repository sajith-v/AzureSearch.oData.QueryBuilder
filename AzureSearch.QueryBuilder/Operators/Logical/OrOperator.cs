using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression
{
    public class OrOperator : LogicalBase,ILogical
    {
        public OrOperator():base("or")
        {
            Value = base.Value;
        }
    }
}
