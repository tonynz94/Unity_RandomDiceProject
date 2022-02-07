using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region Stat
[Serializable]
public class DiceStat
{
    public int diceTemplateID;
    public int attack;
    public float attackSpeed;

    public Sprite diceImage;
}

[Serializable]
public class DiceStatData : ILoader<int, DiceStat>
{
    public List<DiceStat> diceStats = new List<DiceStat>();

    public Dictionary<int, DiceStat> MakeDict()
    {
        Dictionary<int, DiceStat> dict = new Dictionary<int, DiceStat>();

        foreach (DiceStat stat in diceStats)
        {
            stat.diceImage = Resources.Load<Sprite>($"Textures/Dice/{stat.diceTemplateID}");
            dict.Add(stat.diceTemplateID, stat);
        }

        return dict;
    }
}
#endregion