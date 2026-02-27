using System;
using System.Collections.Generic;
using System.Text;

class Money
{
    public readonly int Gold;
    public readonly int Silver;

    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public Money Add(int gold, int silver)
    {
        return new Money(Gold + gold, Silver + silver);
    }

    public Money Subtract(int gold, int silver)
    {
        if(Gold >= gold && Silver >= silver)
            return new Money(Gold - gold, Silver - silver);
        else 
        {
            return null;
        }
    }

    public override string ToString()
    {
        return $" {Gold}골드 {Silver}실버";
        
    }
}