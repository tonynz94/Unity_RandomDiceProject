using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Stat
[Serializable]
public class Stat
{
    public int level;
    public int hp;
    public int attack;
}

[Serializable]
public class DiceStatData : ILoader<int, Stat>
{
    public List<Stat> diceStats = new List<Stat>();

    public Dictionary<int, Stat> MakeDict()
    {
        Dictionary<int, Stat> dict = new Dictionary<int, Stat>();
        foreach (Stat stat in diceStats)
        {
            dict.Add(stat.level, stat);
        }

        return dict;
    }
}
#endregion