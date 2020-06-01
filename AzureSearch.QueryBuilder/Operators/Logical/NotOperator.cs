using System;
using System.Collections.Generic;
using System.Text;

namespace AzureSearch.OData.Expression
{
    public class NotOperator: LogicalBase,ILogical
    {
        public NotOperator():base("not")
        {
            Value = base.Value;
        }
    }
}
