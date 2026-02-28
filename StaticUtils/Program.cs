using System;

// README.md를 읽고 아래에 코드를 작성하세요.


Console.WriteLine("=== Clamp 테스트 ===");
Console.WriteLine($"Clamp(-10, 0, 100) = {GameUtils.Clamp(-10, 0, 100)}");
Console.WriteLine($"Clamp(50, 0, 100) = {GameUtils.Clamp(50, 0, 100)}");
Console.WriteLine($"Clamp(150, 0, 100) = {GameUtils.Clamp(150, 0, 100)}");


Console.WriteLine("=== GetPercentage 테스트 ===");
Console.WriteLine($"GetPercentage(75, 100) = {GameUtils.GetPercentage(75, 100)}");
Console.WriteLine($"GetPercentage(30, 200) = {GameUtils.GetPercentage(30, 200)}");


Console.WriteLine("=== IsInRange 테스트 ===");
Console.WriteLine($"IsInRange(50, 0, 100) = {GameUtils.IsInRange(50, 0, 100)}");
Console.WriteLine($"IsInRange(-5, 0, 100) = {GameUtils.IsInRange(-5, 0, 100)}");
Console.WriteLine($"IsInRange(150, 0, 100) = {GameUtils.IsInRange(150, 0, 100)}");
