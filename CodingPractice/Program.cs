using System;
using System.Data;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.


Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();

Hello hello = new Hello();
hello.Hi();
hello.Bye();

Calculator.Add(20, 10);
Calculator.Subtract(30, 10);
Calculator.Multiply(3, 10);

Console.WriteLine(StringHelper.CleanAndUpper("  hello world  "));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));

Console.WriteLine($"제곱근: {Math.Sqrt(16)}");
Console.WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
Console.WriteLine($"최댓값: {Math.Max(10, 20)}");
Console.WriteLine($"최솟값: {Math.Min(10, 20)}");

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");

StringBuilder sb2 = new StringBuilder();
sb2.Append("Hello")
    .Append(" ")
    .Append("World");

Console.WriteLine(sb.ToString());
Console.WriteLine(sb2.ToString());


string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Build();

Console.WriteLine(message);


Point point = new Point(0, 0).MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);
/*
point = point.MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

결국 새 객체를 생성하는 것이기 때문에 할당을 하지 않으면 결과를 볼 수 없음.
point 내부 값이 바뀌는게 아님 바꾸고 싶다면 point = point~ 를 해줘야한다
 */
Console.WriteLine(point);

string str = "  Hello World  ";
str = str.Trim().ToLower().Replace(" ", "_");
Console.WriteLine(str);

MutableCircle radius = new MutableCircle(10);
Console.WriteLine($"반지름: {radius.Radius}");
radius.Radius = 20;
Console.WriteLine($"반지름: {radius.Radius}");


ImmutableCircle circle = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle.Radius}");
Console.WriteLine($"새 원 반지름: {circle.WithRadius(20)}");
Console.WriteLine($"원본 반지름: {circle.Radius}");


Player player1 = new Player("용사", 1);
Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");

player1 = player1.LevelUp();
Console.WriteLine($"player2: {player1.Name}, 레벨 {player1.Level}");

str = "Hello";
Console.WriteLine($"원본: {str}");

str.ToUpper();
Console.WriteLine($"수정본: {str}");

Character character = new Character("용사", 100, 1);

Console.WriteLine($"{character._name} - 레벨: {character._level}, 체력: {character._health}");
character.TakeDamage(30);
character.Heal(10);


Console.WriteLine($"계산된 데미지: {GameHelper.CalculateDamage(10, 5)}");
Console.WriteLine($"생존 여부: {GameHelper.IsAlive(50)}");
Console.WriteLine($"체력 상태: {GameHelper.GetHealthStatus(30, 100)}");


Vector2D result = new Vector2D(1, 1)
    .Add(2, 3)       // (3, 4)
    .Multiply(2)     // (6, 8)
    .Add(-1, -2);    // (5, 6)

Console.WriteLine($"결과 벡터: {result}");
#region
partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    
}

partial class Person
{ 
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }


}


partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요!");
    }
    
}

partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
    
}


static class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine($"덧셈: {a + b}");
    }
    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"뺄셈: {a - b}");
    }
    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"곱셈: {a * b}");
    }
}

static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        input = input.Trim().ToUpper();

        return input;

    }

    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse( chars );
        return new string( chars );
    }

    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input); 
    }

}

class MessageBuilder
{
    public string Message { get; set; }
    public MessageBuilder AddText(string text)
    {
        Message += text;

        return this;
    }

    public MessageBuilder AddSpace()
    {
        Message += " ";

        return this;
    }

    public MessageBuilder AddNewLine()
    {
        Message += "\n";

        return this;
    }

    public string Build()
    {
        return Message.ToString();
    }
}


class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x; 
        Y = y; 
    }
    public Point MoveBy(int dx, int dy)
    {


        return new Point(X + dx, Y + dy);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class MutableCircle
{
    public int Radius {  get; set; }

    public MutableCircle(int radius)
    {
        this.Radius = radius; 
    }

}

class ImmutableCircle
{
    public int Radius { get;  }

    public ImmutableCircle(int radius)
    {
        Radius = radius;
    }

    public ImmutableCircle WithRadius(int newRadius)
    {
        return new ImmutableCircle(newRadius);
    }


}

class Player
{
    public readonly string Name;
    public readonly int Level;

    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public Player LevelUp()
    {
        
        
        return new Player(Name, Level + 1);
    }
}

partial class Character
{
    public string _name {  get; set; }
    public int _health {  get; set; }
    public int _level { get; set; }

    public Character(string name, int health, int level)
    {
        _name = name;
        _health = health;
        _level = level;
    }


}

partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }


    public void Heal(int heal)
    {
        _health += heal;
        Console.WriteLine($"{_name}이(가) {heal}의 회복함. 현재 체력: {_health}");
    }
}

#endregion


static class GameHelper
{
    public static int CalculateDamage(int baseDamage, int level)
    {
        return baseDamage + level * 5;
    }

    public static bool IsAlive(int health)
    {
        return health > 0; 
    }

    public static string GetHealthStatus(int health, int maxHealth)
    {
        if (maxHealth <= 0)
        {
            return health > 0 ? "오류" : "사망";
        }

        double ratio = (double)health / maxHealth;

        if (ratio > 0.7)
        {
            return "양호";
        }
        else if (ratio > 0.3)
        {
            return "주의";
        }
        else if (ratio > 0)
        {
            return "위험";
        }
        else
        {
            return "사망";
        }

    }
}

class Vector2D
{
    public readonly double X;
    public readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }

    public Vector2D Multiply(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

}