using System;
using System.Collections.Generic;
using System.Text;


public class SoldierAttrStrategy:IAttrStrategy
{
    public int GetExtraHPValue(int lv)
    {
        return (lv - 1) * 10;
    }

    public int GetDmgDescValue(int lv)
    {
        return (lv - 1) * 5;
    }

    public int GetCritDmg(float critRate)
    {
        return 0;
    }
}
