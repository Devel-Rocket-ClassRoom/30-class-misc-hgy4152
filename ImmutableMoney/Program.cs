using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Money money = new Money(100, 50);

Console.WriteLine("=== 초기 화폐 ===");
Console.WriteLine($"지갑: {money}");

Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {money.Add(50, 30)}");
Console.WriteLine($"원본 지갑: {money}");

Console.WriteLine("=== 화폐 차감 ===");
Console.WriteLine($"차감 후: {money.Subtract(20, 30)}");
Console.WriteLine($"원본 지갑: {money}");


Console.WriteLine("=== 메서드 체이닝 ===");
money = money.Add(20, 0).Subtract(0, 20);
Console.WriteLine($"결과: {money}");