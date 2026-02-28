using System;
using System.Collections.Generic;
using System.Text;

public class QueryBuilder
{
    private string _select;
    private string _from;
    private string _where;
    private string _orderBy;

    public QueryBuilder()
    {
        Select();
        From();
    }

    // SELECT 절 추가
    public QueryBuilder Select(string columns = "*")
    {
        _select = $"SELECT {columns}";
        return this;
    }

    // FROM 절 추가
    public QueryBuilder From(string table = "Users")
    {
        _from = $"FROM {table}";
        return this;
    }

    // WHERE 절 추가
    public QueryBuilder Where(string condition)
    {
        _where = $"WHERE {condition}";
        return this;
    }

    // ORDER BY 절 추가
    public QueryBuilder OrderBy(string column)
    {
        _orderBy = $"ORDER BY {column}";
        return this;
    }

    // 최종 쿼리 문자열 조립
    public string Build()
    {
        StringBuilder query = new StringBuilder();
        query.Append(_select).Append(" ");
        query.Append(_from);

        if (!string.IsNullOrEmpty(_where))
            query.Append(" ").Append(_where);

        if (!string.IsNullOrEmpty(_orderBy))
            query.Append(" ").Append(_orderBy);

        return query.ToString();
    }
}
