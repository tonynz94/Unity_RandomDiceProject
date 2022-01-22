using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer
{
    int _CGUID;
    int _life;
    List<int> _myAllDice;
    LinkedList<int> _myDeck;

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
