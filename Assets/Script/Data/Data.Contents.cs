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
        public Texture diceTexture;
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
            int diceNumber = 1;
            Texture[] diceTexture = Resources.LoadAll<Texture>("/Textures/Dice");
            Dictionary<int, DiceStat> dict = new Dictionary<int, DiceStat>();
            foreach (DiceStat stat in diceStats)
            {
                stat.diceTexture.name = $"{diceNumber}";
                dict.Add(stat.diceTempelateID, stat);
                diceNumber++;
            }
            return dict;
        }
    }
    #endregion
}

