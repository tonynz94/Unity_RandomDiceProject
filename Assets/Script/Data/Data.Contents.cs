using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    #region DiceStat

    public class DiceStat
    {
        public int diceTempelateID;
        public string name;
        public int diceEye;
        public int diceClass;
        public int diceLevel;
        public int attack;
        public float attackSpeed;
        public System.Action target;
        public System.Action diceSkill;
        public System.Action state;
    }

    [Serializable]
    public class DiceStatData : ILoader<int, DiceStat>
    {
        public List<DiceStat> diceStats = new List<DiceStat>();
        public Dictionary<int, DiceStat> MakeDict()
        {
            Dictionary<int, DiceStat> dict = new Dictionary<int, DiceStat>();
            foreach (DiceStat stat in diceStats)
                dict.Add(stat.diceTempelateID, stat);
            return dict;
        }
    }
    #endregion
}

