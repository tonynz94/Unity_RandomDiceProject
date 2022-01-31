using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    public int _CGUID;
    public int _life;
    public List<int> _myAllDice = new List<int>();
    public LinkedList<int> _myDeck = new LinkedList<int>();

    public GamePlayer(int CGUID)
    {
        _CGUID = CGUID;
        _life = 3;
    }

    public void AddDice(int diceTemplate)
    {
        _myAllDice.Add(diceTemplate);
    }
    
    public void AddOnBattleField(int diceTemplate)
    {
        //_myDeck.
    }

    public void RemoveFromBattleField(int diceTemplate)
    {
        //MyDeck
    }

    public void CleanUpBattleField()
    {
        //_myDeck.Clear();ff
    }
}
