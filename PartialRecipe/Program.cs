using System;

// README.md를 읽고 아래에 코드를 작성하세요.


Recipe recipe1 = new Recipe("비빔밥", 2, 5);

recipe1.AddIngredient("밥");
recipe1.AddIngredient("고추장");
recipe1.AddIngredient("계란");
recipe1.AddIngredient("시금치");
recipe1.AddIngredient("당근");
recipe1.PrintRecipe();

Console.WriteLine($"계란 포함: {recipe1.Hasingredients("계란")}");
Console.WriteLine($"소고기 포함: {recipe1.Hasingredients("소고기")}");


Recipe recipe2 = new Recipe("샌드위치", 1, 3);

recipe2.AddIngredient("빵");
recipe2.AddIngredient("햄");
recipe2.AddIngredient("치즈");
recipe2.PrintRecipe();