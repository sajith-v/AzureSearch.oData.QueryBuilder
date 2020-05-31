# AzureSearch.oData.QueryBuilder
A Helper library to create filter query for Microsoft Azure Cognitive search service

#Usage

string filter = new ODataFilterExpression(new ODataOperation("FieldName", new EqualODataOperator(), value)).FilterExpression

or

string filter = new ODataFilterExpression(new ODataOperation("FieldName", new EqualODataOperator(), $"{'value'}")).FilterExpression
