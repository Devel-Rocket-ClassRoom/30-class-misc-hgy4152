using System;

// README.md를 읽고 아래에 코드를 작성하세요.
QueryBuilder builder1 = new QueryBuilder();

Console.WriteLine("=== 기본 쿼리 ===");
string basicQuery = builder1.Build();
Console.WriteLine(basicQuery);

QueryBuilder builder2 = new QueryBuilder();
Console.WriteLine("=== 조건 쿼리 ===");
string conditionQuery = builder2.Select("Name, Age").Where("Age > 18").Build();
Console.WriteLine(conditionQuery);


QueryBuilder builder3 = new QueryBuilder();
Console.WriteLine("=== 정렬 쿼리 ===");
string sortQuery = builder3.From("Products")
                        .Where("Price > 1000")
                        .OrderBy("Price")
                        .Build();

Console.WriteLine(sortQuery);