using System;
using System.Collections.Generic;
using System.Text;

class QueryBuilder
{
    public StringBuilder sb = new StringBuilder();
    public int index;
    public string table;
    public string condition;
    public string column;


    public QueryBuilder Select(string columns)
    {
        sb.Append(columns);
        return this; 
    }
    public QueryBuilder From(string table)
    {

        return this; 
    }
    public QueryBuilder Where(string condition)
    {
        return this; 
    }
    public QueryBuilder OrderBy(string column)
    {
        return this; 
    }

    public string Build()
    {
        return str;
    }
}
